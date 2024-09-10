using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Script2 : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public GameObject screen;

    private void Awake()
    {
        screen.SetActive(false);
    }
    public void Yippee()
    {
        screen.SetActive(true);
        StartCoroutine(um());
    }
    private IEnumerator um()
    {
        yield return new WaitForSeconds(3);
        screen.SetActive(false);

    }
}
