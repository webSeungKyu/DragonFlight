using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // �̻��� ������ ������ ����
    void Start()
    {
        //InvokeRepeating ( �Լ� �̸�, �ʱ����� �ð�, ������ �ð� )
        InvokeRepeating("Shoot", 0.5f, 1f);
    }

    void Shoot()
    {
        //�̻��� ������, ����������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
