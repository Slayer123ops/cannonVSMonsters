using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_collection : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            {
                Debug.Log("Touched");
                Destroy(collision.gameObject);
                score++;
            }
        }
    }
}
