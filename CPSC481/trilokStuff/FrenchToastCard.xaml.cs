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

namespace WpfApp1
{
    //Recipe from https://www.mccormick.com/recipes/breakfast-brunch/quick-and-easy-french-toast
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FrenchToastCard : Window
    {
        public FrenchToastCard()
        {
            InitializeComponent();
        }

        private void ServingsAdd(object sender, RoutedEventArgs e)
        {
            int numServings = Int32.Parse(Servings.Text);
            numServings++;
            Servings.Text = numServings.ToString();
            changeServings(numServings);
        }

        private void DecreaseServings(object sender, RoutedEventArgs e)
        {
            int numServings = Int32.Parse(Servings.Text);
            if (numServings <= 1)
            {
                numServings = 1;
                Servings.Text = numServings.ToString();
            }
            else 
            {
                numServings--;
                Servings.Text = numServings.ToString();
            }
            changeServings(numServings);
        }

        private void changeServings(int numServings)
        {
            if (numServings == 1) {
                person.Visibility = Visibility.Visible;
                people.Visibility = Visibility.Hidden;
                Quantity1.Visibility = Visibility.Visible;
                Quantity2.Visibility = Visibility.Hidden;
                Quantity3.Visibility = Visibility.Hidden;
                Quantity4.Visibility = Visibility.Hidden;
            }
            else if (numServings == 2) {
                person.Visibility = Visibility.Hidden;
                people.Visibility = Visibility.Visible;
                Quantity1.Visibility = Visibility.Hidden;
                Quantity2.Visibility = Visibility.Visible;
                Quantity3.Visibility = Visibility.Hidden;
                Quantity4.Visibility = Visibility.Hidden;
            }
            else if (numServings == 3) {
                person.Visibility = Visibility.Hidden;
                people.Visibility = Visibility.Visible;
                Quantity1.Visibility = Visibility.Hidden;
                Quantity2.Visibility = Visibility.Hidden;
                Quantity3.Visibility = Visibility.Visible;
                Quantity4.Visibility = Visibility.Hidden;
            }
            else if (numServings == 4)
            {
                person.Visibility = Visibility.Hidden;
                people.Visibility = Visibility.Visible;
                Quantity1.Visibility = Visibility.Hidden;
                Quantity2.Visibility = Visibility.Hidden;
                Quantity3.Visibility = Visibility.Hidden;
                Quantity4.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
        
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Hyperlink_Enter(object sender, MouseEventArgs e)
        {
            RecipeName.Foreground = Brushes.Blue;
            RecipeName.TextDecorations = System.Windows.TextDecorations.Underline;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Hyperlink_Leave(object sender, MouseEventArgs e)
        {
            RecipeName.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
            RecipeName.TextDecorations = null;
        }

        private void Hyperlink1_Enter(object sender, MouseEventArgs e)
        {
            RecipeName1.Foreground = Brushes.Blue;
            RecipeName1.TextDecorations = System.Windows.TextDecorations.Underline;
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Hyperlink1_Leave(object sender, MouseEventArgs e)
        {
            RecipeName1.Foreground = Brushes.Black;
            Mouse.OverrideCursor = Cursors.Arrow;
            RecipeName1.TextDecorations = null;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox step = sender as CheckBox;
            TextBlock text = step.Content as TextBlock;
            text.TextDecorations = TextDecorations.Strikethrough;
            text.Opacity = 0.45;
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox step = sender as CheckBox;
            TextBlock text = step.Content as TextBlock;
            text.TextDecorations = null;
            text.Opacity = 1.0;
        }

        private void GoToInstructions(object sender, RoutedEventArgs e)
        {
            Window instructions = new Instructions();
            instructions.Show();

            this.Close();

        }

        private void returnButton(object sender, RoutedEventArgs e)
        {
            Window returnWindow = new trilok_MainWindow();
            returnWindow.Show();

            this.Close();
        }
    }
}
