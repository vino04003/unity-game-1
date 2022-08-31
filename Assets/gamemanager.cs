using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coin == null) 
        {
            coin = Instantiate(coinPrefab);
            Vector3 position = Vector3.one;
            position.x = Random.Range(-20f, 20f);
            position.z = Random.Range(-20f, 20f);
            coin.transform.position = position;
        }
    }
}
