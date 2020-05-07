using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetism : MonoBehaviour
{
    public float magnetismRadius, magnetismStrength;
    Vector2 targetLocation;
    bool targetFound = false;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, magnetismRadius);
        if (colliders.Length > 0)
        {
            targetLocation = colliders[0].transform.position;
            targetFound = true;
        }

        if (targetFound = true && rb != null)
        {
            rb.AddForce(new Vector2(targetLocation.x - transform.position.x, targetLocation.y - transform.position.y) * (magnetismStrength / Vector2.Distance(targetLocation, transform.position)));
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        rb.bodyType = RigidbodyType2D.Static;
        //Destroy(rb);
    }
}