using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloorCollisionCheck : MonoBehaviour
{
    public TMP_Text failTxt;
    public CollisionCheck collisionCheck;
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
            collision.gameObject.SetActive(false);
        }else if (collision.gameObject.CompareTag("Bonus"))
        {
            failTxt.text = "Wow, you missed >:)";
            collisionCheck.UpdateScore(-1);
            collision.gameObject.SetActive(false);
        }
    

}
}