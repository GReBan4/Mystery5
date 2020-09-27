using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yesButton : MonoBehaviour
{
    public GameObject Canvas2;
    public GameObject Canvas3;

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
        //セリフ、花瓶消去
        GameObject obj1 = GameObject.Find("vase");
        GameObject obj2 = GameObject.Find("Canvas1");
        Destroy(obj1);
        Destroy(obj2);

        //次のセリフ表示
        Canvas2.SetActive(false);
        Canvas3.SetActive(true);
    }
}
