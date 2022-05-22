using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chomper : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomMovements", -10, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomMovements()
    {
        float x = Random.Range(-2, 2);
        float z = Random.Range(-2, 2);
        transform.position = new Vector3(x, 0, z);
        
    }
    void OnMouseDown()
    {
        
    }
}
