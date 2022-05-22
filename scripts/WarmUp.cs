using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmUp : MonoBehaviour
{
    //public int number;
  


    // Start is called before the first frame update
    void Start()
    {

        float numGod =  addnumber(10,30);
        Debug.Log(numGod);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float addnumber(float number, float numb1)
    {
        return number + numb1;
        
    }
}
