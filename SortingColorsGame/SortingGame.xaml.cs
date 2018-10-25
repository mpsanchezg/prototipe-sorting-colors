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
                
		private void canvas_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
		{
			e.ManipulationContainer = canvas;
			e.Mode = ManipulationModes.Translate;
		}

		private void canvas_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
		{
			UIElement element = (UIElement)e.Source;
			Matrix matrix = ((MatrixTransform)element.RenderTransform).Matrix;

			ManipulationDelta deltaManipulation = e.DeltaManipulation;
			Image iE = (Image)element;
			Point center = new Point(iE.ActualWidth/2, iE.ActualWidth/2);
			center = matrix.Transform(center);

			matrix.Scale(deltaManipulation.Scale.X, deltaManipulation.Scale.Y);
			matrix.Translate(e.DeltaManipulation.Translation.X, e.DeltaManipulation.Translation.Y);

			((MatrixTransform)element.RenderTransform).Matrix = matrix;
            
		}
	}
}
