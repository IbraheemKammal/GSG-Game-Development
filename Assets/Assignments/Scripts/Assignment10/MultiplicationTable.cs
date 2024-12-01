using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 5 ;
        
        for (int i = 1; i <=10; i++)
        {
            Debug.Log($"5 x {i} = {i*number}");
        }
    }

    public int Multiply (int num1 , int num2 ) 
	{
	return num1 * num2;
	}

}
