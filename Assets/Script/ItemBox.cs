using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public GameObject Box0;

    public static ItemBox instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    public void SetItem(Item.Type type)
    {
        if(type == Item.Type.BlackBall)
        {
            Box0.SetActive(true);
        }
    }

    public bool CanUseItem(Item.Type type)
    {
        if (type == Item.Type.BlackBall)
        {
            return Box0.activeSelf;
        }
        return false;
    }

    public void UseItem(Item.Type type)
    {
        if (type == Item.Type.BlackBall)
        {
            Box0.SetActive(false);
        }
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
