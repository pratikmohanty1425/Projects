using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    int cnt = 0;
    public static int high;

    private void Awake()
    {
        NewBehaviourScript.instance.high.text = gethighscore().ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bomb")
        {
            cnt++;
            high = cnt;
            NewBehaviourScript.instance.score.text = cnt.ToString();
            if (cnt > gethighscore())
            {
                PlayerPrefs.SetInt("Highscore", cnt);
                NewBehaviourScript.instance.high.text = cnt.ToString();
            }
            Destroy(collision.gameObject);
        }
    }
    public int gethighscore()
    {
        int mynum = PlayerPrefs.GetInt("Highscore");
        return mynum;
    }
}
