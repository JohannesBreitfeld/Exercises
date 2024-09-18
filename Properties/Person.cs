using System.Runtime.CompilerServices;

class Person
{
    private string _firstName;
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
    public string LastName { get; set; } 
    public string FullName { get => FirstName + " " + LastName; }
}