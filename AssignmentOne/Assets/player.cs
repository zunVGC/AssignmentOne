using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private static player _instance;
    public static player Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("player");
                go.AddComponent<player>();
            }
            return _instance;
        }
    }

    public delegate void Change(Color color);
    public static event Change hit;

    private void Awake()
    {
        _instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (hit != null)
            {
                hit(Color.red);
            }
        }
    }
}
