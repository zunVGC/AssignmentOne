using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    

    // Update is called once per frame
    

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Cube")
        {
            Destruction();
        }
    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
