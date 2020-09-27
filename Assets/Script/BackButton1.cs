using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton1 : MonoBehaviour
{
    public GameObject Canvas8;

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
        GameObject obj = GameObject.Find("Canvas8");
        Destroy(obj);
    }

}
