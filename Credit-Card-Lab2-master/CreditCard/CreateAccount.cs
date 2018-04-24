class CreateAccount
{
    string firstName;
    string lastName;
    string dateOfBirth;
    int age;

    protected string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception();
            else firstName = value;
        }
    }
    protected string LastName
    {
        get { return this.lastName; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception();
            else lastName = value;
        }
    }
    protected string DateOfBirth
    {
        get { return this.dateOfBirth; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception();
            else dateOfBirth = value;
        }
    }
    
    public void GenerateAccount()
    { 
         // code for asking user for their details.
        data.Add(this);
    }
}
