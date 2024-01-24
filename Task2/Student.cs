

public class Student
{

     string _fullName;
     int _age;
     int _grade;
    public Student() {}
    public Student(string name, int age)
    {
        _fullName = name;
        _age = age;
    }
    public Student(string name, int age, int grade)
    {
        _fullName = name;
        _age = age;
        _grade = grade;
    }


    public string Study()
    {
        return $"{_fullName} studyng .";
    }
    public void SetGrade(int grade)
    {
        _grade = grade;
    }
    public int GetGrade()
    {
        return _grade;
    }

}