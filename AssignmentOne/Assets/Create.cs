using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public Transform o1;
    public Rigidbody o2;

    void CreateBall()
    {
        Rigidbody o3;
        o3 = Instantiate(o2, o1.position, o1.rotation)as Rigidbody;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CreateBall();
        }
    }

}
