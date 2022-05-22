using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject GunBarrel;
   
    public GameObject Camera;
    public Rigidbody move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //left is 0
    //right is 2
    //middle is 1
    void Update()
    {
       
        
        if(Input.GetMouseButtonDown(0))
        {
            GameObject clone = Instantiate(Bullet);
            clone.transform.position = GunBarrel.transform.position;
            Rigidbody Force =  clone.GetComponent<Rigidbody>();
            Force.AddForce(transform.forward*50,ForceMode.Impulse);
            
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
           
        }
    }
}
