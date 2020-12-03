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

namespace WPFCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _navi = this.myFrame.NavigationService;
        }

        private NavigationService _navi;

        private List<Uri> _uriList = new List<Uri>() {
            new Uri("/Pages/Member/Member.xaml",UriKind.Relative),
            new Uri("/Pages/Device/Device.xaml",UriKind.Relative)
        };


        private void myFrame_Loaded(object sender, RoutedEventArgs e)
        {
            _navi.Navigate(_uriList[0]);
        }


        private void BtnMember_Click(object sender, RoutedEventArgs e)
        {          
                _navi.Navigate(_uriList[0]);
             }
        private void BtnPC_Click(object sender, RoutedEventArgs e)
        {
            _navi.Navigate(_uriList[1]);
          
                

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var con = new Classes.DBConnection();
            

           


        }
    }
}
