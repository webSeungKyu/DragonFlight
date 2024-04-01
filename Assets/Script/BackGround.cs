using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    //��ũ���� �Ǵ� ��׶���
    public float scrollSpeed = 1f;
    private Material myMaterial;

    void Start()
    {
        //���͸���(Material) ��������
        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //������ ���͸���(Material)���� ��������
        Vector2 newOffset = myMaterial.mainTextureOffset;

        //���Ӱ� offset �ٲ��ֱ�
        //y�κа��� �ӵ��� ������ �����ؼ� �����ֱ�
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        //���͸���(Material)�� �����¿� ���� �־��ش�
        myMaterial.mainTextureOffset = newOffset;

    }
}
