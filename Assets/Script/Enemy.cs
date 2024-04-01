using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //움직일 속도를 지정해줍니다
    public float moveSpeed = 1.3f;

    void Start()
    {
        
    }


    void Update()
    {
        //움직임을 변수로 만들기
        float distanceY = moveSpeed * Time.deltaTime;
        //움직임을 반영
        transform.Translate(0, -distanceY, 0);
    }

    //화면 밖으로 나가면 안 보일경우 호출이 되는 함수 (Ctrl + Shift + M) 눌러서 찾을 수도 있음
    private void OnBecameInvisible()
    {
        //미사일 지우기 > 직접 보고 있는 카메라에서 안 보일 경우에 삭제됨 (테스트로 Scene 넓게 보면 안 사라짐)
        Destroy(gameObject);
    }
}
