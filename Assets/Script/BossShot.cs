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
        //Y축 이동
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
    }

    //화면 밖으로 나가면 안 보일경우 호출이 되는 함수 (Ctrl + Shift + M) 눌러서 찾을 수도 있음
    private void OnBecameInvisible()
    {
        //미사일 지우기 > 직접 보고 있는 카메라에서 안 보일 경우에 삭제됨 (테스트로 Scene 넓게 보면 안 사라짐)
        Destroy(gameObject);
    }



}
