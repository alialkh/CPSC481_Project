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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class trilok_MainWindow : Window
    {

        private int zIndexOfOverlay;

        public trilok_MainWindow()
        {
            InitializeComponent();
            gridRefine.Visibility = Visibility.Collapsed;
            gridList.Visibility = Visibility.Collapsed;

            // Hide all the preferences crap

            overlayRect.Visibility = Visibility.Hidden;
            Overlay.Opacity = 1;

            zIndexOfOverlay = Panel.GetZIndex(Overlay);

            prefTable.Visibility = Visibility.Hidden;
            prefHeader.Visibility = Visibility.Hidden;
        }

        private void PreferencesListener(object sender, RoutedEventArgs e)
        {
            overlayRect.Visibility = Visibility.Visible;
            Panel.SetZIndex(Overlay, 1000);
            Overlay.Opacity = 0.85;

            prefTable.Visibility = Visibility.Visible;
            prefHeader.Visibility = Visibility.Visible;

        }

        private void returnPreferences(object sender, RoutedEventArgs e)
        {
            overlayRect.Visibility = Visibility.Hidden;
            Overlay.Opacity = 1;
            Panel.SetZIndex(Overlay, zIndexOfOverlay);

            prefTable.Visibility = Visibility.Hidden;
            prefHeader.Visibility = Visibility.Hidden;
        }

        private void clearPrefs(object sender, RoutedEventArgs e)
        {
            foreach (UIElement x in prefTable.Children)
            {
                if (x is Label)
                {
                    Label y = x as Label;
                    if (y.Foreground.ToString().Equals(new SolidColorBrush(Colors.Green).Color.ToString()))
                    {
                        y.Foreground = new SolidColorBrush(Colors.White);
                    }
                }
            }
        }

        private void cancelPrefs(object sender, RoutedEventArgs e)
        {
            foreach (UIElement x in prefTable.Children)
            {
                if (x is Label)
                {
                    Label y = x as Label;
                    if (y.Foreground.ToString().Equals(new SolidColorBrush(Colors.Green).Color.ToString()))
                    {
                        y.Foreground = new SolidColorBrush(Colors.White);
                    }
                }
            }

            returnPreferences(null, null);
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label choice = sender as Label;

            if (choice.Foreground.ToString().Equals(new SolidColorBrush(Colors.Green).Color.ToString()))
            {
                choice.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                choice.Foreground = new SolidColorBrush(Colors.Green);
            }
        }

        private void favOne_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (favOne.Foreground == Brushes.DarkOrange)
            {
                favOne.Foreground = Brushes.Black;
            }
            else
            {
                favOne.Foreground = Brushes.DarkOrange;
            }
        }

        private void favTwo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (favTwo.Foreground == Brushes.DarkOrange)
            {
                favTwo.Foreground = Brushes.Black;
            }
            else
            {
                favTwo.Foreground = Brushes.DarkOrange;
            }
        }

        private void favThree_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (favThree.Foreground == Brushes.DarkOrange)
            {
                favThree.Foreground = Brushes.Black;
            }
            else
            {
                favThree.Foreground = Brushes.DarkOrange;
            }
        }

        private void favFour_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (favFour.Foreground == Brushes.DarkOrange)
            {
                favFour.Foreground = Brushes.Black;
            }
            else
            {
                favFour.Foreground = Brushes.DarkOrange;
            }
        }

        private void refineOne_Click(object sender, RoutedEventArgs e)
        {
            gridRefine.Visibility = Visibility.Visible;
            refineOne.Visibility = Visibility.Collapsed;
        }

        private void refineTwo_Click(object sender, RoutedEventArgs e)
        {
            gridRefine.Visibility = Visibility.Collapsed;
            refineOne.Visibility = Visibility.Visible;
        }

        private void listOne_Click(object sender, RoutedEventArgs e)
        {
            gridList.Visibility = Visibility.Visible;
            listOne.Visibility = Visibility.Collapsed;
        }

        private void listTwo_Click(object sender, RoutedEventArgs e)
        {
            gridList.Visibility = Visibility.Collapsed;
            listOne.Visibility = Visibility.Visible;
        }

        private void GoToRecipeCard(object sender, MouseButtonEventArgs e)
        {
            Window recipe = new FrenchToastCard();
            recipe.Show();

            this.Close();
        }
    }
}
