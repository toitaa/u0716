using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hensu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Proc()
    {
        int a = 10;
        float fw = 3.14f;
        string str = "こんにちわ";
        bool bl = true;

        Debug.Log(a);
        Debug.Log(fw);
        Debug.Log(str);
        Debug.Log(bl);
    }

    public void Proc2()
    {
        Debug.Log(a);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
