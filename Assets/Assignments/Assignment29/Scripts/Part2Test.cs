using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{

    public class Part2Test : MonoBehaviour
    {

        void Start()
        {
            CustomObject c1 = new(1,"Object1");
            print($"object name :{c1.Name}   Object ID:{c1.ID}");
            CustomObject c2 = new(2, "Object1");
            print($"Before Modification: Is obj1 == obj2 : {c1 == c2}");
            c2.Name = c1.Name;
            c2.ID = c1.ID;
            print($"After Modification: Is obj1 == obj2 : {c1 == c2}");

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
