using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimersYay : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerDuration = 2f;

    public bool isCountingUp = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(timerCountingUp < timerDuration)
        {
            timerCountingUp += Time.deltaTime;
        }*/
        timerCountingUp += Time.deltaTime;
        if (isCountingUp == true)
        {
            timerCountingUp += Time.deltaTime;
        }
        else if (isCountingUp == false)
        {
            timerCountingUp -= Time.deltaTime;
        }

        if(timerCountingUp >= timerDuration)
        {
            this.transform.position += Vector3.right;

            Debug.Log("Timer has reached " + timerDuration + " seconds!");
            timerCountingUp = timerDuration;
        }
        
        if(timerCountingUp <= 0f)
        {
            this.transform.position -= Vector3.right;

            Debug.Log("Timer has counted down to 0!");
            timerCountingUp = 0f;

            isCountingUp = true;
        }

        //Debug.Log(timerCountingUp);
    }
}
