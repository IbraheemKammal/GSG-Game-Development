using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment27
{

    public class Assignment27 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int a = 14, b = 20, c;
            int aByValue = CallByValue(a);
            Debug.Log($"current A value: {a}, suspected A value after modifing with a method that calles by value: {aByValue}");

            CallByReferance(ref b);
            Debug.Log($"current B value: {b}, suspected B value after modifing with a method that calles by referance using ref keyword : {b}");

            CallByReferance2(out c);
            Debug.Log($"current C value: {c}, suspected C value after modifing with a method that calles by referance using out keyword: {c}");




        }
        int CallByValue(int a)
        {
            a = 50;
            return a;
        }
        void CallByReferance(ref int a)
        {
            a = 133;
        }

        void CallByReferance2(out int b)
        {
            b = 25;
        }

    }
}
