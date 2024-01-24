var actor = new Actor();
actor.SetName("Mustafo");
actor.SetGender("M");
actor.SetAge(16);
actor.AddMovie("Iron Man");
actor.AddMovie("Avengers: Endgame");
actor.AddMovie("Sherlock Holmes");


System.Console.Write("Actor's Name: ");
System.Console.WriteLine(actor.GetName());
System.Console.Write("Age: ");
System.Console.WriteLine(actor.GetAge());
System.Console.Write("Gender: ");
System.Console.WriteLine(actor.GetGender());
System.Console.WriteLine("Movies Played by Robert Downey Jr.:");
int cnt=1;
foreach (var item in actor.GetMoviesPlayed())
{
    System.Console.WriteLine($"{cnt}. {item}");
    cnt++;
    
}



