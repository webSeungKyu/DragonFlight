using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
