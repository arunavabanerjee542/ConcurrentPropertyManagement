using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentPropertyManagement
{
    class Program
    {
        static  void Main(string[] args)
        {
            BookingManager bookingManager = new BookingManager();
            Employee employee = new Employee();

            ConcurrencyChannel<string> channel = new ConcurrencyChannel<string>();

            Task.WaitAll(employee.Manage(channel),
                bookingManager.Book(channel),
                bookingManager.Book(channel),
                bookingManager.Book(channel),
                bookingManager.Book(channel),
                employee.Manage(channel),
                employee.Manage(channel)
                );

            Console.ReadLine();


        }
    }
}
