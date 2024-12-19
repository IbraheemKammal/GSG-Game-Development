using System.Collections;
using System.Collections.Generic;
using Assignment26;
using UnityEngine;

namespace Assignment26
{

    public class Duck : Creature, IRunnable, ISwimmable
    {
        public override void Speak()
        {
            Debug.Log("Duck says : Quack!");
        }
        public void Run()
        {
            Debug.Log("Duck Runs");
        }

        public void Swim()
        {
            Debug.Log("Duck Swims");
        }


    }
}
