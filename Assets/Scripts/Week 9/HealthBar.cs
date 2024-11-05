using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private PlayerRPG player;
    public TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerRPG>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshPro.text = player.health.ToString();
    }
}
