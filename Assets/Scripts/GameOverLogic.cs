using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverLogic : MonoBehaviour
{
    [SerializeField]
    private BirdController birdControllerScript;
    [SerializeField]
    private GameObject gameOverScreen;
    [SerializeField]
    private Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        birdControllerScript.Death += BirdControllerScript_Death;
        birdControllerScript.Scored += BirdControllerScript_Scored;
    }

    private void BirdControllerScript_Scored(object sender, EventArgs e)
    {
        score++;
        scoreText.text = score.ToString();
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void BirdControllerScript_Death(object sender, System.EventArgs e)
    {
        gameOverScreen.SetActive(true);
    }
}
