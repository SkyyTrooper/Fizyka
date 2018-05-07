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
using System.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        public double ComputePi()
        {
            int n;
            double pi;
            Random rng = new Random();
            double x = 0.0, y = 0.0;
            double c = 0.0;
            string  input = textBox.Text;
            n = int.Parse(input);
            double i;
            //
            int dotSize = 5;
            //Ellipse currentDot = new Ellipse();
            //currentDot.Stroke = new SolidColorBrush(Colors.Green);
            //currentDot.StrokeThickness = 3;
            //Canvas.SetZIndex(currentDot, 3);
            //currentDot.Height = dotSize;
            //currentDot.Width = dotSize;
            //currentDot.Fill = new SolidColorBrush(Colors.Green);
            // currentDot.Margin = new Thickness(100, 100, 0, 0); // Sets the position.
            //myCanva.Children.Add(currentDot);
            //
            double x1;
            double y1;

            for (i = 1.0; i <= n; i++)
            {



                if (n > 10000)
                {
                    x = rng.NextDouble() * 2 - 1;
                    y = rng.NextDouble() * 2 - 1;
                    x1 = x;
                    y1 = y;

                    x1 = (x1 * 100) + 100;
                    y1 = (y1 * 100) + 100;

                    if (((x * x) + (y * y) <= 1.0))
                    {
                        c++;
                    }



                        if (i % 100 == 0)
                    {

                        Ellipse currentDot = new Ellipse();
                        currentDot.Stroke = new SolidColorBrush(Colors.Green);

                        if (((x * x) + (y * y) <= 1.0))
                        {
                           
                            currentDot.Stroke = new SolidColorBrush(Colors.PaleVioletRed);

                        }

                        currentDot.StrokeThickness = 3;
                        Canvas.SetZIndex(currentDot, 3);
                        currentDot.Height = dotSize;
                        currentDot.Width = dotSize;
                        currentDot.Fill = new SolidColorBrush(Colors.Green);
                        currentDot.Margin = new Thickness(x1, y1, 0, 0);
                        myCanva.Children.Add(currentDot);
                        

                    }
                }

                else
                {








                    x = rng.NextDouble() * 2 - 1;
                    y = rng.NextDouble() * 2 - 1;
                    x1 = x;
                    y1 = y;

                    x1 = (x1 * 100) + 100;
                    y1 = (y1 * 100) + 100;




                    Ellipse currentDot = new Ellipse();
                    currentDot.Stroke = new SolidColorBrush(Colors.Green);

                    if (((x * x) + (y * y) <= 1.0))
                    {
                        c++;
                        currentDot.Stroke = new SolidColorBrush(Colors.PaleVioletRed);

                    }

                    currentDot.StrokeThickness = 3;
                    Canvas.SetZIndex(currentDot, 3);
                    currentDot.Height = dotSize;
                    currentDot.Width = dotSize;
                    currentDot.Fill = new SolidColorBrush(Colors.Green);
                    currentDot.Margin = new Thickness(x1, y1, 0, 0);
                    myCanva.Children.Add(currentDot);
                    
                    



                }
            }
            pi = 4 * (c / i);
            return pi;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double pi = ComputePi();
            textBlock1.Text = pi.ToString();
        }
    }
}
