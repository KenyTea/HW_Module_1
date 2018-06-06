using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HW_Module_1.Modules
{
    public class Helper
    {

            List<Item> listItem = new List<Item>();


        public void CreateXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://habrahabr.ru/rss/interesting/");

            var rootElement = doc.DocumentElement;
            foreach (XmlNode item in rootElement.ChildNodes)
            {
               // Console.WriteLine(">" + item.Name);
                foreach (XmlNode ch in item.ChildNodes)
                {
                   // Console.WriteLine("->" + ch.Name);
                    if (ch.Name == "item")
                    {
                        Item hn = new Item();

                        foreach (XmlNode i in ch.ChildNodes)
                        {
                            if (i.Name == "title")
                            {
                                hn.Title = i.InnerText;
                            }
                            else if (i.Name == "link")
                            {
                                hn.Link = i.InnerText;
                            }
                            else if (i.Name == "description")
                            {
                                hn.Description = i.InnerText;
                            }
                            else if (i.Name == "pubDate")
                            {
                                hn.PubDate = DateTime.Parse(i.InnerText);
                            }
                        }
                        listItem.Add(hn);
                    }
                }
            }
        }

        public void PrintList()
        {
            foreach (var item in listItem)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Link);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.PubDate);
            }
        }

        //public void AddToXmlDocument()
        //{
        //    string path = @"HabrXML.xml";

        //    var document = new XmlDocument();
        //    var xmlDeclaration = document.CreateXmlDeclaration("1.0", "UTF-8", null);
        //    var root = document.DocumentElement;
        //    document.InsertBefore(xmlDeclaration, root);
        //    var userList = document.CreateElement(nameof(listUsers));

        //    foreach (var us in listUsers)
        //    {
        //        var nodeU = document.CreateElement(nameof(User));
        //        nodeU.SetAttribute(nameof(User.Login), us.Login);
        //        nodeU.SetAttribute(nameof(User.Pass), us.Pass);
        //        nodeU.SetAttribute(nameof(User.PravaDostupa_), (us.PravaDostupa_).ToString());
        //        userList.AppendChild(nodeU);
        //    }
        //    document.AppendChild(userList);
        //    document.Save(path);

        //}

    }
}
