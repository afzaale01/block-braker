using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int maxHit;
    private int timesHit;

    public static int breakableCount;

    public LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();


        bool breakable = (this.tag == "Breakable");

        if (breakable)
        {
            breakableCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool breakable = (this.tag == "Breakable");

        if (breakable)
        {
            CountHit();
        }
    }

    private void CountHit()
    {
        timesHit++;

        if (maxHit == timesHit)
        {
            breakableCount--;
            levelManager.BrickDestoyed();
            Destroy(gameObject);
        }
    }
}
