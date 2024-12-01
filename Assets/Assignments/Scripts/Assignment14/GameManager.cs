using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment14
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Player ibraheem = new Player("Ibraheem", 70);
            Debug.Log(ibraheem.Name +" " + ibraheem.Health);
            ibraheem.PrintStatus();
            ibraheem.Heal(30);
            ibraheem.PrintStatus();


            Enemy abuRijilMaslo5a = new Enemy("Abu Rigil Maslo5a", 1000);
            Debug.Log(abuRijilMaslo5a.Name +" " + abuRijilMaslo5a.Health);
            abuRijilMaslo5a.PrintStatus();
            abuRijilMaslo5a.Attack(ibraheem,240);
            
            ibraheem.PrintStatus();



        }


    }
}
