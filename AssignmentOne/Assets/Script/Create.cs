using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public Transform o1;
    public Transform o2;

    void CreateBall()
    {
        Transform o3 = GameObject.Instantiate(o2, o1.position, o1.rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CreateBall();
        }
    }

}
