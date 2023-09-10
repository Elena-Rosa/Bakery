using System.Collections.Generic;
using System;

namespace Bakery.Models;

  public class Bread
  {
    public int Price { get; set; }
  
    public Bread ()
    {
      Price = 5;
    }
     public int calculateTotal(int Quantity){
        if (Quantity <= 0){
            return 0;
        }       
        int Total = Price * Quantity;
        int Free = Quantity / 3;
        Total -= Free * Price;
        return Total;
    } 
  }

