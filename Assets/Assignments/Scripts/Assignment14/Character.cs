using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{


    public class Character
    {

        private string name;
        private int health;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }

            set
            {
                health += value;
                if (health >= 100) health = 100;
                if (health < 0) health = 0;
            }
        }
        public Character(string name, int initialHelath)
        {
            this.Name = name;
            this.Health = initialHelath;
        }
        public void PrintStatus()
        {
            Debug.Log($"Character: {Name} | Health: {Health}");
            
        }

    }
}