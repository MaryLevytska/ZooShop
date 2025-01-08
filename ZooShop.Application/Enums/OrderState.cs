using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop.Application.Enums
{
    public enum OrderState
    {
        New = 1,
        Processing = 2,
        Sent = 5,
        Completed = 10,
        Canceled = 15,
    }
}
