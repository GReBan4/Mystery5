using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesButton2 : MonoBehaviour
{
    public GameObject Canvas6;

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
        GameObject obj1 = GameObject.Find("Canvas5");
        Destroy(obj1);

        Canvas6.SetActive(true);
    }
}
