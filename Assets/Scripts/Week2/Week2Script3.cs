using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Script3 : MonoBehaviour
{
    public Week2Script4 otherScript;

    void Awake()
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
