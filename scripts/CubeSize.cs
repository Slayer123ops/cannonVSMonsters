using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSize : MonoBehaviour
{
    private int Xsize = 1;
    private int Ysize = 1;
    private int Zsize = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = new Vector3(Xsize++, Ysize++,Zsize++);
           
        }
    }
}
