using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    // Start is called before the first frame update

    Material mat;
    [SerializeField]
    float _emissionValue = 0.3f;
    
    void Start()
    {
      mat = GetComponent<MeshRenderer>().material; 
      mat.EnableKeyword ("_EMISSION");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     /// <summary>
    /// Called when the mouse enters the GUIElement or Collider.
    /// </summary>
    void OnMouseEnter()
    {
        mat.SetColor("_EmissionColor", new Color(_emissionValue, _emissionValue, _emissionValue));
        Debug.Log("In mouse enter");
        TagsController.mInstance.SetTag(gameObject);
        TagsController.mInstance.ShowTag(true);
    }

     /// <summary>
    /// Called when the mouse is not any longer over the GUIElement or Collider.
    /// </summary>
    void OnMouseExit()
    {
        mat.SetColor("_EmissionColor", new Color(0, 0, 0));
        Debug.Log("In mouse exit");
         TagsController.mInstance.ShowTag(false);
    }
}
