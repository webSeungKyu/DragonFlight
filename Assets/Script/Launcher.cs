using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // �̻��� ������ ������ ����
/*    public AudioClip shotSound;
    private AudioSource soundPlayer;*/
    void Start()
    {
        bullet.GetComponent<SpriteRenderer>().color = Color.white;
        //�� �� ����
        Invoke("ChangeBullet", 20f);


        /*soundPlayer = GetComponent<AudioSource>();*/
        //InvokeRepeating ( �Լ� �̸�, �ʱ����� �ð�, ������ �ð� )
        InvokeRepeating("Shoot", 3f, 0.119f);
        

    }

    void ChangeBullet()
    {
        //�� �� ����
        bullet.GetComponent<SpriteRenderer>().color = new Color(0, 255, 255, 255);
    }

    void Shoot()
    {
        //�̻��� ������, ����������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);

        //���� �÷���
        SoundManager.instance.PlayerSound();

/*        if (soundPlayer != null)
        {
            Debug.Log("Shot Sound Play!");
            soundPlayer.PlayOneShot(shotSound);
        }
        else
        {
            Debug.Log("Shot Sound NoPlay!");
        }*/

    }
    void Update()
    {
        
    }
}
