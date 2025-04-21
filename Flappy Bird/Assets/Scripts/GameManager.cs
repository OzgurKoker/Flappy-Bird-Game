using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;
    private int score;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore");

    }


    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StartGameWithSpace(bool deathScreen)
    {
        if (deathScreen)
        {
            SceneManager.LoadScene("Game");
        }

    }



}
