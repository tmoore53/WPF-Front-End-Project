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

namespace WpfApp_26March2020
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

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Discription value is: {discriptionTextBox.Text}");
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            this.weldCheckBox.IsChecked = this.assemblyCheckBox.IsChecked = this.plasmaCheckBox.IsChecked = this.laserCheckBox.IsChecked = this.purchaseCheckBox.IsChecked =
                this.latheCheckBox.IsChecked = this.drillCheckBox.IsChecked = foldCheckBox.IsChecked = rollCheckBox.IsChecked = sawCheckBox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.lengthTextBox.Text += ((CheckBox)sender).Content;
        }

        private void finishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Make sure the value is not null, if it is exit out.
            if (noteTextBox == null)
                return;

            this.noteTextBox.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            finishDropdown_SelectionChanged(this.finishDropDownBox, null);
        }
    }
}
