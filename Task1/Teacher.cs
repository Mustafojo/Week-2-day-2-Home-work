

public class Teacher
{
    string _fullName;
    string _subject;
    int _experience;
    public string Teach()
    {
        return $"{_fullName} teaching {_subject}.";
    }
    public void SetExperience(int years)
    {
        _experience = years;
    }
    public int GetExperience()
    {
        return _experience;
    }
    public Teacher() {}
    public Teacher(string name, string subject)
    {
        _fullName = name;
        _subject = subject;
    }
    public Teacher(string name, string subject, int experience)
    {
        _fullName = name;
        _subject = subject;
        _experience = experience;
    }

}