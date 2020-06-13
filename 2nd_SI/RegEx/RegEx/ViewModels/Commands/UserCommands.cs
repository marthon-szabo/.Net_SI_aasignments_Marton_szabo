using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegEx.ViewModels.Commands
{


    class UserCommands : ICommand
    {
        UserViewModel _uvm;

        public UserCommands(UserViewModel uvm)
        {
            _uvm = uvm;
        }


        #region Command part

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _uvm.CheckAttributes();
        }

        

        #endregion

    }
}
