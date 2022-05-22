using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayWork : MonoBehaviour
{
    GameObject[] bombs = new GameObject[1000];
    // Start is called before the first frame update
    void Start()
    {
        begin();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void begin()
    {
        for (int i = 1; i < 10;)
        {
            bombs[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            bombs[i].transform.position = new Vector3(Random.Range(1, 10), 0, Random.Range(1, 10));

        }
    }
}
