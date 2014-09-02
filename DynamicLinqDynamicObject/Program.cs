using System;
using System.Linq.Dynamic;
using System.Collections.Generic;
using System.Security;
using System.Linq;
using System.Dynamic;
using System.Linq.Expressions;

namespace DynamicLinqDynamicObject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new List<Data>();

            var dataInstance = new Data();
            list.Add(new Data()
            {
                Storage = new Data()
                {
                    Name = "Hello World"
                },
                Name = "Test"
            });

            list.Add(dataInstance);

            Console.WriteLine(list.First().Storage.Name);

            var result = list.Where("it.Storage != null").Select("it.Storage");
            var res2 = result.Where("it.Name = @0", "Test");

            Console.WriteLine(res2.ToString());
        }
    }
}
