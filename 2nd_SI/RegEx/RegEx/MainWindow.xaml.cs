using RegEx.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace RegEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserViewModel _uvm;

        TextBlock attention = new TextBlock()
        {
            Foreground = Brushes.Red,
        };

        public MainWindow()
        {
            InitializeComponent();
            _uvm = new UserViewModel();
            DataContext = _uvm;
        }

        private void NameGotFocus(object sender, TextChangedEventArgs e)
        {
            
            if (!Regex.IsMatch(txtName.Text, @"[a-zA-Z]+"))
            {
                txtName.Background = Brushes.Red;
                BadName.Visibility = Visibility.Visible;
            }
            else
            {
                txtName.Background = Brushes.LightGreen;
                BadName.Visibility = Visibility.Hidden;
            }

        }
       



        
    }
        
}
