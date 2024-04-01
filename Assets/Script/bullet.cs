using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    void Start()
    {
        
    }

    void Update()
    {
        //Y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //ȭ�� ������ ������ �� ���ϰ�� ȣ���� �Ǵ� �Լ� (Ctrl + Shift + M) ������ ã�� ���� ����
    private void OnBecameInvisible()
    {
        //�̻��� ����� > ���� ���� �ִ� ī�޶󿡼� �� ���� ��쿡 ������ (�׽�Ʈ�� Scene �а� ���� �� �����)
        Destroy(gameObject);
    }

    /*
     Ʈ����
    �ݸ���
    enter �� �� ���� ��
    stay ��� �浹 ���� �ȿ�
    exit �浹 ���� �� ������ �� �� ��
     */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�̻��ϰ� ���� �ε�����.
        /*if(collision.gameObject.tag == "Enemy")*/
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            //�� �����
            Destroy(collision.gameObject);

            //�̻��� �����
            Destroy(gameObject);

        }
    }

}
