namespace ConsoleApp5
{
     class Program
    {
        static void Main(string[] args)
        {
          Student student  =new Student("Ali","Shukurov","AB106",93);
            
            student.GetInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();
        }
    }
}
