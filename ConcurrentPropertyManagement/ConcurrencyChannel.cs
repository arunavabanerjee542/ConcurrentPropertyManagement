using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentPropertyManagement
{
    class ConcurrencyChannel<T>: IManage<T>, IBook<T>
    {
        public ConcurrentQueue<T> activities;

        SemaphoreSlim permit;


        public ConcurrencyChannel()
        {
            activities = new ConcurrentQueue<T>();
            permit = new SemaphoreSlim(0);
        }




        bool bookingFlag = false;

        public void book(T property)
        {
            Console.WriteLine(property + " BOOKED");
           activities.Enqueue(property);
            permit.Release();
            
        }

        public void BookingComplete()
        {
            //Console.WriteLine(" Booking Done ");
            bookingFlag = true;
            
        }

        public bool IsBookingComplete()
        {
            return bookingFlag;


        }




        public async Task Manage()
        {
           await permit.WaitAsync();

            while(activities.TryDequeue(out T propertyToBeManaged))
            {
                
                Console.WriteLine(" Employees now have completed the management of " +propertyToBeManaged);
            }

           
        }



    }

}
