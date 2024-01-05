using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoin : MonoBehaviour
{
    public GameObject coint;
    GameObject[] groundeds;
    int maxCoin = 10;
    // Start is called before the first frame update
    void Start()
    {
        groundeds = GameObject.FindGameObjectsWithTag("Grounded");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] lengthCoin = GameObject.FindGameObjectsWithTag("Coin");
        if (lengthCoin.Length < 10)
        {
            int index;
            if (groundeds.Length < maxCoin)
            {
                index = Random.Range(0, groundeds.Length);
            } else
            {
                index = Random.Range(0, maxCoin);
            }
            GameObject go = groundeds[index];
            GameObject newCoin = Instantiate(coint, GetRandomSpawnPosition(go), Quaternion.identity);
            newCoin.transform.SetParent(transform, true);
        }
    }
    
    Vector3 GetRandomSpawnPosition(GameObject ground)
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);
        Vector3 spawnPosition = new Vector3(x, 0.5f, z);
        return ground.transform.position + spawnPosition;
    }
}
