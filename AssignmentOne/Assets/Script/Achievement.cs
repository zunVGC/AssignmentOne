using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        poiwe.Onpoie += poiwe_Onpoie;
        
    }

   // private void OnDestroy()
   // {
   //     poiwe.Onpoie -= poiwe_Onpoie;
   // }

    private void poiwe_Onpoie(string poi)
    {
        string achivKey = "achiv-" + poi;

        if (PlayerPrefs.GetInt(achivKey) == 1)
            return;

        PlayerPrefs.SetInt(achivKey, 1);
        Debug.Log("Unlock" + poi);
 
    }
}
