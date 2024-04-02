using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BossManager : MonoBehaviour
{
    public static BossManager Instance;
    public GameObject bullet; // �̻��� ������ ������ ����
    public bool rotate = false;
    void Start()
    {

        //InvokeRepeating ( �Լ� �̸�, �ʱ����� �ð�, ������ �ð� )
        InvokeRepeating("Shoot", 3f, 1f);
        StartCoroutine("rotateOn");

    }

    public void SetColors(string type)
    {
        Color bossColor = GetComponent<SpriteRenderer>().color;
        Debug.Log($"{bossColor}�� ����");
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
        //�̻��� ������, ����������, ���Ⱚ ����
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
