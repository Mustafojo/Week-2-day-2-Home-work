public class Doctor
{
    string _fullName;
    string _specialty;
    int    _experience;
    public string TreatPatient(string patientName)
    {
        return $"{_fullName}, {_specialty}, лечит пациента по имени {patientName}";
    }
    public string PerformMedicalExamination(string patientName)
    {
        return $"{_fullName} проводит медицинское обследование для пациента по имени {patientName}";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{_fullName} назначает {medication} пациенту по имени {patientName}";
    }
    public void SetExperience(int years)
    {
        _experience = years;
    }
    public int GetExperience()
    {
        return _experience;
    }
    public Doctor(){}
    public Doctor(string fullName, string specialty)
    {
        _fullName = fullName;
        _specialty = specialty;
    }
    public Doctor(string fullName, string specialty, int experience)
    {
        _fullName = fullName;
        _specialty = specialty;
        _experience = experience;
    }
}