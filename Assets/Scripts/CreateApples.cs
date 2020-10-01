using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateApples : MonoBehaviour
{
// Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public Transform spawnLocL, spawnLocR;
    float Timer;
    public bool spawnRight;
    public float freq = 1f;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {

    }

    void Awake()
    {
        Timer = Time.time + freq;
    }

    void Update()
    {
        if (Timer < Time.time)
        { //This checks wether real time has caught up to the timer
            if (spawnRight)
            {
                Instantiate(myPrefab, spawnLocR.position, Quaternion.identity);
            } else
            {
                Instantiate(myPrefab, spawnLocL.position, Quaternion.identity);
            }
            spawnRight = !spawnRight;
            freq -= 0.01f;
            Timer = Time.time + freq; //This sets the timer 3 seconds into the future
        }
    }

}
