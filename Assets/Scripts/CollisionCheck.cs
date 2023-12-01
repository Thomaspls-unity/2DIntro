using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollisionCheck : MonoBehaviour

{
    private int myScore;

    // Start is called before the first frame update
    void Start()
    {
        myScore = 0;
        Debug.Log("My score is " + myScore);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            UpdateScore(1);
            collision.gameObject.SetActive(false);
        }else if (collision.gameObject.CompareTag("Bonus"))
        {
            UpdateScore(5);
            collision.gameObject.SetActive(false);
        }

    }

    public void UpdateScore(int scoreValue)
    {
        myScore += scoreValue;

        if (myScore <= 0)
        {
            myScore = 0;
        }
        Debug.Log("My score is " + myScore);
    }

    public int GetScore()
    {
        return myScore;
    }

}
