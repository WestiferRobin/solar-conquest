using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Name => $"{FirstName} {LastName}";

    public User(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}
