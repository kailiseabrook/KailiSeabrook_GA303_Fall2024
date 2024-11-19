using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TextDialogue : MonoBehaviour
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
    [TextArea]
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
        if (Input.GetMouseButtonDown(0))
        {
            speakerText.text= speaker[0];
            dialogueText.text = dialogueWords[0];
            portraitImage.sprite = portrait[0];
        }
    }
}
