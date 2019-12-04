using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testQuestion1;
using NUnit.Framework;

namespace listifyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Listify listify = new Listify(100, 200);
            var val = listify[50];
            Assert.AreEqual(val, 150);
        }
    }
}
