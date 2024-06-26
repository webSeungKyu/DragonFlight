using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false; // 생성 On/Off
    //public GameObject enemy; // prefab으로 만든 적을 가져온다
    public List<GameObject> enemyList;
    public bool nomalSpawn = false;
    public List<GameObject> nomalList;
    public bool bossSpawn = false;
    public GameObject boss;

    int score;
    public void SpawnEnemy()
    {
        /* 랜덤 생성
        float randomX = Random.Range(-2f, 2f); // 적이 나타날 x좌표를 랜덤으로 생성한다.

        if (enableSpawn)
        {
            //적을 생성한다. randomX랜덤한 값
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
        */
        if (enableSpawn)
        {
            score = GameManager.Instance.score;
            if (score > 1500)
            {
                enableSpawn = false;
                Debug.Log("1500점 넘었으므로 적 생성 중단");
                nomalSpawn = true;
            }

            for (int i = 0; i < enemyList.Count; i++)
            {
                Instantiate(enemyList[i], new Vector2(transform.position.x + i, transform.position.y), Quaternion.identity);
            }

        }
        if (score > 1500 && enableSpawn == false && nomalSpawn == true)
        {
            Debug.Log("중간 보스 생성");
            
        }


    }


    void Start()
    {
        enableSpawn = true;
        InvokeRepeating("SpawnEnemy", 3, 3f);
        StartCoroutine("NomalSpawnStart"); //15초 뒤에 중간 보스
        Invoke("BossSpawn", 30f); //30초 뒤에 보스
    }



    IEnumerator NomalSpawnStart()
    {
        yield return new WaitForSeconds(15f);
        int num = 0;
        while (num < 5)
        {
            int ran = Random.Range(0, nomalList.Count);
            Instantiate(nomalList[ran], nomalList[ran].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
            num++;
            if(num == 3)
            {
                GameManager.Instance.StartCoroutine("BossText");
            }
        }
        
        yield return new WaitForSeconds(2f);
        nomalSpawn = false;
        bossSpawn = true;


    }

    public void BossSpawn()
    {
        
        Instantiate(boss, boss.transform.position, Quaternion.identity);
        bossSpawn = false;
    }
}
