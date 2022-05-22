using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takingNumber : MonoBehaviour
{
    public GameObject[] something = new GameObject[10];
    public int rendom;
   // public float ChangeNumb;
    
    // Start is called before the first frame update
    void Start()
    {
       
        //float numberAll = takeNumber(ChangeNumb);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 9;i++)
        {
            something[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }
    }
    //float takeNumber(float numbertake)
    //{
//return numbertake * numbertake;
    //}
    //float num(float numberItake)
   // {
       // for (int i = 1; i <  numberItake; i++;)
       // {
            
        //}

    //}
    //void repeatDigit(int numb)
    //{
        
        //for (int i = 0; i < numb; i++)
        //{
       //  GameObject SphereCreate = GameObject.CreatePrimitive(PrimitiveType.Sphere);
       // }

   // }
}
