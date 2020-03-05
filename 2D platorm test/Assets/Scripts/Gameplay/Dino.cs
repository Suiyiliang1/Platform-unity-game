using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    public float jump;
    private float move;
    public Rigidbody2D body;
     
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(body.position.y <= -1.1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                body.velocity = Vector2.up * jump;
            }
        }       

    }
}
