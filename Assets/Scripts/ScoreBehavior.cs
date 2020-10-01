using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehavior : MonoBehaviour
{
    public static ScoreBehavior instance;

    //private bool isPauseActive;
    private ScoreBehavior() { }
    // Start is called before the first frame update
    void Awake()
    {
        if (instance)
            Destroy(gameObject);
        else
            instance = this;
    }

    public void ScoreUpdate(float score)
    {
        string scoreString = this.GetComponent<Text>().text.Split(' ')[1];
        //Debug.Log(scoreString);
        float sc = float.Parse(scoreString) + score;
        this.GetComponent<Text>().text = "Score: " + sc.ToString();
    }
    public void resetScore()
    {
        this.GetComponent<Text>().text = "Score: 0";
    }

    public int GetScore()
    {
        string scoreString = this.GetComponent<Text>().text.Split(' ')[1];
        return int.Parse(scoreString);
    }
}
