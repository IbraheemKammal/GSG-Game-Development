using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class Part3Test : MonoBehaviour
    {
        private void Start()
        {
            print(Utilities.Add(1, 2, 3, 4, 5));
            print("Reapeated 3 Times".RepeatString(3));
        }
    }
}

