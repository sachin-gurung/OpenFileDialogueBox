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
using WpfApp2.ViewModel.MainViewModel;

namespace FileOpenDialogBox {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e) {
            (DataContext as MainViewModel).UserModel.SubmitButtonClick(); 
        }

        private void closeButton_Click(object sender, RoutedEventArgs e) {
            Window.GetWindow(this).Close();
        }

        private void clearButton_Click(Object sender, RoutedEventArgs e) {
            (DataContext as MainViewModel).UserModel.ClearButtonClick();
            }
        }
    }

