using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public int[] random1 = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        Function();
    }

    // Update is called once per frame
    void Update()
    {

        random1[1] = Random.Range(1, 3);

    }
    void Function()
    {
        for (int i = 0; i < 10;i++)
        {
            random1[i] = Random.Range(1, 5);
        }


    }
}
