using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FileOpenDialogBox.Model {
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
                NotifyPropertyChanged("FileName");
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



        public void NotifyPropertyChanged(string property) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
