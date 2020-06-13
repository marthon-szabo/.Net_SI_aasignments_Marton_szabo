using RegEx.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;

namespace RegEx.ViewModels
{
    class UserViewModel : INotifyPropertyChanged
    {
        User _user = new User();
        UserCommands _uCommands;
        string _phone;
        SolidColorBrush _phoneBg;
        string _email;
        Brushes _emailBg;

        #region PropertyChange

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyChange(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        #endregion

        public UserViewModel()
        {
            _uCommands = new UserCommands(this);
        }

        #region Properties
        public SolidColorBrush PhoneBg { get { return _phoneBg; } }

        public string Name { get { return _user.Name; } set { _user.Name = value; } }
        
        public string Phone { get { return _user.Phone; } 
            set 
            {
                if (_user.Phone != value || _user.Phone != null)
                {
                    _user.Phone = value;
                    NotifyChange("Phone");
                }
               
            } }
        
        public string Email { get { return _email; } set { _email = value; } }

        #endregion

        public ICommand btnClick
        {
            get
            {
                return _uCommands;
            }
        }

        public void CheckAttributes()
        {
            if (isNull())
            {
                MessageBox.Show("Please fill every box!",
                        "Validation error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (_user.CheckPhone(Phone) && _user.CheckEmail(_email))
                {
                    MessageBox.Show(Phone);
                    Phone = ReformatPhone(Phone);
                }
                else
                {
                    _phoneBg = Brushes.LightGreen;
                    MessageBox.Show("false");
                }
            }
        }

        public string ReformatPhone(string original)
        {
            char[] chars = original.ToCharArray();
            StringBuilder sb = new StringBuilder();
            sb.Append("(");

            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 3)
                {
                    sb.Append(")");
                }
                else if (i == 7)
                {
                    sb.Append("-");
                }
                sb.Append(chars[i].ToString());
            }

            return sb.ToString();
        }

        public bool isNull()
        {
            return (Phone == null || _email == null) ? true : false;
        }
    }
}
