using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int score;
    public Player player;
    public TextMeshProUGUI scoreText;

    public GameObject PlayButton;
    public GameObject gameOver;

    private void Awake()
    {
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        PlayButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    { 
        Time.timeScale = 0f;
        player.enabled = false;
        
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        PlayButton.SetActive(true);
        Pause();
        // Additional game over logic can be added here, such as resetting the game or showing a game over screen.
    }

    public void IncreaseScore()
    {
        score++;

        scoreText.text =  score.ToString();

    }
}
