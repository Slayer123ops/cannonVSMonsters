using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagsController : MonoBehaviour
{
    [SerializeField]
    Text text;

    [SerializeField]
    Image image;

    [SerializeField]
    TextAsset jsonFile;

    TagInfoWrapper wrapper;
    
    public static TagsController mInstance;
    // Start is called before the first frame update
    void Start()
    {
        wrapper = JsonUtility.FromJson<TagInfoWrapper>(jsonFile.text);

        foreach(TagInfo info in wrapper.tagInfos)
        {
            Debug.Log("partname = "+info.partName);
            Debug.Log("Tag = "+info.tag);
        }

        mInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTag(GameObject highlightedObject)
    {
        Vector2 viewportPoint = Camera.main.WorldToViewportPoint(highlightedObject.transform.position);  //convert game object position to VievportPoint
        text.rectTransform.anchorMin = viewportPoint;  
        text.rectTransform .anchorMax = viewportPoint; 
        
        image.rectTransform.anchorMin = viewportPoint;  
        image.rectTransform .anchorMax = viewportPoint; 

        

        string tag = wrapper.GetTagForObject(highlightedObject.name);
        text.text = tag;
     }

     public void ShowTag(bool isVisible)
     {
         text.gameObject.SetActive(isVisible);
        image.gameObject.SetActive(isVisible);
        
     }
}
