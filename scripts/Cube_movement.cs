 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_movement : MonoBehaviour
{
    public float Movement = 5;
    public float ReverseMovement = -5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Noob", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Noob()
    {
        transform.position = new Vector3(Random.Range(ReverseMovement, Movement), transform.position.y, transform.position.z);

    }
}
