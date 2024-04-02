using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float moveSpeed = 9.7f;
    public GameObject effect;
    public GameObject effect2;
    public GameObject effect3;


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
            //����Ʈ
            Instantiate(effect, collision.gameObject.transform.position, Quaternion.identity);
            //����
            SoundManager.instance.SoundDie();
            //�� �����
            Destroy(collision.gameObject);
            //���� �߰�
            GameManager.Instance.AddScore(100);
            //�̻��� �����
            Destroy(gameObject);

        }else if (collision.gameObject.CompareTag("Finish"))
        {
            GameManager.Instance.bossAttack();

            Instantiate(effect2, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }else if (collision.gameObject.CompareTag("NomalEnemy"))
        {
            //����Ʈ
            Instantiate(effect3, collision.gameObject.transform.position, Quaternion.identity);
            //����
            SoundManager.instance.SoundDie();
            //�� �����
            Destroy(collision.gameObject);
            //���� �߰�
            GameManager.Instance.AddScore(100);
            //�̻��� �����
            Destroy(gameObject);
        }


    }

}
