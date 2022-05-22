using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_stairs : MonoBehaviour
{
    public int sizeChanging;
    public GameObject cube;
    public float forceMag = 10;

    // Start is called before the first frame update
    void Start()
    {
        size();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //size which is to change y size
    void size()
    {

        for (int i = 0; i < 10; i++)
        {
            GameObject clone = Instantiate(cube, new Vector3(i,(float) i/2, 0), Quaternion.identity);
            clone.transform.localScale = new Vector3(1, sizeChanging++, 1);

        }

    }

}