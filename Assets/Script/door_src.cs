using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_src : MonoBehaviour
{
    public GameObject door2;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = door2.GetComponent<Rigidbody>();
    }

    public void Open()
    {
        rb.isKinematic = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
