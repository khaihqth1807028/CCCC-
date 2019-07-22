using System;
using baitapCCCCCC.entity;

namespace baitapCCCCCC
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine("Nhập tên ");
            people.Name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi ");
            people.Age = Console.Read();
            Console.WriteLine("Giới tinh ");

            Console.WriteLine("Person details: Name ="+ people.Name +" Age = "+people.Age +", Gender="+people.Gender);
            Console.WriteLine("Person details (apter incrementing age) : Name ="+people.Name +", Gender ="+people.Gender+", Age = "+ people.Age);



        }

        }
    }
