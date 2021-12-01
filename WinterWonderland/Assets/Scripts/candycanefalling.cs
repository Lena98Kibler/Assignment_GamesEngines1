using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candycanefalling : MonoBehaviour
{
    
    public GameObject candycane_prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CandycaneDrop());
    }

    IEnumerator CandycaneDrop()
    {

        while(true)
        {
            float randomTime = Random.Range(2f,5f);
            float randomPosition = Random.Range(-10f,10f);

            yield return new WaitForSeconds(randomTime);

            Instantiate(candycane_prefab, new Vector3(randomPosition,transform.position.y,transform.position.z),Quaternion.identity);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("brick");
        Debug.Log(bricks.Length);
        
    }

}
