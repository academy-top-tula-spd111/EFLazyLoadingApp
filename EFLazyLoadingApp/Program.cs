namespace EFLazyLoadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(ApplicationContext context = new())
            {
                var employees = context.Employees.ToList();
                foreach(var e in  employees)
                    Console.WriteLine($"{e.Name} {e.Position?.Title} {e.Company?.Title}");
            }
        }
    }
}