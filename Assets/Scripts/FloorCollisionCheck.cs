using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloorCollisionCheck : MonoBehaviour

{
    private int myFail;
    public TMP_Text failTxt;
    public CollisionCheck collisionCheck;
    public UISetup uiSetup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collisionCheck.UpdateScore(-1);
            //collision.gameObject.SetActive(false);
            collisionCheck.SetBallPosition(collision.transform);
        }
        else if (collision.gameObject.CompareTag("Bonus"))
        {
            collisionCheck.UpdateScore(-1);
            UpdateFail(1);
            uiSetup.ShowText();
            //collision.gameObject.SetActive(false);
            collisionCheck.SetBonusPosition(collision.transform);
        }
    }

    public void UpdateFail(int failValue)
    {
        myFail += failValue;
    }

    public int GetFail()
    { 
        return myFail;
    }
}