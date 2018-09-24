using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelDBContext obj = new ModelDBContext();
            var data = obj.Products.ToList();
            var a = 10;
        }
    }
}
