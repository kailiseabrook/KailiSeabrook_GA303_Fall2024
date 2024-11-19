using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Name : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
        void startDialogue()
        {
            index = 0;
        }
        void NextLine()
        {
            if (index < lines.Length - 1)
            {
                index++;
                textComponent.text = string.Empty;
             
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }


