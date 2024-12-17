using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Inventory
    {
        private List<string> storedItems = new List<string>();
        public void AddItem(string item)
        {
            storedItems.Add(item);

        }
        public void ShowItems()
        {
            if (storedItems.Count > 0)
                foreach (string item in storedItems) Debug.Log(item);
            else Debug.Log("The Owner of this inventory is very poor , he has nothing .");
        }

        public static Inventory operator +(Inventory inventory1, Inventory inventory2)
        {
            foreach (string item in inventory2.storedItems)
            {
                inventory1.storedItems.Add(item);
            }
            return inventory1;
        }

    }

}