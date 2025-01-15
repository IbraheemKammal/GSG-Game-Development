using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class Interaction : MonoBehaviour
    {
        GameObject targetObject, jokerObject, lightObject;
        private void Start()
        {
            targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
            {
                print("Found object by name: TargetObject");
            }
            else print("No TargetObject found.");

            jokerObject = GameObject.FindGameObjectWithTag("Joker");
            if (jokerObject != null) print("Found object by Tag: Joker");
            else print("No Object with Joker Tag");
            lightObject = FindAnyObjectByType<Light>().gameObject;
            if (lightObject != null) print("Found object of Type Light: " + lightObject.name);
            else print("No Light Object is found ");
        }
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.D))
            {

                print("TargetObject Deactivated");
                targetObject?.SetActive(false);
            }
        }
    }

}
