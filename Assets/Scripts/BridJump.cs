using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BridJump : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource audioSource;

    public float JumpPower;

    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        { 
        rb.velocity = Vector2.up * JumpPower;
            audioSource.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.score  >   Score.BestScore)
        {
            Score.BestScore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }
}
