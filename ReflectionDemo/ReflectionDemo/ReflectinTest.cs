using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class ReflectinTest
    {
        public static void Test()
        {
            Type type = Type.GetType("ReflectionDemo.Customer");

            Console.WriteLine("full Name " +type.FullName);
           
            Console.WriteLine("Class name "+type.Name);
            Console.WriteLine("--------------");
            Console.WriteLine("Method In Customer Class");
            // method
          
            MethodInfo[] methods = type.GetMethods();

            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name);


            }
            // properties
            Console.WriteLine("--------------");
            Console.WriteLine("Properties in customer class");
            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+property.Name);
            }

            // constructor
            Console.WriteLine("--------------");
            Console.WriteLine("Constructor in Customer class");

            ConstructorInfo[] constructors = type.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());          
            }
        }
       
    }
}
