using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    float timer;
    bool hasTouched;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        timer = 0;
        hasTouched = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer > 5 && hasTouched)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasTouched = true;
    }
}
