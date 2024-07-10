using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooShop.Application.Services;

namespace ZooShop.Application.Services
{
    public static class EnumExtentions
    {
        public static List<TEnum> ToList<TEnum>(this Type type) where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            return Enum.GetValues(type).OfType<TEnum>().ToList();
        }
    }
}
