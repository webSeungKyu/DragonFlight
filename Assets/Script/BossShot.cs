using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShot : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Start()
    {

    }

    void Update()
    {
        //Y�� �̵�
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
    }

    //ȭ�� ������ ������ �� ���ϰ�� ȣ���� �Ǵ� �Լ� (Ctrl + Shift + M) ������ ã�� ���� ����
    private void OnBecameInvisible()
    {
        //�̻��� ����� > ���� ���� �ִ� ī�޶󿡼� �� ���� ��쿡 ������ (�׽�Ʈ�� Scene �а� ���� �� �����)
        Destroy(gameObject);
    }



}
