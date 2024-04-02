using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //�̱���
    public static SoundManager instance;


    AudioSource myAudio; //AudioSource ������Ʈ�� ������ ��´�

    public AudioClip soundDie; //�� ���
    public AudioClip soundShot; //�̻��� �߻�

    private void Awake()
    {
        if(instance == null) //instance�� ����ִٸ�
        {
            instance = this; //�ڱ�������ü
        }
    }


    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerSound()
    {
        myAudio.PlayOneShot(soundShot);
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
}
