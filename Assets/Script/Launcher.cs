using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // �̻��� ������ ������ ����
    void Start()
    {
        //InvokeRepeating ( �Լ� �̸�, �ʱ����� �ð�, ������ �ð� )
        InvokeRepeating("Shoot", 1f, 0.1f);
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
