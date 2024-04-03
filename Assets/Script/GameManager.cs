using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //ΩÃ±€≈Ê
    public static GameManager Instance;
    public Text scoreText;
    public Text startText;
    public Text bossText;

    public int score = 0;
    public int bossHp = 200;
    public Image clear;
    public Text clearText;

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
            Debug.Log("1500¡° √ ∞˙");
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
            GameObject boss = GameObject.FindGameObjectWithTag("Finish");
            Destroy(boss);
            clear.enabled = true;
            clearText.enabled = true;
            StartCoroutine("ClearText", "Game\nClear");
        }

    }

    IEnumerator ClearText(string str)
    {
        clearText.text = "";
        for (int i = 0; i < str.Length; i++)
        {
            clearText.text += str[i];
            yield return new WaitForSeconds(0.5f);
        }
    }


    void Start()
    {
        clear.enabled = false;
        clearText.enabled = false;
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
        string s = "∫∏Ω∫\n¡÷¿«";
        for(int i = 0; i < s.Length; i++)
        {
            bossText.text += s[i];
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(1f);
        bossText.enabled = false;
    }


}
