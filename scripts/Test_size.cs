using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_size : MonoBehaviour
{
    float S;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Sizer",0.1f,3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.localScale = new Vector3(S, S, S);
        Sizer();
    }
    void Sizer()
    {
        S = S + 0.5f;
        transform.localScale = new Vector3(S, S, S);
    }
}
