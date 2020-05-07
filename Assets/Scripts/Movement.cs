using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameManager gm;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(2f, 0f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "End")
        {
            gm.Points += 1;
            this.gameObject.SetActive(false);
        }
    }
}
