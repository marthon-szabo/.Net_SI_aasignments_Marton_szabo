using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfPractice.ViewModels;

namespace WpfPractice.Commands
{
    class HouseButtonCommands : ICommand
    {
        HouseViewModel _vm;

        public event EventHandler CanExecuteChanged;

        public HouseButtonCommands(HouseViewModel vm)
        {
            _vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            return (parameter != null) ? true : false;
        }

        public void Execute(object parameter)
        {
            _vm.CreateHouse();
        }
    }
}
