using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //���ǵ�
    public float moveSpeed = 3;
    void Start()
    {
        
    }

    void Update()
    {
        //x�� �� ���� vector ���� * �ð� * ���ǵ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //x�� �̵� ����
        transform.Translate(distanceX, 0, 0);
    }
}
