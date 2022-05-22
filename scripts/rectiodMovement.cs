using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectiodMovement : MonoBehaviour
{
    public float number;
    public float number1;
    public bool numberSelected;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("repeating", 0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void repeating()
    {
        int numberGod = Random.Range(0, 3);
        if (numberGod == 2)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
        
    }
}
