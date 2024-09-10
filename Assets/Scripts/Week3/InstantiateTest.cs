using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject spawnedPrefab;

    public Transform otherSpawnLocation;
    void Start()
    {
        GameObject yay = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);
        yay.GetComponent<Light>().color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawnedPrefab, otherSpawnLocation.position, otherSpawnLocation.rotation);
        }
 
    }
    public void CreateYay()
    {
        Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);
    }
        
}
