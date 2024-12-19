using System.Collections;
using System.Collections.Generic;
using Assignment26;
using UnityEngine;

namespace Assignment26
{

    public class CreatureManager : MonoBehaviour
    {

        List<Creature> creatures = new List<Creature>();
        List<IRunnable> runnables = new List<IRunnable>();
        List<IJumpable> jumpables = new List<IJumpable>();
        List<ISwimmable> swimmables = new List<ISwimmable>();


        void Start()
        {
            Kangaro kangaro = new Kangaro();
            Duck duck = new Duck();

            creatures.Add(kangaro);
            creatures.Add(duck);

            runnables.Add(kangaro);
            jumpables.Add(kangaro);

            runnables.Add(duck);
            swimmables.Add(duck);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }

            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }

        }


    }
}
