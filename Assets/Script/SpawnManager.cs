using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false; // ���� On/Off
    //public GameObject enemy; // prefab���� ���� ���� �����´�
    public List<GameObject> enemyList;
    public bool nomalSpawn = false;
    public List<GameObject> nomalList;

    int score;
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
            score = GameManager.Instance.score;
            if(score > 1500)
            {
                enableSpawn = false;
                Debug.Log("1500�� �Ѿ����Ƿ� �� ���� �ߴ�");
                nomalSpawn = true;
            }

            for(int i = 0; i < enemyList.Count; i++)
            {
                Instantiate(enemyList[i], new Vector2(transform.position.x + i, transform.position.y), Quaternion.identity);
            }

        }
        if (score > 1500 && enableSpawn == false && nomalSpawn == true)
        {
            Debug.Log("�߰� ���� ����");
            StartCoroutine("NomalSpawnStart");
        }


    }


    void Start()
    {
        enableSpawn = true;
        InvokeRepeating("SpawnEnemy", 3, 3f);
    }


    void Update()
    {

    }

    IEnumerator NomalSpawnStart()
    {
        int num = 0;
        while (num < 3)
        {
            int ran = Random.Range(0, nomalList.Count);
            Instantiate(nomalList[ran], nomalList[ran].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
            num++;
        }
        yield return new WaitForSeconds(3f);
        nomalSpawn = false;

    }
}
