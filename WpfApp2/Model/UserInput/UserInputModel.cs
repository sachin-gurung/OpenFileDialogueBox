using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace FileOpenDialogBox.Model.UserInput {
    class UserInputModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Private Fields
        private static string fileNameBox;
        private static string textBox;
        #endregion

        #region Public Properties
        public string FileNameBox {
            get { return fileNameBox; } set {
                fileNameBox = value;
                NotifyPropertyChanged("FileNameBox");
            }
        }

        public string TextBox {
            get { return textBox; }
            set {
                textBox = value;
                NotifyPropertyChanged("TextBox");
            }
        }
        #endregion

        static UserInputModel() {
            fileNameBox = "";
            textBox = "";
        }

        public void SubmitButtonClick() {
            // Configure save file dialog box
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = FileNameBox; // Default file name
            saveFileDialog.DefaultExt = ".txt"; // Default file extension
            saveFileDialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            saveFileDialog.InitialDirectory = @"D:\temp\";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, TextBox);
                FileNameBox = "";
                TextBox = "";
        }

        public void ClearButtonClick() {
            FileNameBox = "";
            TextBox = "";
        }

        public void NotifyPropertyChanged(string property) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
