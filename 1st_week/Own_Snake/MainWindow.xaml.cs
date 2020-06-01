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

namespace Own_Snake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int snakeSize = 20;
        public MainWindow()
        {
            InitializeComponent();
            DrawSnake();
        }

        private void DrawSnake()
        {
            byte rowNumber = 1;
            bool isDone = false;
            bool isOdd = true;

            while (isDone == false)
            {
                UIElement rectangle = new Rectangle()
                {
                    Width = snakeSize,
                    Height = snakeSize,
                    Fill = isOdd ? Brushes.Black : Brushes.White
                };

            }
        }
    }
}
