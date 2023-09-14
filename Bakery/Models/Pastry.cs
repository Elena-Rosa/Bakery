using System.Collections.Generic;
using System;

namespace Bakery.Models;

  public class Pastry
  {
    public int Price { get; set; }
     public Pastry()
     {
      Price = 2;
     }
      public int calculateTotal(int Quantity){
        if (Quantity <= 0){
            return 0;
        }       
        int Total = Price * Quantity;
        int Free = Quantity / 4;
        Total -= Free * Price;
        return Total;
    }
  }
  
  


 