using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    //자료구조
    public List<GameObject> list = new List<GameObject>();

    public void SpawnEnemy()
    {
        //0 ~ 1 중 하나
        int ran = Random.Range(0, list.Count);

        Instantiate(list[ran], list[ran].transform.position, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
