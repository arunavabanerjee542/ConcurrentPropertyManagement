using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentPropertyManagement
{
    class BookingManager
    {

        public async Task Book(IBook<string> activity)
        {
            
             activity.book("HOTEL");
            activity.BookingComplete();
            await  Task.Delay(1000);
            activity.book("HOSPITAL");
            activity.BookingComplete();
            await Task.Delay(1000);
            activity.book("RESTAURANT");
            activity.BookingComplete();
            await Task.Delay(1000);
            activity.book("THEATRE");
            activity.BookingComplete();
            await Task.Delay(1000);

           
            //return Task.CompletedTask;

        }


    }
}
