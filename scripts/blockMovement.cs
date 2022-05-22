using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMovement : MonoBehaviour
{
    public int Xpos = 2;
    public float speed = 5f; 
    
    // Start is called before the first frame update
    void Start()
    {
        
      //InvokeRepeating(blockMovement, 0 , Random.range(0,1))  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (Xpos * speed, 0, 0);
    }
}
