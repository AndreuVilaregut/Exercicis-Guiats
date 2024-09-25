using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercicis
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
        //private void Botó1_Click(object sender, RoutedEventArgs e)
        //{
        //    Etiqueta.Content = "Text canviat!";
        //    Botó2.Background = new SolidColorBrush(Colors.LightGreen);
        //}

        //private void Botó2_Click(object sender, RoutedEventArgs e)
        //{
        //    Etiqueta.Content = "Hola, món!";
        //    Botó2.Background = new SolidColorBrush(Colors.Red);
        //}
        //private void ActivarCampCheckbox_Checked(object sender, RoutedEventArgs e)
        //{
        //    CampExtraTextBox.Visibility = Visibility.Visible;
        //}

        //private void ActivarCampCheckbox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    CampExtraTextBox.Visibility = Visibility.Collapsed;
        //}

        //private void EnviarButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(NomTextBox.Text))
        //    {
        //        MessageBox.Show("El nom no pot estar buit.");
        //        return;
        //    }

        //    if (!int.TryParse(EdatTextBox.Text, out int edat))
        //    {
        //        MessageBox.Show("L'edat ha de ser un número.");
        //        return;
        //    }

        //    if (edat < 0 || edat > 120)
        //    {
        //        MessageBox.Show("Introdueix una edat vàlida.");
        //        return;
        //    }

        //    MessageBox.Show("Formulari enviat correctament.");
        //}

        //private void MostraMissatgeButton_Click(object sender, RoutedEventArgs e)
        //{

        //    MessageBox.Show("Això és un missatge informatiu!", "Missatge", MessageBoxButton.OK, MessageBoxImage.Information);
        //}


        //private void ObrirArxiuButton_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Title = "Selecciona un arxiu";
        //    openFileDialog.Filter = "Tots els arxius (*.*)|*.*";


        //    if (openFileDialog.ShowDialog() == true)
        //    {

        //        string filePath = openFileDialog.FileName;

        //        MessageBox.Show($"Has seleccionat l'arxiu: {filePath}", "Arxiu seleccionat", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No has seleccionat cap arxiu.", "Avís", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //}

        private void AfegirButton_Click(object sender, RoutedEventArgs e)
        {
            string nouItem = nouItemTextBox.Text;

            if (!string.IsNullOrWhiteSpace(nouItem))
            {
                llistaItems.Items.Add(nouItem);
                nouItemTextBox.Clear();  
            }
            else
            {
                MessageBox.Show("El camp d'entrada no pot estar buit!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

            if (llistaItems.SelectedItem != null)
            {
                llistaItems.Items.Remove(llistaItems.SelectedItem);  
                elementSeleccionatTextBox.Clear();  
            }
            else
            {
                MessageBox.Show("No hi ha cap element seleccionat per eliminar.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LlistaItems_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (llistaItems.SelectedItem != null)
            {
                elementSeleccionatTextBox.Text = llistaItems.SelectedItem.ToString();  
            }
            else
            {
                elementSeleccionatTextBox.Clear();  
            }
        }


    }
}