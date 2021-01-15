using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentPropertyManagement
{
    class Employee
    {
        public async Task Manage(IManage<string> manage)
        {
            if (manage.IsBookingComplete())
            {
                await manage.Manage();
            }

        }

    }
}
