using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment24
{

    public class RacingGame : MonoBehaviour
    {
        public RaceState raceState;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            SimulateRace();
        }

        public void SimulateRace()
        {
            switch (raceState)
            {
                case RaceState.Start:
                    Debug.Log("Get Ready , the race will start soon");
                    break;
                case RaceState.Accelerate:
                    Debug.Log("Your speeding up so fast !");
                    break;
                case RaceState.Turn:
                    Debug.Log("You're are turning in a sharp angle.");
                    break;
                case RaceState.Crash:
                    Debug.Log("You lost Control and crashed, RACE OVER.");
                    break;
                case RaceState.Finish:
                    Debug.Log("You had passed all the competitor , AND YOU WIN");
                    break;
                default:
                    Debug.Log("HEY!! What Are you doning! , something is wrong ");
                    break;


            }
        }
    }
}
