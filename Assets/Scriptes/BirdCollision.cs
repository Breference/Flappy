using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    private Bird _bird;

    // Start is called before the first frame update
   private void Start()
    {
      _bird = GetComponent<bird>();
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreZone")
        {
            _bird.IncreaseScore();
        }
        else {
            _bird.Loss();
        }
    }
}
