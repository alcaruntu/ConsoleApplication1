using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a comment.
            var testClass = new TestClass();
            testClass.Property1 = (string) "123";
            testClass.Property2 = (string)"1234";
        }
    }

    public class TestClass
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
    }
}
