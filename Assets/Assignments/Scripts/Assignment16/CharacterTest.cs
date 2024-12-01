using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Soldier aboAbdo = new Soldier();
            Officer mazen = new Officer("Mazen",100,new Position(23f,543f,65f));
            Character[] characters = new Character[2]{aboAbdo,mazen};

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            Debug.Log($"Abo Abdo Health before getting Attacked: {aboAbdo.Health}");
            mazen.Attack(32,aboAbdo);
            Debug.Log($"Abo Abdo Health After getting Attacked: {aboAbdo.Health}");



        }


    }
}
