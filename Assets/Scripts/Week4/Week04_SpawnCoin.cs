using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week04_SpawnCoin : MonoBehaviour
{
    public GameObject Coin;
    public List<GameObject> CoinList = new List<GameObject>();



    // Start is called before the first frame update

    void Start()
    {
        


        for (int i = 0; i < 10; i++)
        {
            var position = new Vector3(Random.Range(-5.0f, 5.0f), 1f, Random.Range(-5.0f, 5.0f));

           CoinList.Add (Instantiate(Coin, position, Quaternion.identity));

        }
       

        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int CoinCounter = 0;
            foreach (GameObject Coin in CoinList)
            {
                if (Coin.GetComponent<TouchScript>().isColliding == true)
                {
                    Debug.Log(Coin.name + "has been touched!");
                    CoinCounter++;
                }
            }
            if (CoinCounter == CoinList.Count)
            {
                Debug.Log("All coins have been touched");
            }
            else
            {
                Debug.Log(CoinCounter + "coins have been touched");
            }
        }


    }
}