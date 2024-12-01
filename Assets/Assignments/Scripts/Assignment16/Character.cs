using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment16
{

    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                if (health > 100) health = 100;
                else if (health < 0) health = 0;
            }
        }
        public Character(string name, int initialHealth, Position position)
        {
            this.name = name;
            this.Health = initialHealth;
            this.position = position;
        }
        public Character() : this("No Name", 100, new Position(0f, 0f, 0f)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log($"Character Name: {this.name} | Health : {Health}");
            position.PrintPosition();
        }

        public void Attack(int damage, Character target)
        {
            target.Health -= damage;
        }
        public void Attack(int damage, Character target, string attackType)
        {
            Attack(damage, target);
            if (attackType=="" || attackType == null) Debug.Log(attackType);
            else Debug.Log("You had Unbelivebly made an ULTIMATE NOTHING ATTACK");

        }

    }

    public class Soldier : Character
    {
        public Soldier(string name, int initialHealth, Position position) : base(name, initialHealth, position) {}
        public Soldier():base(){}
        public override void DisplayInfo()
        {
            Debug.Log("Soldier"); base.DisplayInfo();
        }

    }
    public class Officer : Character
    {
        public Officer(string name, int initialHealth, Position position) : base(name, initialHealth, position) { }
        public override void DisplayInfo()
        {
            Debug.Log("Officer"); base.DisplayInfo();
        }
    }
}
