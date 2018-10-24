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
		private Dictionary<int, UIElement> movingEllipses = new Dictionary<int, UIElement>();

        public SortingGame()
        {
            InitializeComponent();
        }

		public static bool Relative { get; internal set; }

		private void canvas_TouchDown(object sender, TouchEventArgs e)
		{
			Ellipse ellipse = new Ellipse();
			ellipse.Width = 30;
			ellipse.Height = 30;
			ellipse.Stroke = Brushes.White;
			ellipse.Fill = Brushes.Green;
			TouchPoint touchPoint = e.GetTouchPoint(canvas);
			Canvas.SetTop(ellipse, touchPoint.Bounds.Top);
			Canvas.SetTop(ellipse, touchPoint.Bounds.Left);

			movingEllipses[e.TouchDevice.Id] = ellipse;
			canvas.Children.Add(ellipse);
		}

		private void canvas_TouchUp(object sender, TouchEventArgs e)
		{
			UIElement element = movingEllipses[e.TouchDevice.Id];
			canvas.Children.Remove(element);
			movingEllipses.Remove(e.TouchDevice.Id);
		}

		private void canvas_TouchMove(object sender, TouchEventArgs e)
		{
			UIElement element = movingEllipses[e.TouchDevice.Id];
			Ellipse ellipse = (Ellipse) element;
			TouchPoint touchPoint = e.GetTouchPoint(canvas);
			Canvas.SetTop(ellipse, touchPoint.Bounds.Top);
			Canvas.SetTop(ellipse, touchPoint.Bounds.Left);
		}

	}
}
