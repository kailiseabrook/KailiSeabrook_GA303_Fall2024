using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public long num1 = 214920218614 ;
    public int num2 = -1422925;
    public float num3 = 3.428f;
    public double num4 = 8.020134742096;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The starting number for num1 is: " + num1);
        num1 = num1 + 50482;
        Debug.Log("The ending number for num1 after adding 50,482 is: " + num1);

        Debug.Log("The starting number for num2 is: " + num2);
        num2 = num2 - 40529;
        Debug.Log("The ending number for num2 after subtracting 40,529 is: " + num2);

        Debug.Log("The starting number for num3 is: " + num3);
        num3 = num3 * 2.312f;
        Debug.Log("The ending number for num3 after multiplying 2.31 is: " + num3);

        Debug.Log("The starting number for num4 is: " + num4);
        num4 = num4 / 1.3946;
        Debug.Log("The ending number for num4 after dividing 1.3946 is: " + num4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
