using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory inv1 = new Inventory();
            inv1.AddItem("Healing Potion");
            inv1.AddItem("Strength Potion");

            Inventory inv2 = new Inventory();
            inv2.AddItem("Elixir");
            inv2.AddItem("Dark Elixir");

            Inventory inv3 = inv1 + inv2;
            inv3.ShowItems();


        }
    }

}
