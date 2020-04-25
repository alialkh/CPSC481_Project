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


// trilokStuff import! 
// all of triloks .CS files fall under the WpfApp1 namespace, and thats why we are using it here
using WpfApp1;

namespace CPSC481
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int zIndexOfOverlay;
        Vector members = new Vector();

        public MainWindow()
        {
            InitializeComponent();

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

        private void SearchButtonListener(object sender, RoutedEventArgs e)
        {
            Window trilokStuff = new trilok_MainWindow();
            trilokStuff.Show();

            this.Close();
        }

        private void RandomRecipeListener(object sender, RoutedEventArgs e)
        {
            // fire up the french toast card immediately
            Window trilokStuff = new FrenchToastCard();
            trilokStuff.Show();

            this.Close();
        }

        private void BreakfastListener(object sender, RoutedEventArgs e)
        {
            // fire up the french toast card immediately
            Window trilokStuff = new FrenchToastCard();
            trilokStuff.Show();

            this.Close();
        }

        private void LunchListener(object sender, RoutedEventArgs e)
        {
            // fire up the french toast card immediately
            Window trilokStuff = new FrenchToastCard();
            trilokStuff.Show();

            this.Close();
        }

        private void DinnerListener(object sender, RoutedEventArgs e)
        {
            // fire up the french toast card immediately
            Window trilokStuff = new FrenchToastCard();
            trilokStuff.Show();

            this.Close();
        }

        private void DesertListener(object sender, RoutedEventArgs e)
        {
            // fire up the french toast card immediately
            Window trilokStuff = new FrenchToastCard();
            trilokStuff.Show();

            this.Close();
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
    }
}
