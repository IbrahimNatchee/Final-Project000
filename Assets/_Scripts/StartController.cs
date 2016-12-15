﻿using UnityEngine;
using System.Collections;

// reference to the UI namespace
using UnityEngine.UI;

// reference to manage my scenes
using UnityEngine.SceneManagement;
/**
 * This is a Platformer game 
 * 
 *

/**  
* <summary>  
* This is the ReStartingController class to control the Game restarting.  
* </summary>  
*   
* @class StartingController  
*/
public class StartController : MonoBehaviour
{
    // PRIVATE INSTANCE VARIABLES
    private GameObject _gameControllerObject;
    private GameController _gameController;

    // PUBLIC INSTANCE VARIABLES
    [Header("Labels")]
    public Text GameTitleLabel1;


    //	[Header("Buttons")]
    //public Button StartButton;


    public AudioSource LaughSound;


    /**
        * <summary>
        * This is the method for starting the EnemyController class which initiates value
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
    void Start()
    {

        //	GameObject.Find("GameView").GetComponent<GameView>();

        //	this._gameControllerObject = GameObject.Find ("Game Controller").GetComponent<GameController>();
        //	this._gameController = this._gameControllerObject.GetComponent<GameController> () as GameController;

        //	GameObject.Find ("Game Controller").GetComponent<GameController> ().ScoreValue;


        this.GameTitleLabel1.text = "SPECTRAL TALE";


        //	this.Score.text = "Total Score: " + GameObject.Find ("Game Controller").GetComponent<GameController> ().ScoreValue;
       // this.LaughSound.Play();
    }

    /**
        * <summary>
        * This method is called once per frame.
        * </summary>
        * 
        * @method Update
        * @returns {void} 
        */
    void Update()
    {

    }

    public void ReStartButtonClick()
    {
        SceneManager.LoadScene("InDoors");

    }

    public void ExitButoonClick() {
       Application.Quit();
    }


}