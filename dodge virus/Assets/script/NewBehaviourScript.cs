using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class NewBehaviourScript : MonoBehaviour
{
    public static NewBehaviourScript instance;
    public Text score;
    public Text high;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    private void FixedUpdate()
    {
        //score.text = collision.high.ToString();
    }


}
