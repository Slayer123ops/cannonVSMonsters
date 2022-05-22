using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    float xpos;
    float ypos;
    bool isNotFirstFrame = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float Xelta = Input.mousePosition.x - xpos;
        
        xpos = Input.mousePosition.x;
        //space
        float Yelta = Input.mousePosition.y - ypos;
       
        ypos = Input.mousePosition.y;
        if(!isNotFirstFrame)
        {
            transform.Rotate(transform.up, Xelta / 5);
            transform.Rotate(transform.right, -Yelta / 5);
        }
        isNotFirstFrame = false;
    }
}
