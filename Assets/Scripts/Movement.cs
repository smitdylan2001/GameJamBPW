using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameManager gm;
    public bool hasStarted;
    public bool hasJumped;
    public float jumpForce;


    void Start()
    {
        hasStarted = false;
        hasJumped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasStarted && !hasJumped)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            hasJumped = true;
        }

        
    }

    private void FixedUpdate()
    {
        if (hasStarted)
        {
            rb.velocity = new Vector2(2, rb.velocity.y);

        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "End")
        {
            gm.Points += 1;
            this.gameObject.SetActive(false);
        }
        hasJumped = false;
    }

    public void StartGame()
    {
        hasStarted = true;
    }
}
