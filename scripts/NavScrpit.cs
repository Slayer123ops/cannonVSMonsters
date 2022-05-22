using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//dog

public class NavScrpit : MonoBehaviour
{
    public NavMeshAgent agentBoi;
    // Start is called before the first frame update
    void Start()
    {
        agentBoi = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray bulletRange = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(bulletRange, out hitInfo))
        {
            agentBoi.SetDestination(hitInfo.point); 
           
        }
    }
}
//meow