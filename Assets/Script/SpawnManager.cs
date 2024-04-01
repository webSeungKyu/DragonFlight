using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false; // ���� On/Off
    //public GameObject enemy; // prefab���� ���� ���� �����´�
    public List<GameObject> enemyList;

    public void SpawnEnemy()
    {
        /* ���� ����
        float randomX = Random.Range(-2f, 2f); // ���� ��Ÿ�� x��ǥ�� �������� �����Ѵ�.

        if (enableSpawn)
        {
            //���� �����Ѵ�. randomX������ ��
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
        */
        if (enableSpawn)
        {
            for(int i = 0; i < enemyList.Count; i++)
            {
                Instantiate(enemyList[i], new Vector2(transform.position.x + i, transform.position.y), Quaternion.identity);
            }
        }


    }


    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 3f);
    }


    void Update()
    {
        
    }
}
