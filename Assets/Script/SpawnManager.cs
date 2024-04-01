using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false; // 생성 On/Off
    public GameObject enemy; // prefab으로 만든 적을 가져온다

    public void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f); // 적이 나타날 x좌표를 랜덤으로 생성한다.

        if (enableSpawn)
        {
            //적을 생성한다. randomX랜덤한 값
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
