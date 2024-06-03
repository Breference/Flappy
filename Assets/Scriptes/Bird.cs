using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private PlayerMove _mover;
    public int _score;

    void Start()
    {
        _mover = GetComponent<PlayerMove>();
        ResetGame();
    }

    public void IncreaseScore()
    {
        _score++;
    }

    public void  ResetGame()
    {
        _score = 0;
        _mover.ResetBird();
    }

    public void Loss()
    {
        Debug.Log("I am a loss");
        Time.timeScale = 0;
    }
}
