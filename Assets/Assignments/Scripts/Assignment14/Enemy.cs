using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class Enemy : Character
    {
        public Enemy(string name , int initialHealth):base(name,initialHealth)
        {

        }
        public void Attack(Character damagedCharacter, int damage)
        {
            damagedCharacter.Health -= damage;
        }


    }
}

