using UnityEngine;
using System.Collections.Generic;

public class Terrain : MonoBehaviour
{
    public List<GameObject> block = new List<GameObject>();

    GameObject currentBlock;

    GameObject[,] grid = new GameObject[10,10];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        for(int i = 0; i < 10; i++){
            for(int z = 0; z < 10; z++){
                grid[i,z] = Instantiate(block[0], new Vector3(i,0,z), Quaternion.identity);
                grid[i,z].transform.position = grid[i,z].transform.position + new Vector3(0,Mathf.PerlinNoise(i*0.5f,z*0.5f),0)*3;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
