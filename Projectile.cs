using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;

    private Rigidbody2D rigidBody;

    public float timeToLive = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = transform.right * projectileSpeed;
        
        Destroy(gameObject, timeToLive);
    }

    private void OnCollision2D(Collider2D collision)
    {
       if (collision.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
   
}
