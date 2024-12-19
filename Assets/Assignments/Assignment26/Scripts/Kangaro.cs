using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{

    public class Kangaro : Creature, IRunnable, IJumpable
    {
        public override void Speak()
        {
            Debug.Log("Kangaro says : Hop!");
        }
        public void Jump()
        {
            Debug.Log("Kangaro Jumps");
        }

        public void Run()
        {
            Debug.Log("Kangaro Runs");
        }
    }
}

