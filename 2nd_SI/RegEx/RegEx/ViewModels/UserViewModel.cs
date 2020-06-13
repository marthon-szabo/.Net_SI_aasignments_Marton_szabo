using RegEx.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace RegEx.ViewModels
{
    class UserViewModel
    {
        User _user = new User();
        UserCommands _uCommands;
        string _phone;
        SolidColorBrush _phoneBg;
        string _email;
        Brushes _emailBg;

        public UserViewModel()
        {
            _uCommands = new UserCommands(this);
        }

        #region Properties
        public SolidColorBrush PhoneBg { get { return _phoneBg; } }

        public string Name { get { return _user.Name; } set { _user.Name = value; } }
        
        public string Phone { get { return _phone; } 
            set 
            {
                
                _phone = value; 
               
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
                if (_user.CheckPhone(_phone) && _user.CheckEmail(_email))
                {
                    MessageBox.Show("true");
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
            return String.Format("(###)###-####", original);
        }

        public bool isNull()
        {
            return (_phone == null || _email == null) ? true : false;
        }
    }
}
