using FileOpenDialogBox.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using System.IO;

namespace FileOpenDialogBox {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e) {
            // Configure save file dialog box
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = FileNameBox.Text; // Default file name
            saveFileDialog.DefaultExt = ".txt"; // Default file extension
            saveFileDialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            saveFileDialog.InitialDirectory = @"D:\temp\";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, TextBox.Text);
                FileNameBox.Clear();
                TextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e) {
            Window.GetWindow(this).Close();
        }

        private void clearButton_Click(Object sender, RoutedEventArgs e) {
            FileNameBox.Clear();
            TextBox.Clear();
            }
        }
    }

