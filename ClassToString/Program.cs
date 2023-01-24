namespace ClassToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                FirstName = "Doğukan",
                LastName = "Gümüş"
            };
            Console.WriteLine(student.ToString());
        }
    }
}
