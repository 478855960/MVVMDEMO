using System.ComponentModel;

namespace WpfApp1.Model
{
    public class UserModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 用户名
        /// </summary>
        private int userId;
        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                NotifyPropertyChanged("UserId");
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                NotifyPropertyChanged("UserName");
            }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        private int userAge;
        public int UserAge
        {
            get
            {
                return userAge;
            }
            set
            {
                userAge = value;
                NotifyPropertyChanged("UserAge");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        private string userEmail;
        public string UserEmail
        {
            get
            {
                return userEmail;
            }
            set
            {
                userEmail = value;
                NotifyPropertyChanged("UserEmail");
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        private string userSex;
        public string UserSex
        {
            get
            {
                return userSex;
            }
            set
            {
                userSex = value;
                NotifyPropertyChanged("UserSex");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
