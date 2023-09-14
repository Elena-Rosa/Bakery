using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
    static void Main()
    {
     Console.WriteLine("WELCOME TO OUR BAKERY!");
     Console.WriteLine("Bread $5! Buy two get one free!");
     Console.WriteLine("Pastries $2! Buy three get one free!");

     Console.WriteLine("Please enter the number of loaves of bread you'd like");
     int loafCount = int.Parse(Console.ReadLine());
     Console.WriteLine("Please enter the number of pastries you'd like");
     int pastryCount = int.Parse(Console.ReadLine());

     int total = 0;
     Bread bread = new Bread();
     total += bread.calculateTotal(loafCount);
     Pastry pastry = new Pastry();
     total += pastry.calculateTotal(pastryCount);

     Console.WriteLine($"Your total is: ${total}");
   }   
  }
}

