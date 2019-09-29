using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // define spawner object o1 and object o2 
    public Transform o1;
    public Rigidbody o2;

    void CreateBall()
    {
        // Create ball on spawner o1's position
        Rigidbody o3 = GameObject.Instantiate(o2, o1.position, o1.rotation);
    }

    // press space to call function to create ball
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CreateBall();
        }
    }

}
