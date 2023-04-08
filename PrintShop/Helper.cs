using PrintShop.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintShop
{
    internal class Helper
    {
        private static Entities s_Entities;

        public static Entities GetContext()
        {
            if (s_Entities == null)
            {
                s_Entities = new Entities();
            }
            return s_Entities;
        }
    }
}
