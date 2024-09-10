using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Script3 : MonoBehaviour
{
    public Week2Script4 otherScript;

    // Start is called before the first frame update
    void Start()
    {
        Ants();
    }
    private void Update()
    {

    }

    void Ants()
    {
        otherScript.theAnts =  "THE ANTS\n" + "Can what they want and what I want\n" + "Be one in the same?";
    }

    private void OnEnable()
    {

    }



}
