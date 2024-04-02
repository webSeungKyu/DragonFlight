using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //싱글톤
    public static SoundManager instance;


    AudioSource myAudio; //AudioSource 컴포넌트를 변수로 담는다

    public AudioClip soundDie; //적 사망
    public AudioClip soundShot; //미사일 발사

    private void Awake()
    {
        if(instance == null) //instance가 비어있다면
        {
            instance = this; //자기참조객체
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
