using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sousaButton : MonoBehaviour
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
        GameObject obj = GameObject.Find("Canvas10");
        Destroy(obj);
    }
}
