using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    private UiManager Instantce;
    public GameObject pause;
    public GameObject gameUi;
    public GameObject Gameover;
    public GameObject MainMenue;
    public TextMeshProUGUI score;
    private int _scoreNum;
    
    private void Start() 
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
    
    }
    public void Scoredisplay()
    {

    }
    public void gameOverEvent()
    {

    }
}
