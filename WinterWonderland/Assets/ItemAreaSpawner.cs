using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAreaSpawner : MonoBehaviour
{

    public GameObject itemToSpread;

    public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        SpreadItem();

    }

    void SpreadItem()
    {

        Vector3 randPosition = new Vector3 (Random.Range(-itemXSpread, itemXSpread),Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread));
        GameObject clone = Instantiate(itemToSpread, randPosition, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
