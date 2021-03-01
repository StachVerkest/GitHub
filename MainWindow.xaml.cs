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

namespace GitHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int iCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void BtnButton_Click(object sender, RoutedEventArgs e)
        {
            LblHello.Content = "Hello World";
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

            iCount = iCount + 1;
            LblCount.Content=iCount;
        }
    }
}
