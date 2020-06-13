using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfPractice.Commands;
using WpfPractice.Models;

namespace WpfPractice.ViewModels
{
    public class HouseViewModel
    {
        ObservableCollection<House> houses = new ObservableCollection<House>();
        HouseButtonCommands _commandClass;
        
        public  HouseViewModel()
        {
            _commandClass = new HouseButtonCommands(this);
        }

        public ICommand btnClick() => _commandClass;


        public void CreateHouse()
        {
            House house = new House();
        }
    }

}
