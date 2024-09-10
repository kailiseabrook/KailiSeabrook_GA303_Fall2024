using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Script1 : MonoBehaviour
{
    public GameObject Dan;
    public Animator Animator;
    // Update is called once per frame

    public void Joker()
    {
        Animator.SetTrigger("Joker");
    }
    
}
