using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
  
    public GameObject Cannon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject clone = GameObject.Instantiate(Cannon);
            clone.transform.position = new Vector3(Random.Range(0, 1), Random.Range(2, 1),0);

        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("DummyScene");   
    }
}
