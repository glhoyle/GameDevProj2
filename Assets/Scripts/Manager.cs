using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Manager instance;

    private Manager() { }
    void Start()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        //TODO make scene transitions work
        SceneManager.LoadScene("Title", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //ToggleMenu();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            //RestartGame();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        Time.timeScale = 0;
    }
    public void ToggleMenu()
    {
        if (Time.timeScale == 0)
        {
            SceneManager.UnloadSceneAsync("PauseMenu");
            Time.timeScale = 1;

        }
        else if (Time.timeScale == 1)
        {
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
            Time.timeScale = 0;
        }
    }
    public void GameStart()
    {
        SceneManager.UnloadSceneAsync("Title");
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        ScoreBehavior.instance.resetScore();
        Time.timeScale = 1;
    }
    public void WinGame()
    {
        SceneManager.LoadScene("WinScreen");
        ScoreBehavior.instance.resetScore();
        Time.timeScale = 0;
    }
}
