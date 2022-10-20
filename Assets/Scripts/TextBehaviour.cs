using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextBehaviour : MonoBehaviour
{
    public PlayerController deathHappened;

    public ButtonHandler buttonAction;

    public GameObject startButton;

    public GameObject restartButton;

    void Update()
    {
        if (buttonAction.startGame == true)
        {
            PlayerStatus();
        }
        if (deathHappened.playerDeath == true)
        {
            DeathText();
        }
        if (deathHappened.playerWin == true)
        {
            WinText();
        }
    }

    void PlayerStatus()
    {
        TMP_Text displayText = this.gameObject.GetComponent<TMP_Text>();
        displayText.text = " ";
        startButton.SetActive(false);
    }

    void DeathText()
    {
        TMP_Text displayText = this.gameObject.GetComponent<TMP_Text>();
        displayText.text = "You are dead. Try again, noob.";
        restartButton.SetActive(true);
    }

    void WinText()
    {
        TMP_Text displayText = this.gameObject.GetComponent<TMP_Text>();
        displayText.text = "Winner! Click to play again";
        restartButton.SetActive(true);
    }
}
