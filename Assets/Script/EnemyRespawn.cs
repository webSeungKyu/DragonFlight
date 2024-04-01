using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        //InvokeRepeating ( 함수 이름, 초기지연 시간, 지연할 시간 )
        InvokeRepeating("Respawn", 1f, 3f);
    }

    void Respawn()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy, new Vector2(transform.position.x + i , transform.position.y), Quaternion.identity);
        }
        
    }

    void Update()
    {

    }
}
