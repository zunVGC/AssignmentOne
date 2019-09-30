using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    // Creating Factory Class
    public class Object
    {
        public virtual void Create()
        {
            Debug.Log("Object created");
        }
    }
    // Cylinder
    public class Cylinder : Object
    {
        public override void Create()
        {
            // Show main class created
            base.Create();
            // Which child class is created
            Debug.Log("Cylinder created");
        }
    }
    // Capsule
    public class Capsule : Object
    {
        public override void Create()
        {
            // Show main class created
            base.Create();
            // Which child class is created
            Debug.Log("Capsule created");
        }
    }

    public class Factory
    {
        public Object CraetedOBJ(string objName)
        {
            switch (objName)
            {
                case "Capsule":
                    return new Capsule();
                case "Cylinder":
                    return new Cylinder();
                default:
                    return null;
            }
        }
    }

    public class FactoryPattern : MonoBehaviour
    {
        public Transform Spawner;
        public Rigidbody Capsule;
        public Rigidbody Cylinder;

        Factory factory = new Factory();
        Object obj1;
        Object obj2;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                obj1 = factory.CraetedOBJ("Capsule");
                obj1.Create();
                Instantiate(Capsule, Spawner.position, Spawner.rotation);
            }

            if(Input.GetKeyDown(KeyCode.E))
            {
                obj2 = factory.CraetedOBJ("Cylinder");
                obj2.Create();
                Instantiate(Cylinder, Spawner.position, Spawner.rotation);
            }
        }
    }
}