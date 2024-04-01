using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //자료구조
    public List<GameObject> list = new List<GameObject>();
    void Start()
    {
        for(int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].name);
        }
        
    }


    void Update()
    {
        
    }
}
