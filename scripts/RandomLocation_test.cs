using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocation_test : MonoBehaviour
{
    public GameObject Sphere;
    float S;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Dupe",1.0f,3.0f);
       
    }

    // Update is called once per frame
    void Update()
    {
        S = S++;


        Dupe();
           
    }
    void Dupe()
    {
        GameObject clone = GameObject.Instantiate(Sphere);
        clone.transform.position = new Vector3(Random.Range(1, 5), 1, Random.Range(1, 5));
        
    }
        
     
    
}
