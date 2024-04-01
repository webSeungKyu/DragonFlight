using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //������ �ӵ��� �������ݴϴ�
    public float moveSpeed = 1.3f;

    void Start()
    {
        
    }


    void Update()
    {
        //�������� ������ �����
        float distanceY = moveSpeed * Time.deltaTime;
        //�������� �ݿ�
        transform.Translate(0, -distanceY, 0);
    }

    //ȭ�� ������ ������ �� ���ϰ�� ȣ���� �Ǵ� �Լ� (Ctrl + Shift + M) ������ ã�� ���� ����
    private void OnBecameInvisible()
    {
        //�̻��� ����� > ���� ���� �ִ� ī�޶󿡼� �� ���� ��쿡 ������ (�׽�Ʈ�� Scene �а� ���� �� �����)
        Destroy(gameObject);
    }
}
