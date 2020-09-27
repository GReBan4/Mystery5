using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton1 : MonoBehaviour
{
    public GameObject Canvas1;

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
        Canvas1.SetActive(false);
    }
}
