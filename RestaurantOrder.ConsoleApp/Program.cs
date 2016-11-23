using System;

using RestaurantOrder.Data;

namespace RestaurantOrder.ConsoleApp
{
    class Program
    {

        /// <summary>
        /// Aplikacja wykorzystywana jest wyłącznie do inicjalizacji bazy danych danymi menu, można zrobić to samo consoli
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Initialize database...");

                DataContext dataContet = new DataContext();
                dataContet.Database.Initialize(true);

                Console.WriteLine("Done...");
                Console.WriteLine("Press ENTER to continue...");

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }

        }
    }
}
