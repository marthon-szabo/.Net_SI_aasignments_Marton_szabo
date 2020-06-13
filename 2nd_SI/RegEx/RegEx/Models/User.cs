using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    public class User : INotifyPropertyChanged
    {
        #region Fields
        string _name;
        string _phone;
        string _eMail;
        #endregion

        #region Properties
        public String Name
        {
            get { return _name; }

            set
            {
                if (!_name.Equals(value))
                {
                    _name = value;
                    NotifyChange("Name");
                }
            }
        }
        
        public String Phone
        {
            get { return _phone; }

            set
            {
               
                _phone = value;
                NotifyChange("Phone");
            }
        }
        
        public String Email
        {
            get { return _eMail; }

            set
            {
                _eMail = value;
                NotifyChange("Phone");
            }
        }

        #endregion

        #region InotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyChange(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        #endregion

        public bool CheckPhone(string phone)
        {
            if (!Regex.IsMatch(phone, @"[0-9]{11}|[+,0-9]{12}"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        internal bool CheckEmail(string email)
        {
            if (!Regex.IsMatch(email, @"[.@]"))
            {
                return false;
            }
            else
            {
                Email = email;
                return true;
            }
        }
    }
}
