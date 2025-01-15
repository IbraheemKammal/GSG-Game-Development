using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment29
{

    public class BasicsScript : MonoBehaviour
    {
        private void Start()
        {
            var integer = 5;

            var isOdd = integer % 2 == 1 ? true : false;
            var oddSentance = $"the number {integer} is odd";
            Debug.Log(oddSentance);
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now.TimeOfDay);
            Debug.Log(System.DateTime.Now.Day);


        }
    }
}
