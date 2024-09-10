using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAround : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cubeTeleportTransform;
    public Transform cameraTransform;
    public float speed = 5f;
    void Start()
    {
        //this.transform.position = new Vector3(-5.46f, 4.38f);
        this.transform.position = cubeTeleportTransform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(Vector3.right * Time.deltaTime); //make 3d object move right

        //this.transform.position += Vector3.right * Time.deltaTime; //moves one unit to the right per secod as well
        if (Input.GetKeyDown(KeyCode.H))
        {
            //this.transform.position = Camera.main.
            this.transform.position = cameraTransform.position;
            this.transform.position += this.transform.forward * speed; //local fwd depending on how obj is rotated
            //this.transform.position += Vector3.forward; // universal fwd (z+1)
        }
    }
}
