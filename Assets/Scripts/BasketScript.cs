using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BasketScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        ScoreBehavior.instance.resetScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Apple"))
        {
            Debug.Log("Hit");
            Destroy(collision.gameObject);
            ScoreBehavior.instance.ScoreUpdate(100);
        }

    }

}
