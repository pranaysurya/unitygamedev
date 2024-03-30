using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float flapStrength;
    private LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource audioSource;
    public AudioClip gameOverClip, flapClip;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //press q to quit game
        if (Input.GetKeyDown(KeyCode.Q) == true)
        { 
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) == true && birdIsAlive == true)
        { 
            MyRigidbody.velocity = Vector2.up * flapStrength;
            musicPlayFlap();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
        musicPlayGameOver();
    }

    void musicPlayGameOver()
    {
        audioSource.PlayOneShot(gameOverClip);
    }

    void musicPlayFlap()
    {
        audioSource.PlayOneShot(flapClip);
    }

}

/*
 * LINKS
 * https://id.unity.com/en/account/edit
 * https://www.youtube.com/watch?v=XtQMytORBmM
 * https://cloud.unity.com/home/organizations/3573793783919
 * 
 * 
*/