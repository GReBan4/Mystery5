using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton4 : MonoBehaviour
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
        GameObject obj1 = GameObject.Find("Canvas12");
        GameObject obj2 = GameObject.Find("Canvas13");
        GameObject obj3 = GameObject.Find("Canvas14");
        Destroy(obj1);
        Destroy(obj2);
        Destroy(obj3);
    }
}
