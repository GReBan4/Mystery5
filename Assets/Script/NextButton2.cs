using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        GameObject obj = GameObject.Find("Canvas9");
        Destroy(obj);
    }
    
}
