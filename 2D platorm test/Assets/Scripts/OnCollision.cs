using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public PlayerMovements movement;
    public GameObject gameover;
    public static bool pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void NewGame()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Cactus")
        {
            gameover.SetActive(true);
            Time.timeScale = 0f;
            pause = true;
        }
    }
}
