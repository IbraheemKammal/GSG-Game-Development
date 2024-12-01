using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{

    void Start()
    {
        //NumberGenerator();
        //FunnySentenceGenerator();
    }
    void NumberGenerator()
    {

        while (true)
        {
            int randNumber = Random.Range(0, 21);
            if (randNumber == 15) break;
            if (randNumber == 5) continue;
            Debug.Log(randNumber);
        }
    }

    void FunnySentenceGenerator()
    {
        string[] words = new string[] { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";
        int counter = 0;
        while (counter < 7)
        {
            int randomIndex = Random.Range(0, words.Length);
            sentence += words[randomIndex] + " ";
            counter++;
        }
        Debug.Log(sentence);

    }

}
