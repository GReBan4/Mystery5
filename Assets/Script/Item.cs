using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject door2;

    public enum Type
    {
        BlackBall,
    }

    public Type type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDestroy()
    {
        ItemBox.instance.SetItem(type);
        door2.GetComponent<door_src>().Open();
    }
}
