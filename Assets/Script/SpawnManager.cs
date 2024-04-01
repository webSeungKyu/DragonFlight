using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false; // ���� On/Off
    public GameObject enemy; // prefab���� ���� ���� �����´�

    public void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f); // ���� ��Ÿ�� x��ǥ�� �������� �����Ѵ�.

        if (enableSpawn)
        {
            //���� �����Ѵ�. randomX������ ��
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
    }


    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }


    void Update()
    {
        
    }
}
