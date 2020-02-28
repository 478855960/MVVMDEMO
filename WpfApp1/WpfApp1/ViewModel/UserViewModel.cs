using System;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class UserViewModel
    {
        public DelegateCommand ShowCommand { get; set; }
        public UserModel User { get; set; }
        public UserViewModel()
        {
            User = new UserModel();
            ShowCommand = new DelegateCommand();
            ShowCommand.ExecuteCommand = new Action<object>(ShowUserData);
        }
        private void ShowUserData(object obj)
        {
            User.UserId = 1;
            User.UserName = "xiaoyang";
            User.UserAge = 22;
            User.UserEmail = "478855960@qq.com";
            User.UserSex = "靓仔";
        }

    }

    public class DelegateCommand : ICommand
    {
        public Action<object> ExecuteCommand = null;
        public Func<object, bool> CanExecuteCommand = null;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteCommand != null)
            {
                return this.CanExecuteCommand(parameter);
            }
            else
            {
                return true;
            }
        }

        public void Execute(object parameter)
        {
            if (this.ExecuteCommand != null)
            {
                this.ExecuteCommand(parameter);
            }
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
