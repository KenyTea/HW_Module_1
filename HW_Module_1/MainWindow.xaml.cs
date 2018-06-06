using HW_Module_1.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_Module_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Helper helper = new Helper();
        


        private void BtnGet_Click(object sender, RoutedEventArgs e)
        {
            helper.CreateXml();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            helper.CreateXml();
        }
    }
}
