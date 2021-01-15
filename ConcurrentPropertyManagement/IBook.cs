using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentPropertyManagement
{
    interface IBook<T>
    {
        void book(T property);

        void BookingComplete();
    }
}
