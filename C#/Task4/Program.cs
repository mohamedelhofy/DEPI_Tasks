namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alice", 20, "Computer Science", 3.8);
            Student student2 = new Student("Bob", 22, "Mathematics", 3.5);
            Console.WriteLine(student1);
            Console.WriteLine(student2);
        }
    }
}
