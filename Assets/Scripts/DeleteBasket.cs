using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBasket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Apple"))
        {
            Debug.Log("Missed");
            Destroy(transform.parent.gameObject);
            Destroy(collision.gameObject);
            ScoreBehavior.instance.ScoreUpdate(-200);
        }

    }
}
