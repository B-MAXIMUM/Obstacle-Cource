using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager Instantce;
    public GameObject pause;
    public GameObject gameUi;
    public GameObject Gameover;
    public GameObject MainMenue;
    public TextMeshProUGUI score;
    private int _scoreNum;
    
    private void Awake() 
    {
        Instantce = this;
    }
    public void pausebutton()
    {
        Time.timeScale = 0;
        gameUi.gameObject.SetActive(false);
        pause.gameObject.SetActive(true);
    }
    public void playbutton()
    {
        Time.timeScale = 1;
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Scoredisplay()
    {

    }
    public void gameOverEvent()
    {
        Time.timeScale = 0;
        Gameover.gameObject.SetActive(true);
        gameUi.gameObject.SetActive(false);
    }
}
