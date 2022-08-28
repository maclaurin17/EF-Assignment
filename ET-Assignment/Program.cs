using EFCoreFirst.Models;
namespace EFCoreFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReceiveData();
           
        }

        static void ReceiveData()
        {
            try
            {
                var mydbcontext = new MyDbContext();
                var employe = new Employee();
                var depart = new Department();
                employe.Id = 1293;
                employe.FirstName = "Tosin";
                employe.LastName = "Adefila";
                employe.Gender = "Female";
                employe.Salary = 30000;
                mydbcontext.Employees.Add(employe);
                var noOfInsertedRows = mydbcontext.SaveChanges();
                Console.WriteLine($"{noOfInsertedRows} was successfully inserted");
            }
            catch ( Exception ex)
            {

                Console.WriteLine("Sorry! Something went wrong");
                Console.ReadLine();
            }
        }
    }

}