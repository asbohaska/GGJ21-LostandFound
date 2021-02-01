﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopTime : MonoBehaviour
{
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
      GameManager.Instance.isPlaying = false;
      Score.text = Mathf.CeilToInt(GameManager.Instance.playedTime).ToString();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
