using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 3; i++)
            {

                if (i == 1)
                {
                    Assembly assembly1 = Assembly.Load("EmployeeComponent");
                    Type[] types = assembly1.GetTypes();
                    foreach (Type type in types)
                    {
                        Console.WriteLine("BaseType:{0}", type.BaseType);
                        Console.WriteLine("Name:{0}", type.Name);
                        MethodInfo[] methods = type.GetMethods();
                        foreach (MethodInfo method in methods)
                        {
                            Console.WriteLine("Method name:{0}", method.Name);
                            Console.WriteLine("Return Type:{0}", method.ReturnType);

                            ParameterInfo[] parameters = method.GetParameters();
                            foreach (ParameterInfo param in parameters)
                            {
                                Console.WriteLine("Base name:{0}", param.Name);
                                Console.WriteLine("Base Type:{0}", param.ParameterType);
                                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                            }
                            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                        }
                        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


                    }
                }
                else if (i == 2)
                {
                    Assembly assembly2 = Assembly.Load("ProductName");
                    Type[] types2 = assembly2.GetTypes();
                    foreach (Type type in types2)
                    {
                        Console.WriteLine("BaseType:{0}", type.BaseType);
                        Console.WriteLine("Name:{0}", type.Name);
                        MethodInfo[] methods = type.GetMethods();
                        foreach (MethodInfo method in methods)
                        {
                            Console.WriteLine("Method name:{0}", method.Name);
                            Console.WriteLine("Return Type:{0}", method.ReturnType);

                            ParameterInfo[] parameters = method.GetParameters();
                            foreach (ParameterInfo param in parameters)
                            {
                                Console.WriteLine("Base name:{0}", param.Name);
                                Console.WriteLine("Base Type:{0}", param.ParameterType);
                                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                            }
                            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                        }
                        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


                    }


                }


            }
        }
    }
}

