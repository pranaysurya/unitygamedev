using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource audioSource;
    public AudioClip audioClip;
    

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        scoreText.text = PlayerScore.ToString();
        musicPlayPoint();

    }

    void musicPlayPoint()
    {
        audioSource.PlayOneShot(audioClip);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }


}
