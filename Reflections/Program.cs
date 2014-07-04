using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        private static int NoofIteration = 100000;
        static void Main(string[] args)
        {

            StandardListCreation();
            ReflectionListCreation();
            standardMethodListCreation();
            ReflectionMethodCreation();

        }

        private static void ReflectionMethodCreation()
        {
            Type listtype = typeof (List<int>);
            Type[] parameter = {typeof (int)};
            MethodInfo method = listtype.GetMethod("Add", parameter);
            for (int i = 0; i < NoofIteration; i++)
            {
                method.Invoke(new List<int>(), new object[]{i});
            }

        }

        private static void standardMethodListCreation()
        {
            throw new NotImplementedException();
        }

        private static void ReflectionListCreation()
        {
            var starttime = DateTime.Now;
            Type Listetype = typeof (List<int>);
            for (int i = 0; i < 100000; i++)
            {
                Activator.CreateInstance(Listetype);
            }
            var endtime = DateTime.Now;

        }

        private static void calculateDuration(DateTime starttime, DateTime endTime)
        {
     //       Console.WriteLine(new DateTime(starttime).Subtract(endTime));
        }

        private static void StandardListCreation()
        {
            var starttime = DateTime.Now;
            for (int i = 0; i < NoofIteration; i++)
            {
                var lsit = new List<int>();
            }
            var endTime = DateTime.Now;
            calculateDuration(starttime, endTime);
        }
    }
}
