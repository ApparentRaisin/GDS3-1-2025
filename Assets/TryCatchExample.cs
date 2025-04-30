using UnityEngine;
using System;

public class TryCatchExample : MonoBehaviour
{
    public GameObject toSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            Instantiate(toSpawn);
        }
        catch(Exception e)
        {
            Debug.Log("please assign a gameobject");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
