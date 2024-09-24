using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnLocation;

    public float ballSpeed = 500f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(ball, spawnLocation.position, spawnLocation.rotation); 

            go.GetComponent<Rigidbody>().AddForce(go.transform.up * ballSpeed);
        }
    }
}
