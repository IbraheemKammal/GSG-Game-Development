using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment29
{
    public class TypeManegment : MonoBehaviour
    {
        private void Start()
        {
            Animal catAnimal = new Animal();
            Cat cat = new Cat();
            catAnimal = cat;
            catAnimal.MakeSound();
            catAnimal.Move();
            cat = catAnimal as Cat;
            cat?.MakeSound();
            cat?.Move();
            List<ICanFight> fighters = new List<ICanFight>();
            Warrior humanWarrior = new Warrior();
            fighters.Add(cat);
            fighters.Add(humanWarrior);
            foreach (var fighter in fighters)
            {
                if (fighter is Cat) Debug.Log("The Object is Cat");
                else if (fighter is Warrior) Debug.Log("The Object is Warrior");
                else Debug.Log("Unknown Object Type");
                fighter.Attack();
            }

        }
    }
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal Make Sound");
        }
        public void Move()
        {
            Debug.Log("Animal Moves");
        }
    }
    public class Cat : Animal, ICanFight
    {
        public void Attack()
        {
            Debug.Log("Cat Attack With Claws!");
        }

        public override void MakeSound()
        {
            Debug.Log("Meow");
        }
        public new void Move()
        {
            Debug.Log("Cat Move Stealthly and Very Fast");
        }
    }
    public interface ICanFight
    {
        void Attack();
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Worrir Attacks With a Sword");
        }
    }
}

