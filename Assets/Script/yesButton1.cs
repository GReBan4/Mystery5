using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesButton1 : MonoBehaviour
{
    public GameObject Canvas2;
    public GameObject Canvas1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCLick()
    {
        Canvas2.SetActive(true);
        Canvas1.SetActive(false);
    }
}
