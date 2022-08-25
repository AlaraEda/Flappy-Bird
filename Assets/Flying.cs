using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Left mouse click;
        if(Input.GetMouseButtonDown(0)){

            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }
}
