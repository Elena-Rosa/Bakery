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
     Console.WriteLine("Pastries $3! Buy three get one free!");

     Console.WriteLine("\nPlease choose 1 for Bread or 2 for Pastry:");
     int choice = int.Parse(Console.ReadLine());
     Console.WriteLine("Please enter quantity:");
     int quantity = int.Parse(Console.ReadLine());
     
     int total = 0;
     if(choice == 1){
        Bread bread = new Bread();
        total = bread.calculateTotal(quantity);
        Console.WriteLine("\nYour total is $" + total);
     } 
     else if(choice == 2){
        Pastry pastry = new Pastry();
        total = pastry.calculateTotal(quantity);
        Console.WriteLine("\nYour total is $" + total);
     } 
     else {
        Console.WriteLine("Invalid choice");
     }
    }   
  }
}
