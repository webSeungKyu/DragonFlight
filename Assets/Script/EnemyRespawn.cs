using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        //InvokeRepeating ( �Լ� �̸�, �ʱ����� �ð�, ������ �ð� )
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
