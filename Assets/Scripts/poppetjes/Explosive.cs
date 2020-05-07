using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    
    
    Rigidbody2D rb;
    Collider2D[] hitColliders;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ExplosionDamage(this.gameObject.transform.position, 5);
        }
        
    }
    void ExplosionDamage(Vector3 center, float radius)
    {
        
        hitColliders = Physics2D.OverlapCircleAll(center, radius);
        
        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].tag == "Level") 
            {
                Destroy(hitColliders[i].gameObject);
            }
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //rb.bodyType = RigidbodyType2D.Static;
        //Destroy(rb);
    }
}
