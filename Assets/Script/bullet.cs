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
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //화면 밖으로 나가면 안 보일경우 호출이 되는 함수 (Ctrl + Shift + M) 눌러서 찾을 수도 있음
    private void OnBecameInvisible()
    {
        //미사일 지우기 > 직접 보고 있는 카메라에서 안 보일 경우에 삭제됨 (테스트로 Scene 넓게 보면 안 사라짐)
        Destroy(gameObject);
    }

    /*
     트리거
    콜리젼
    enter 한 번 들어올 때
    stay 계속 충돌 범위 안에
    exit 충돌 끝날 때 나가질 때 한 번
     */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪혔다.
        /*if(collision.gameObject.tag == "Enemy")*/
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //이펙트
            Instantiate(effect, collision.gameObject.transform.position, Quaternion.identity);
            //사운드
            SoundManager.instance.SoundDie();
            //적 지우기
            Destroy(collision.gameObject);
            //점수 추가
            GameManager.Instance.AddScore(100);
            //미사일 지우기
            Destroy(gameObject);

        }else if (collision.gameObject.CompareTag("Finish"))
        {
            GameManager.Instance.bossAttack();

            Instantiate(effect2, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }else if (collision.gameObject.CompareTag("NomalEnemy"))
        {
            //이펙트
            Instantiate(effect3, collision.gameObject.transform.position, Quaternion.identity);
            //사운드
            SoundManager.instance.SoundDie();
            //적 지우기
            Destroy(collision.gameObject);
            //점수 추가
            GameManager.Instance.AddScore(100);
            //미사일 지우기
            Destroy(gameObject);
        }


    }

}
