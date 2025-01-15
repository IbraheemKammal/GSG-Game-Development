using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Assignment29
{

    public class Score : MonoBehaviour
    {
        int score = 100, divisor = 0;
        private void Start()
        {
            try
            {
                Debug.Log("Attempting to calculate score multiplayer....");
                int totalScore = score / divisor;
            }
            catch (DivideByZeroException e)
            {
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score Caculation Complete. cleaning up resources .");
            }
        }
    }
}

