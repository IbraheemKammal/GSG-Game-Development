using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{

    public class RecursionScript : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log($"Fibonaci for number 10 ,Recursive: {FibonacciRecursive(10)}, Iteration: {FibonacciIterative(10)} ");
            Debug.Log($"Fibonaci for number 30 ,Recursive: {FibonacciRecursive(30)}, Iteration: {FibonacciIterative(30)} ");
        }
        int FibonacciRecursive(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            return n + FibonacciRecursive(n - 1);

        }
        int FibonacciIterative(int n)
        {
            int result = 0;
            for (int i = n; i > 0; i--)
            {
                result += i;
            }
            return result;
        }

    }
}
