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

namespace SortingColorsGame
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
		}

		private void start_button_Click(object sender, RoutedEventArgs e)
		{
			if(team_name_textBox.Text == "")
			{
				MessageBox.Show("Ingrese un nombre");
			}
			else
			{
				SortingGame sortingGame = new SortingGame();
                sortingGame.WindowState = WindowState.Maximized;
                this.Close();
				sortingGame.ShowDialog();
			}
		}
	}
}
