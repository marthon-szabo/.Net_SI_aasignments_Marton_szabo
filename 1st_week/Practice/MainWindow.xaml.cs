using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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

namespace Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            users.Add(new User() { Name = "Mr.Smith" });
            users.Add(new User() { Name = "Mrs.Smith" });

            lbUsers.ItemsSource = users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Do you want to add new user?", "Operation",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                users.Add(new User());
            }
        }
    }

    public class User : INotifyPropertyChanged
    {
        string name;
        static byte counter = 1;
        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public User()
        {
            if (name == null)
            {
                name = $"NewUser{counter++}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
