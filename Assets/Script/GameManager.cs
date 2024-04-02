using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //½Ì±ÛÅæ
    public static GameManager Instance;
    public Text scoreText;
    public Text startText;
    public Text bossText;

    public int score = 0;
    public int bossHp = 200;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = $"Score : {score.ToString()}";
        if(score > 1500)
        {
            Debug.Log("1500Á¡ ÃÊ°ú");
        }
    }

    public void bossAttack()
    {
        bossHp--;
        if (bossHp <= 100 && bossHp >= 50)
        {
            Debug.Log(bossHp);
            GameObject boss = GameObject.FindGameObjectWithTag("Finish");
            Color bossColor = boss.GetComponent<SpriteRenderer>().color;
            bossColor = new Color(bossColor.r, bossColor.g - 0.1f, bossColor.b - 0.1f, bossColor.a);
            boss.GetComponent<SpriteRenderer>().color = bossColor;
        }
        if (bossHp < 20)
        {
            Debug.Log(bossHp);
            GameObject boss = GameObject.FindGameObjectWithTag("Finish");
            Color bossColor = boss.GetComponent<SpriteRenderer>().color;
            bossColor = new Color(bossColor.r - 0.1f, bossColor.g + 0.1f, bossColor.b + 0.1f, bossColor.a - 1);
            boss.GetComponent<SpriteRenderer>().color = bossColor;

        }
        if (bossHp <= 0)
        {
            
        }

    }


    void Start()
    {
        StartCoroutine("StartGame");

    }

    IEnumerator StartGame()
    {
        int i = 3;
        while(i > 0)
        {
            startText.text = i.ToString();
            yield return new WaitForSeconds(1f);
            i--;

            if(i == 0)
            {
                startText.gameObject.SetActive(false);
            }
        }

        
    }

    IEnumerator BossText()
    {
        string s = "º¸½º\nÃâÇö";
        for(int i = 0; i < s.Length; i++)
        {
            bossText.text += s[i];
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(1f);
        bossText.enabled = false;
    }


}
