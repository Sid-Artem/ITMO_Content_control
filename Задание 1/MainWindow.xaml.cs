using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Задание_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontname=((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null) 
            { 
                textBox.FontFamily=new FontFamily(fontname);
            
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontsize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
           
            if (textBox != null)
            {
                textBox.FontSize=fontsize;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else 
            {

                textBox.FontWeight = FontWeights.Normal;


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic; 
            }
            else
            {

                textBox.FontStyle = FontStyles.Normal;


            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (textBox.TextDecorations.Count == 0)
            {

                textBox.TextDecorations.Add(TextDecorations.Underline);
            }
            else 
            { 
                textBox.TextDecorations.RemoveAt(0);
            }


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if(textBox != null)
            {

                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {

                textBox.Foreground = Brushes.Red;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Тестовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter="Тестовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true) 
            { 
                textBox.Text=File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}
