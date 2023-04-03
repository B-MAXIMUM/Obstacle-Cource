using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    public GameObject title;
    public GameObject gameUI;
    public GameObject pause;
    public GameObject gameoverP;
    public GameObject winnerP;
    public TextMeshProUGUI hP;
    [SerializeField] private int _Health = 5;
    private void Start() 
    {
      Instance = this;   
    }

    private void Update()
    {
        hP.text = "lives " + _Health.ToString();
        if(  _Health == 0 )
        {
            Gameover();
        }
    }
    public void gamestart()
    {
        Time.timeScale = 1;
        title.gameObject.SetActive(false);
        gameUI.gameObject.SetActive(true);
    }
    public void nextlevel()
    {
        SceneManager.LoadScene(0);
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void pausebutton()
    {
        gameUI.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void Gameover()
    {
        gameoverP.SetActive(true);
        gameUI.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    public void playbutton()
    {
        Time.timeScale = 1;
        gameUI.SetActive(true);
        pause.SetActive(false);
    }
    public void healthLoss()
    {
        _Health = _Health - 1;
    }
    public void winner()
    {
        winnerP.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
