using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creatture makes a sound ");
        }
    }

    public interface IRunnable
    {
        void Run();
    }
    public interface IJumpable
    {
        void Jump();
    }
    public interface ISwimmable
    {
        void Swim();
    }
}
