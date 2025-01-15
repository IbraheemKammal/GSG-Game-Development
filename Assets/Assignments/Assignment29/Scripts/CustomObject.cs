using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment29{

    public class CustomObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        //public override bool Equals(object obj)
        //{
        //    CustomObject other = obj as CustomObject;
        //    bool isEqualed = this.Name.Equals(other.Name) && this.ID.Equals(other.ID);
        //    return isEqualed;
        //}
        public static bool operator ==(CustomObject o1, CustomObject o2)
        {
            bool isEqualed = false;
            if (!o1.Equals(null) && !o2.Equals(null))
            {
                isEqualed = o1.Name.Equals(o2.Name) && o1.ID.Equals(o2.ID); 
            }
            
                return isEqualed;

        }
        public static bool operator !=(CustomObject o1, CustomObject o2)
        {
            bool isEqualed = false;
            if (!o1.Equals(null)  && !o2 .Equals(null))
            {
                isEqualed = !o1.Name.Equals(o2.Name) || !o1.ID.Equals(o2.ID);
            }

            return isEqualed;
        }
    }
}
