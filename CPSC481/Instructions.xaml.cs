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

namespace CPSC481
{
    /// <summary>
    /// Interaction logic for Instructions.xaml
    /// </summary>
    public partial class Instructions : Window
    {
        public Instructions()
        {
            InitializeComponent();
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

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
