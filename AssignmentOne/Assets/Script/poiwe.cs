using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class poiwe : MonoBehaviour
{
    public static event Action<string> Onpoie;

    [SerializeField]
    private string _poi;

    public string poiName { get { return _poi; } }
    private void OnTriggerEnter(Collider other)
    {
        if (Onpoie != null)
            Onpoie(this._poi);
    }
}
