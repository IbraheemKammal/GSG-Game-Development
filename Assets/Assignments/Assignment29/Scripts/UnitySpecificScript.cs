using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{

    public class UnitySpecificScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            print("Game Started");
        }
        private void OnEnable()
        {
            print("Gameobject Enabled");
        }
        private void OnDisable()
        {
            print("Gameobject Disabled");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
