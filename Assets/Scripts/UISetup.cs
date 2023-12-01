using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UISetup : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public CollisionCheck collisionCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "SCORE: " + collisionCheck.GetScore();
    }
}
