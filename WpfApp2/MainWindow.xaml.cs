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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileOpenDialogBox {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void folderSelect_GotFocus(object sender, RoutedEventArgs e) {
            // Configure open file dialog box
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document"; // Default file name
            dialog.DefaultExt = ".txt"; // Default file extension
            dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result == true) {
                // Open document
                string filename = dialog.FileName;
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e) {
            Window.GetWindow(this).Close();
        }

        private void clearButton_Click(Object sender, RoutedEventArgs e) {
            FileNameBox.Clear();
            FolderSelect.Clear();
            TextBox.Clear();
            }
        }
    }

