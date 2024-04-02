using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BossManager : MonoBehaviour
{
    public static BossManager Instance;
    public GameObject bullet; // 미사일 프리팹 가져올 변수
    public bool rotate = false;
    void Start()
    {

        //InvokeRepeating ( 함수 이름, 초기지연 시간, 지연할 시간 )
        InvokeRepeating("Shoot", 3f, 1f);
        StartCoroutine("rotateOn");

    }

    public void SetColors(string type)
    {
        Color bossColor = GetComponent<SpriteRenderer>().color;
        Debug.Log($"{bossColor}색 변경");
        if (type =="gAndB")
        {
            GetComponent<SpriteRenderer>().color = new Color(bossColor.r, bossColor.g - 5, bossColor.b - 5, bossColor.a);
        }
        if (type.Equals("die"))
        {
            GetComponent<SpriteRenderer>().color = new Color(bossColor.r - 5, bossColor.g + 5, bossColor.b + 5, bossColor.a-1);
        }

    }



    IEnumerator rotateOn()
    {
        yield return new WaitForSecondsRealtime(11.9f);
        rotate = true;
    }
    void Shoot()
    {
        //미사일 프리팹, 런쳐포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);


    }

    int myHp;
    private void Update()
    {
        if (rotate)
        {
            transform.Rotate(new Vector3(0, 0, 1) * 180 * Time.deltaTime);
        }
        


    }


    IEnumerator SetColor(string s)
    {
        SetColors(s);
        yield return new WaitForSecondsRealtime(1.9f);
    }
}
