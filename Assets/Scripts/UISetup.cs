using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UISetup : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public TMP_Text failTxt;
    public CollisionCheck collisionCheck;
    public FloorCollisionCheck floorCollisionCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "SCORE: " + collisionCheck.GetScore();
        failTxt.text = "Damn, you've missed the bonus " + floorCollisionCheck.GetFail() + " time(s) :'(";
    }

    public void ShowText()
    {
        failTxt.enabled = true;
        Invoke("HideText", 0.9f);
    }

    public void HideText()
    {
        failTxt.enabled = false;
    }
}
