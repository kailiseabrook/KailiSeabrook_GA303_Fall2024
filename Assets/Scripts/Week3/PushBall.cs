using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBall : MonoBehaviour
{
    public float ballSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        otherObject.gameObject.GetComponent<Rigidbody>().AddForce(otherObject.gameObject.transform.forward * ballSpeed);
    }
}
