using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject Canvas3;
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
        GameObject obj = GameObject.Find("Canvas3");
        GameObject obj1 = GameObject.Find("BlackBall");
        GameObject obj2 = GameObject.Find("Canvas8");
        Destroy(obj);
        Destroy(obj1);
        Destroy(obj2);
    }
}
