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
using System.Windows.Shapes;

namespace SortingColorsGame
{
    /// <summary>
    /// Lógica de interacción para SortingGame.xaml
    /// </summary>
    public partial class SortingGame : Window
    {
        public SortingGame()
        {
            InitializeComponent();
        }

		public static bool Relative { get; internal set; }
	}
}
