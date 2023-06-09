using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{


    public float speed = 20f;
    public Rigidbody2D rb;
    public Player2_Health player2_Health;
    public int Damage;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Debug.Log(hitinfo.name);
        Destroy(gameObject);
        player2_Health.takeDamage(Damage);        
    }

}
