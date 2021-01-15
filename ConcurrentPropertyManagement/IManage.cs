using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentPropertyManagement
{
    interface IManage<T>
    {
      Task Manage();

        bool IsBookingComplete();
    }
}
