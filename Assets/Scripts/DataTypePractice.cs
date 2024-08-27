using System.Collections;
using System.Collections.Generic;
using UnityEngine; // Allows manipulation of Unity functions

public class DataTypePractice : MonoBehaviour // Class Declaration
{
    public int num1;
    public Light theThingThatShinesInTheSky;
    public Transform moveTool;
    // Start is called before the first frame update
    void Start() 
    {
        Debug.Log("The starting number for num1 is: " + num1);
        num1 = num1 + 1;
        Debug.Log("The end number for num1 after adding 1 is: " + num1);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
