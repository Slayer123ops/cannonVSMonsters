using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBall : MonoBehaviour
{
    public GameObject CannonBallHolder;
    public Rigidbody RB;
    public int thrust = 10;
    public AudioSource CannonSound;
    public GameObject marker; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 0.1f, 2f);
        CannonBallHolder.GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
       
            
    }
    void shoot()
    {
       
        GameObject clone = Instantiate(CannonBallHolder);
        //float x = clone.transform.position.x;
        RB = clone.GetComponent<Rigidbody>();
        RB.AddForce(transform.up * thrust,ForceMode.Impulse);
        clone.transform.position = marker.transform.position;
        
    }
}
