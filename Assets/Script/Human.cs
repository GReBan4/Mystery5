using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public GameObject Canvas1;
    public GameObject Canvas4;
    public GameObject Canvas5;
    public GameObject Canvas8;
    public GameObject Canvas9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(-0.03f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0.03f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(0.0f, 0.0f, 0.03f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(0.0f, 0.0f, -0.03f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("kabin"))
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Canvas1.SetActive(true);
            }
        }
        if (other.CompareTag("door1"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Canvas4.SetActive(true);
            }
        }
        if (other.CompareTag("book1"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Canvas5.SetActive(true);
            }
        }
        if (other.CompareTag("door2"))
        {
            bool hasItem = ItemBox.instance.CanUseItem(Item.Type.BlackBall);
            if(hasItem == true)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Canvas9.SetActive(true);
                    ItemBox.instance.UseItem(Item.Type.BlackBall);
                }
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Canvas8.SetActive(true);
            }
        }

    }
}
