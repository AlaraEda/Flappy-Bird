using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    //Increase the score when you hit empty space
    private void OnTriggerEnter2D(Collider2D collision){
        Score.score++;
    }
}
