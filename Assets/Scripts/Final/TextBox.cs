using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    [SerializeField]
    private TMP_Text speakerText;
    
    [SerializeField]
    private TMP_Text dialogueText;

    [SerializeField]
    private Image portraitImage;

    [SerializeField]
    private string[] speaker;

    [SerializeField]
    private string[] dialogueWords;

    [SerializeField]
    private Sprite[] portrait;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}