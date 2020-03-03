using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
{
    public GameObject gameover;
    public static bool pause;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        pause = false;
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {

        if (pause == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                NewGame();
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                BacktoMain();
            }
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            pause = true;
        }
    }
}
