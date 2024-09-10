using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour 
{
    public string help = "I don't really know what I'm doing, ";
    public string please = "But I hope it works! ";
    public string yay = "I look forward to being in this class!";
       
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(help+please+yay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
