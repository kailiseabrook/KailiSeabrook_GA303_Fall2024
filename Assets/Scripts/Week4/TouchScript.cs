using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{
    public bool isColliding;

    void Start()
    {
        
    }

    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Yay");
            isColliding = true;
        }
        
    
    }
}
