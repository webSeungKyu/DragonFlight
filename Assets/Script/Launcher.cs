using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // 미사일 프리팹 가져올 변수
/*    public AudioClip shotSound;
    private AudioSource soundPlayer;*/
    void Start()
    {
        bullet.GetComponent<SpriteRenderer>().color = Color.white;
        //총 색 변경
        Invoke("ChangeBullet", 20f);


        /*soundPlayer = GetComponent<AudioSource>();*/
        //InvokeRepeating ( 함수 이름, 초기지연 시간, 지연할 시간 )
        InvokeRepeating("Shoot", 3f, 0.119f);
        

    }

    void ChangeBullet()
    {
        //총 색 변경
        bullet.GetComponent<SpriteRenderer>().color = new Color(0, 255, 255, 255);
    }

    void Shoot()
    {
        //미사일 프리팹, 런쳐포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);

        //사운드 플레이
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
