using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_dystoryer : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "cube")
        {
            i++;
            ball.SetActive(false);
            Debug.Log(i);

        }
        if (collision.gameObject.name == "coin")
        {
            score++;
            Destroy(collision.gameObject);
            Debug.Log("Score " + score);
        }

    }
    int score;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "cube")
        {
            Invoke("open", 2);
        }
       
    }
    int i;
    private void OnCollisionStay(Collision collision)
    {

     

    }

    void open()
    {
        ball.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
