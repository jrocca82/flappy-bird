using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rBody;
    public TextBehaviour textScript;
    public ButtonHandler buttonAction;
    public bool playerDeath = false;
    public bool playerWin = false;

    void Start()
    {
        rBody.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        if (buttonAction.startGame == true)
        {
            rBody.bodyType = RigidbodyType2D.Dynamic;
            PlayerInput();
            PlayerMovement();
        }

        if(playerWin == true){
            rBody.bodyType = RigidbodyType2D.Kinematic;
        }
    }

    void PlayerInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rBody.AddForce(Vector2.up * 5);
        }
    }

    void PlayerMovement()
    {
        rBody.AddForce(Vector2.right * 20 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            playerDeath = true;
            Destroy(rBody);
        } else if(collision.gameObject.tag == "Victory"){
            playerWin = true;
        }
    }
}
