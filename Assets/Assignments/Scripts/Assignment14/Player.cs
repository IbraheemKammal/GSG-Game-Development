using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment14
{
   public class Player : Character
   {
      public Player(string name , int initialHealth) :base(name,initialHealth)
      {
         
      }
      public void Heal(int amount)
      {
         this.Health += amount;

      }
   }
}

