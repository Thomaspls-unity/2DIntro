using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    private int myScore;
    public Collider2D spawnTrigger;
    public Collider2D spawnTriggerBonus;

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
            //collision.gameObject.SetActive(false);
            SetBallPosition(collision.transform);
        }
        else if (collision.gameObject.CompareTag("Bonus"))
        {
            UpdateScore(5);
            //collision.gameObject.SetActive(false);
            SetBonusPosition(collision.transform);
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

    public void SetBallPosition(Transform ballTransform)
    {
        float horizontalPosition = Random.Range(spawnTrigger.bounds.min.x, spawnTrigger.bounds.max.x);
        float verticalPosition = Random.Range(spawnTrigger.bounds.min.y, spawnTrigger.bounds.max.y);

        ballTransform.position = new Vector2(horizontalPosition, verticalPosition);
    }

    public void SetBonusPosition(Transform bonusTransform)
    {
        float horizontalPosition = Random.Range(spawnTriggerBonus.bounds.min.x, spawnTriggerBonus.bounds.max.x);
        float verticalPosition = Random.Range(spawnTriggerBonus.bounds.min.y, spawnTriggerBonus.bounds.max.y);

        bonusTransform.position = new Vector2(horizontalPosition, verticalPosition);
    }
}
