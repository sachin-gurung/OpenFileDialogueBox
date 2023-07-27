using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileOpenDialogBox.Model.UserInput;

namespace WpfApp2.ViewModel.MainViewModel {
    class MainViewModel {
        private static UserInputModel _userInputModel;
        public UserInputModel UserModel { get { return _userInputModel; } private set { _userInputModel = value; } }
        static MainViewModel() {
            _userInputModel = new UserInputModel();
        }
    }
}
