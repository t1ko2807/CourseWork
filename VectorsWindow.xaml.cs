using System.Windows;
using TMath.services;

namespace TMath
{
    /// <summary>
    /// Interaction logic for VectorsWindow.xaml
    /// </summary>
    public partial class VectorsWindow : Window
    {
        private TMath.services.Point point1;
        private TMath.services.Point point2;
        public VectorsWindow()
        {
            InitializeComponent();
        }
        private void MagnitudeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (TryParsePoints())
            {
                TMath.services.Vector vector = TMath.services.Vector.FromPoints(point1, point2);
                OutputTextBox.Text = $"Magnitude of Vector: {vector.Magnitude()}";
            }
        }

        // Обработчик события для подпункта "Angle Between"
        private void AngleBetweenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (TryParsePoints())
            {
                TMath.services.Vector vector1 = TMath.services.Vector.FromPoints(point1, point2);
                TMath.services.Vector vector2 = new TMath.services.Vector(2, 3, 4);
                double angle = TMath.services.Vector.AngleBetween(vector1, vector2);
                OutputTextBox.Text = $"Angle between Vector1 and Vector2: {angle} radians";
            }
        }

        // Обработчик события для подпункта "Projection"
        private void ProjectionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (TryParsePoints())
            {
                TMath.services.Vector vector1 = TMath.services.Vector.FromPoints(point1, point2);
                TMath.services.Vector vector2 = new TMath.services.Vector(2, 3, 4);
                double projection = TMath.services.Vector.Projection(vector1, vector2);
                OutputTextBox.Text = $"Projection of Vector1 onto Vector2: ({projection})";
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryParsePoints())
            {
                TMath.services.Vector vector1 = TMath.services.Vector.FromPoints(point1, point2);
                TMath.services.Vector vector2 = new TMath.services.Vector(2, 3, 4);

                OutputTextBox.Text = $"Vector1: ({vector1.X}, {vector1.Y}, {vector1.Z})\n";
                OutputTextBox.Text += $"Vector2: ({vector2.X}, {vector2.Y}, {vector2.Z})\n\n";

                OutputTextBox.Text += $"Magnitude of Vector1: {vector1.Magnitude()}\n";

                double angle = TMath.services.Vector.AngleBetween(vector1, vector2);
                OutputTextBox.Text += $"Angle between Vector1 and Vector2: {angle} radians\n";

                double projection = TMath.services.Vector.Projection(vector1, vector2);
                OutputTextBox.Text += $"Projection of Vector1 onto Vector2: ({projection})\n";
            }
        }

        private bool TryParsePoints()
        {
            if (double.TryParse(Point1X.Text, out double x1) &&
                double.TryParse(Point1Y.Text, out double y1) &&
                double.TryParse(Point1Z.Text, out double z1) &&
                double.TryParse(Point2X.Text, out double x2) &&
                double.TryParse(Point2Y.Text, out double y2) &&
                double.TryParse(Point2Z.Text, out double z2))
            {
                point1 = new TMath.services.Point(x1, y1, z1);
                point2 = new TMath.services.Point(x2, y2, z2);
                return true;
            }

            MessageBox.Show("Invalid input. Please enter valid numeric values for points.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

    }
}
