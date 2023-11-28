using System.Windows;
using TMath.services;

namespace TMath
{
    /// <summary>
    /// Interaction logic for VectorsWindow.xaml
    /// </summary>
    public partial class VectorsWindow : Window
    {
        private TMath.services.Vector vector1;
        private TMath.services.Vector vector2;
        public VectorsWindow()
        {
            InitializeComponent();
            vector1 = new TMath.services.Vector(0, 0, 0);
            vector2 = new TMath.services.Vector(0, 0, 0);
        }

        private void SetVector1Button_Click(object sender, RoutedEventArgs e)
        {
            TMath.services.Point[] points = ParsePoints();
            this.vector1 = TMath.services.Vector.FromPoints(points[0], points[1]);
            OutputTextBox.Text = $"Vector1 setted successfully";
        }

        private void SetVector2Button_Click(object sender, RoutedEventArgs e)
        {
            TMath.services.Point[] points = ParsePoints();
            this.vector2 = TMath.services.Vector.FromPoints(points[0], points[1]);
            OutputTextBox.Text = $"Vector2 setted successfully";
        }

        private void MagnitudeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = $"Magnitude of Vector: {vector1.Magnitude()}";
        }

        private void AngleBetweenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            double angle = TMath.services.Vector.AngleBetween(vector1, vector2);
            OutputTextBox.Text = $"Angle between Vector1 and Vector2: {angle} radians";
        }

        private void ProjectionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            double projection = TMath.services.Vector.Projection(vector1, vector2);
            OutputTextBox.Text = $"Projection of Vector1 onto Vector2: ({projection})";
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = $"Vector1: ({vector1.X}, {vector1.Y}, {vector1.Z})\n";
            OutputTextBox.Text += $"Vector2: ({vector2.X}, {vector2.Y}, {vector2.Z})\n\n";

            OutputTextBox.Text += $"Magnitude of Vector1: {vector1.Magnitude()}\n";

            double angle = TMath.services.Vector.AngleBetween(vector1, vector2);
            OutputTextBox.Text += $"Angle between Vector1 and Vector2: {angle} radians\n";

            double projection = TMath.services.Vector.Projection(vector1, vector2);
            OutputTextBox.Text += $"Projection of Vector1 onto Vector2: ({projection})\n";
        }

        private TMath.services.Point[] ParsePoints()
        {
            if (double.TryParse(Point1X.Text, out double x1) &&
                double.TryParse(Point1Y.Text, out double y1) &&
                double.TryParse(Point1Z.Text, out double z1) &&
                double.TryParse(Point2X.Text, out double x2) &&
                double.TryParse(Point2Y.Text, out double y2) &&
                double.TryParse(Point2Z.Text, out double z2))
            {
                TMath.services.Point point1 = new TMath.services.Point(x1, y1, z1);
                TMath.services.Point point2 = new TMath.services.Point(x2, y2, z2);
                return [point1, point2];
            }

            MessageBox.Show("Invalid input. Please enter valid numeric values for points.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return [new TMath.services.Point(0,0,0), new TMath.services.Point(0, 0, 0)];
        }

        private void AdditionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            TMath.services.Vector result = vector1 + vector2;
            OutputTextBox.Text = $"Vector1 + Vector2 =  ({result.X}, {result.Y}, {result.Z})";
        }

        private void SubtractionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            TMath.services.Vector result = vector1 - vector2;
            OutputTextBox.Text = $"Vector1 + Vector2 =  ({result.X}, {result.Y}, {result.Z})";
        }
        private void MultiplyScalarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            double scalar = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter scalar value:", "Scalar Multiply"));
            TMath.services.Vector result = vector1 * scalar;
            OutputTextBox.Text = $"Vector1 * {scalar} = ({result.X}, {result.Y}, {result.Z})";
        }
    }
}
