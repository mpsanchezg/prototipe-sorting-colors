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
using System.Windows.Threading;
using System.Diagnostics;


namespace SortingColorsGame
{
    /// <summary>
    /// Lógica de interacción para SortingGame.xaml
    /// </summary>
	public partial class SortingGame : Window
    {
        int red_images_sorted    = 0;
        int yellow_images_sorted = 0;
        int blue_images_sorted   = 0;
        int green_images_sorted  = 0;

        private Dictionary<int, UIElement> movingEllipses = new Dictionary<int, UIElement>();

        private Dictionary<string, int> initialImagesPosition = new Dictionary<string, int>();

        private List<Image>      images;
        private List<Point> imageCoords;
        

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        string currentTime = string.Empty;

		public SortingGame()
		{
            
			InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dt_Tick);
            images = new List<Image> ();
            imageCoords = new List<Point> ();
        }

		public static bool Relative { get; internal set; }

        void dt_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                clocktxtblock.Text = currentTime;
            }
        }

        private void reset_window()
        {
            red_images_sorted = 0;
            yellow_images_sorted = 0;
            blue_images_sorted = 0;
            green_images_sorted = 0;

            red_image1.Visibility = Visibility.Visible;
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            dispatcherTimer.Start();
        }

        private void stopbtn_Click(object sender, RoutedEventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
            }
        }

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Reset();
            clocktxtblock.Text = "00:00:00";
        }

		private void canvas_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
		{
			e.ManipulationContainer = canvas;
			e.Mode = ManipulationModes.Translate;
		}

		private void canvas_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
		{
			UIElement element = (UIElement)e.Source;
            UIElement btn = (UIElement)red_button;
            Matrix matrix = ((MatrixTransform)element.RenderTransform).Matrix;
			ManipulationDelta deltaManipulation = e.DeltaManipulation;
			Image iE = (Image)element;
            Point center = new Point(iE.ActualWidth / 2, iE.ActualWidth / 2);

            if (!(images.Contains(iE)))
            {
                images.Add(iE);
                imageCoords.Add(center);
            }

            center = matrix.Transform(center);

			matrix.Scale(deltaManipulation.Scale.X, deltaManipulation.Scale.Y);
			matrix.Translate(e.DeltaManipulation.Translation.X, e.DeltaManipulation.Translation.Y);

			Point red_button_point = new Point(red_button.ActualWidth, red_button.ActualHeight);

			((MatrixTransform)element.RenderTransform).Matrix = matrix;
			
		}

		private void canvas_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
		{
			UIElement element = (UIElement)e.Source;
			Matrix matrix = ((MatrixTransform)element.RenderTransform).Matrix;
			Image iE = (Image)element;

			iE.Visibility = Visibility.Collapsed;
		}

        private void red_image_TouchUp(object sender, TouchEventArgs e)
        {
            Image image = (Image)sender;

            var image_coord_x = e.GetTouchPoint(canvas).Position.X;
            var image_coord_y = e.GetTouchPoint(canvas).Position.Y;

            if (image_coord_x < 335 && image_coord_y < 270)
            {
                image.Visibility = Visibility.Collapsed;
                red_images_sorted++;                
            }

            if (red_images_sorted >= 4 && blue_images_sorted >= 4 && green_images_sorted >= 4 && yellow_images_sorted >= 4)
            {
                if (stopwatch.IsRunning)
                {
                    stopwatch.Stop();
                }
                elapsedtimeitem.Items.Add(currentTime);
                MessageBox.Show("Juego Terminado");
                InitializeComponent();
                reset_window();
            }
        }

        private void blue_image_TouchUp(object sender, TouchEventArgs e)
        {
            Image image = (Image)sender;

            var image_coord_x = e.GetTouchPoint(canvas).Position.X;
            var image_coord_y = e.GetTouchPoint(canvas).Position.Y;

            if (image_coord_x < 335 && image_coord_y > 400)
            {
                image.Visibility = Visibility.Collapsed;
                blue_images_sorted++;
            }

            if (red_images_sorted >= 4 && blue_images_sorted >= 4 && green_images_sorted >= 4 && yellow_images_sorted >= 4)
            {
                if (stopwatch.IsRunning)
                {
                    stopwatch.Stop();
                }
                elapsedtimeitem.Items.Add(currentTime);
                MessageBox.Show("Juego Terminado");
                reset_window();
            }
        }

        private void green_image_TouchUp(object sender, TouchEventArgs e)
        {
            Image image = (Image)sender;

            var image_coord_x = e.GetTouchPoint(canvas).Position.X;
            var image_coord_y = e.GetTouchPoint(canvas).Position.Y;

            if (image_coord_x > 925 && image_coord_y < 270)
            {
                image.Visibility = Visibility.Collapsed;
                green_images_sorted++;
            }

            if (red_images_sorted >= 4 && blue_images_sorted >= 4 && green_images_sorted >= 4 && yellow_images_sorted >= 4)
            {
                if (stopwatch.IsRunning)
                {
                    stopwatch.Stop();
                }
                elapsedtimeitem.Items.Add(currentTime);
                MessageBox.Show("Juego Terminado");
                reset_window();
            }
        }

        private void yellow_image_TouchUp(object sender, TouchEventArgs e)
        {
            Image image = (Image)sender;

            var image_coord_x = e.GetTouchPoint(canvas).Position.X;
            var image_coord_y = e.GetTouchPoint(canvas).Position.Y;

            if (image_coord_x > 925 && image_coord_y > 270)
            {
                image.Visibility = Visibility.Collapsed;
                yellow_images_sorted++;
            }

            if (red_images_sorted >= 4 && blue_images_sorted >= 4 && green_images_sorted >= 4 && yellow_images_sorted >= 4)
            {
                if (stopwatch.IsRunning)
                {
                    stopwatch.Stop();
                }
                elapsedtimeitem.Items.Add(currentTime);
                MessageBox.Show("Juego Terminado");
                reset_window();
            }
        }

        private void finishbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tiempo de ordenamiento: " + currentTime);
            SortingGame sortingGame = new SortingGame();
            sortingGame.WindowState = WindowState.Maximized;
            this.Close();
            sortingGame.ShowDialog();
        }
    }
}
