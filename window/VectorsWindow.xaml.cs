using System.Windows;
using System.Windows.Media;
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
            OutputTextBox.Text = "Առաջին վեկտորը սահմանվեց";
        }

        private void SetVector2Button_Click(object sender, RoutedEventArgs e)
        {
            TMath.services.Point[] points = ParsePoints();
            this.vector2 = TMath.services.Vector.FromPoints(points[0], points[1]);
            OutputTextBox.Text = "Երկրորդ վեկտորը սահմանվեց";
        }

        private void MagnitudeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = $"Առաջին վեկտորի երկարությունը: {vector1.Magnitude()}";
        }

        private void AngleBetweenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            double angle = TMath.services.Vector.AngleBetween(vector1, vector2);
            OutputTextBox.Text = $"Առաջին և երկրորդ վեկտորի միջև անկյունը: {angle} radians";
        }

        private void ProjectionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            double projection = TMath.services.Vector.Projection(vector1, vector2);
            OutputTextBox.Text = $"Առաջին վեկտորի պրոյեկցիան երկրորդ վեկտորի վրա: {projection}";
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = $"Առաջին վեկտոր: ({vector1.X}, {vector1.Y}, {vector1.Z})\n";
            OutputTextBox.Text += $"Երկրորդ վեկտոր: ({vector2.X}, {vector2.Y}, {vector2.Z})\n\n";

            OutputTextBox.Text += $"Առաջին վեկտորի երկարությունը: {vector1.Magnitude()}\n";

            double angle = TMath.services.Vector.AngleBetween(vector1, vector2);
            OutputTextBox.Text += $"Առաջին և երկրորդ վեկտորի միջև անկյունը: {angle} ռադիան\n";

            double projection = TMath.services.Vector.Projection(vector1, vector2);
            OutputTextBox.Text += $"Առաջին վեկտորի պրոյեկցիան երկրորդ վեկտորի վրա: {projection}\n";
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

            MessageBox.Show("Անվավեր մուտքագրում: Խնդրում ենք մուտքագրել վավեր թվային արժեքներ կորդինատների համար:", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
            OutputTextBox.Text = $"Vector1 - Vector2 =  ({result.X}, {result.Y}, {result.Z})";
        }
        private void MultiplyScalarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Մուտքագրեք թվային արժեքը:", "Աստիճանի բարձրացում");

            if (double.TryParse(userInput, out double scalar))
            {
                TMath.services.Vector result = vector1 * scalar;
                OutputTextBox.Text = $"Vector1 * {scalar} = ({result.X}, {result.Y}, {result.Z})";
            }
            else
            {
                MessageBox.Show("Սխալ տեղի ունեցավ: Խնդրում եմ մուտքագրեք ճշգրիտ թիվ։");
            }
        }
    }
}
