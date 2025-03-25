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

namespace Triangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int triangleSide = 1300;
        public static double moveFactor = 2.0;

        public static int dot1X = 0;
        public static int dot1Y = triangleSide / 2;

        public static int dot2X = triangleSide;
        public static int dot2Y = 0;

        public static int dot3X = triangleSide;
        public static int dot3Y = triangleSide;

        public double currentX = dot1X;
        public double currentY = dot1Y;

        public MainWindow()
        {
            InitializeComponent();

            canvas.Height = triangleSide;
            canvas.Width = triangleSide;

            DrawDot(dot1X, dot1Y);
            DrawDot(dot2X, dot2Y);
            DrawDot(dot3X, dot3Y);

            var counter = 0;

            while (counter < 200000)
            {
                var randGuidStr = Guid.NewGuid().ToString();
                for (int i = 0; i < 32; i++)
                {
                    switch (randGuidStr.Substring(i,1))
                    {
                        case "1":
                            MoveTo(1);
                            break;
                        case "2":
                            MoveTo(2);
                            break;
                        case "3":
                            MoveTo(3);
                            break;

                        case "4":
                            MoveTo(1);
                            break;
                        case "5":
                            MoveTo(2);
                            break;
                        case "6":
                            MoveTo(3);
                            break;

                        case "7":
                            MoveTo(1);
                            break;
                        case "8":
                            MoveTo(2);
                            break;
                        case "9":
                            MoveTo(3);
                            break;

                        case "0":
                            MoveTo(1);
                            break;
                        case "a":
                            MoveTo(2);
                            break;
                        case "b":
                            MoveTo(3);
                            break;

                        case "c":
                            MoveTo(1);
                            break;
                        case "d":
                            MoveTo(2);
                            break;
                        case "e":
                            MoveTo(3);
                            break;

                        default:
                            break;
                    }

                    counter++;
                }
            }
        }

        private void DrawDot(double x, double y)
        {
            Rectangle rec = new Rectangle();
            Canvas.SetTop(rec, x);
            Canvas.SetLeft(rec, y);
            rec.Width = 1;
            rec.Height = 1;
            rec.Fill = new SolidColorBrush(Colors.Black);
            canvas.Children.Add(rec);
        }

        private void MoveTo(int point)
        {
            switch(point)
            {
                case 1:
                    DrawDot(currentX = (dot1X + currentX) / moveFactor, currentY = (dot1Y + currentY) / moveFactor);
                    break;
                case 2:
                    DrawDot(currentX = (dot2X + currentX) / moveFactor, currentY = (dot2Y + currentY) / moveFactor);
                    break;
                case 3:
                    DrawDot(currentX = (dot3X + currentX) / moveFactor, currentY = (dot3Y + currentY) / moveFactor);
                    break;
                default:
                    break;
            }
        }
    }
}
