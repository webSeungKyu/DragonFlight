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
        /*soundPlayer = GetComponent<AudioSource>();*/
        //InvokeRepeating ( �Լ� �̸�, �ʱ����� �ð�, ������ �ð� )
        InvokeRepeating("Shoot", 1f, 0.42f);

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
