﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OopsConcepts274.Inheritance;

namespace OopsConcepts274
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcoke to oops concepts");
            Console.WriteLine("1.Class and Object \n2.Inheritance \n3.Polymorphism \n4.Abstraction\n5.Encapsulation\n6.Types of Variables\n7.Type of Method");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ClassandObject myObject = new ClassandObject();   
                    Console.WriteLine(myObject.name);               
                    Console.WriteLine(myObject.age);
                    break;
                case 2:
                    Maruthi maruthi = new Maruthi();
                    maruthi.Model = "alto";
                    maruthi.color = "white";
                    maruthi.price = 200000;
                    maruthi.milage = 22;
                    maruthi.PrintCarInformation();
                    maruthi.PrintMilage();
                    break;
                case 3:
                    
                    Polymorphism methodoverloading=new Polymorphism();
                    methodoverloading.Add(3,5);
                    methodoverloading.Add(5,6,7);
                    Methodoverriding methodoverriding = new Methodoverriding();
                    methodoverriding.Addition(3,4);
                    example example=new example();
                    example.Addition(2,4);
                    break;
                case 4:
                    Rose color = new Rose();
                    color.Flower();
                    color.Color();
                    break;
                case 5:
                    Person myObj = new Person();
                    myObj.Name = "Liam";
                    Console.WriteLine(myObj.Name);
                    break;
                case 6:
                    TypeofVariables obj = new TypeofVariables();
                    obj.mathsMarks = 20;
                    obj.engMarks = 30;
                    Console.WriteLine("Accessing instance variable engMarks = "+obj.engMarks);
                    Console.WriteLine("Accessing static variable salary = "+TypeofVariables.salary);
                    Console.WriteLine("accesing constant variable Age = "+TypeofVariables.Age);
                    TypeofVariables local=new TypeofVariables();
                    local.Add();
                    break;
                case 7:
                    TypeofMethods typeofMethods = new TypeofMethods(); //creation of object for nonstatic method
                    typeofMethods.Nonstaticmethod();

                    TypeofMethods.Staticmethod();        //object creation not requireed for static method
                    break;
            }                                                            
            Console.ReadLine();                           
        }
    }
}
