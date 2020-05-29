using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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

namespace WpfApp_1st_SI_Practice__
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Title = "Registration";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button submitButton = sender as Button;
            string[] userDatas = { txtName.Text, txtEmail.Text, txtComment.Text };
            string regText = $"Dear {userDatas[0]}\nYou have been registered succesfully on the " +
                $"following Email adress:\n{userDatas[1]}";
            MessageBox.Show(regText, "Registration", MessageBoxButton.OK, MessageBoxImage.Information);
            txtName.Text = "";
            txtEmail.Text = "";
            txtComment.Text = "";
            

            
        }
    }
}
