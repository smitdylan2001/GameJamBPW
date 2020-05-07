using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    
    
    Rigidbody2D rb;
    Collider2D[] hitColliders;
    float timer;
    bool hasTouched;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.fixedDeltaTime;
        if (timer > 4 && hasTouched)
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
        hasTouched = true;
    }
}
