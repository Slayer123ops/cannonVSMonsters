using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerMovement : MonoBehaviour
{
    public float speed = 10;
    public float ReverseSpeed = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timed", 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void Timed()
    {
        transform.position = new Vector3(Random.Range(speed, ReverseSpeed), transform.position.y, transform.position.z);

    }
}
