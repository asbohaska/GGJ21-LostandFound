using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public static GameManager Instance {get; private set;}
    private void Awake () {
        //Initiate singleton
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    public bool isLookingAtSign = false;
    public bool isPlaying = false;

    //Timer
    public float playedTime;
    public Text timeDisplay;
    public void Start() {
        playedTime = 0f;
    }

    void Update(){

        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
        if (isPlaying){
            playedTime += Time.deltaTime;
            timeDisplay.text = "Time: " + Mathf.RoundToInt(playedTime);
        }   
    }
    

} 

