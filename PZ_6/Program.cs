


var ATEST = new List<Student>
{
  new Student("alex",4),
    new Student("bob",5),
      new Student("duma",3),
        new Student("Boba",2),
};

PrintGoodStudents();
Console.WriteLine("///");
PrintbadStudents();
void PrintGoodStudents()
{
    var goodStudens = ATEST.Where(s => s.Grade >= 4) 
            .ToList();
    goodStudens.ForEach(s => Console.WriteLine(s.Name)); 
}
void PrintbadStudents()
{
    var badStudens = ATEST.Where(s => s.Grade < 4)
            .ToList();
    badStudens.ForEach(s => Console.WriteLine(s.Name));
  
    var NOAtest = new List<Student> { }
;
    foreach (var ATEST in NOAtest)
        NOAtest.Add(ATEST);
    
}

class Student
{
   
 public string Name { get; private set; }
    public int Grade { get; private set; }
    public Student(string name, int grade)
    {
       Name = name;
        Grade = grade;
    }
}