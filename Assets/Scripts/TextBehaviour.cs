using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBehaviour : MonoBehaviour
{
    public bool gameStarted = false;

    public PlayerController deathHappened;

    void Update()
    {
        if(gameStarted == true)
        {
            PlayerStatus();
        }
        if(deathHappened.playerDeath){
            DeathText();
        }
    }

    public void ClickToStart()
    {
        gameStarted = true;
        GameObject startButton = GameObject.Find("StartButton");
        startButton.SetActive(false);
    }

    void PlayerStatus()
    {
        TMP_Text displayText = this.gameObject.GetComponent<TMP_Text> ();
        displayText.text = " ";
    }

    void DeathText()
    {
        TMP_Text displayText = this.gameObject.GetComponent<TMP_Text> ();
        displayText.text = "You are dead. Try again, noob.";
    }
}
