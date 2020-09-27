using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton1 : MonoBehaviour
{
    public GameObject canvas6;

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
        GameObject obj = GameObject.Find("Canvas6");
        Destroy(obj);
    }
}
