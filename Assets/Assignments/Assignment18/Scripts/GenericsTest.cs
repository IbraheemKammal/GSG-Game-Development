using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> healthPotion = new GameContainer<string>();
            healthPotion.SetItem("Health Potion");

            Debug.Log($"Stored Item : {healthPotion.GetItem()}");

            GameUtils.DescribeItem(healthPotion.GetItem());
        }


    }

}
