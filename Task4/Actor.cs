public class Actor
{
    string _fullName;
    string _gender;
    int _age;
    List<string> moviesPlayed = new List<string>();

    public Actor() { }
    public Actor(string fullName, int age, string gender)
    {
        _fullName = fullName;
        _gender = gender;
        _age = age;
    }
    public void AddMovie(string movieTitle)
    {
        moviesPlayed.Add(movieTitle);
    }
    public List<string> GetMoviesPlayed()
    {
        return moviesPlayed;
    }
    public void SetAge(int age)
    {
        _age = age;
    }
    public int GetAge()
    {
        return _age;
    }
    public void SetGender(string gender)
    {
        _gender = gender;
    }
    public string GetGender()
    {
        return _gender;
    }
    public void SetName(string name)
    {
        _fullName = name;
    }
    public string GetName()
    {
        return _fullName;
    }
    
}

