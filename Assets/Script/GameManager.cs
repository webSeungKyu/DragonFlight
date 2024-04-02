using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�̱���
    public static GameManager Instance;
    public Text scoreText;
    public Text startText;

    int score = 0;

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

}
