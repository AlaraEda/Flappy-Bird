using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //add this for replay() function

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;


    private void Start(){
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(0);
    }


}
