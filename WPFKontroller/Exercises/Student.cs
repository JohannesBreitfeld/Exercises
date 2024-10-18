using System.ComponentModel;

namespace WPFKontroller.Exercises
{
    public class Student : INotifyPropertyChanged
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = $"{firstName}@gmail.com".ToLower();
        }
        public Student()
        {
            FirstName = "New";
            LastName = string.Empty;
            Email = string.Empty;
        }
        private string _firstname;
        private string _lastname;
        private string _email;
        
        public string FirstName 
        { 
            get => _firstname;
            set
            {
                if (_firstname != value)
                {
                    _firstname = value;
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }
        public string LastName 
        {
            get => _lastname;
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }
        public string Email 
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            } 
        }
        public string FullName => $"{FirstName} {LastName}";

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
