using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{

    private float waterHeight;
    public float floatingPower;
    bool isFloating = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isFloating == true && transform.position.y < waterHeight)
        {
            rb.AddForce(new Vector2(0, floatingPower / (waterHeight / transform.position.y)));
        } 
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "water" && isFloating == false)
        {
            waterHeight = transform.position.y;
            isFloating = true;
            Debug.Log("epic");
        }
    }
}
