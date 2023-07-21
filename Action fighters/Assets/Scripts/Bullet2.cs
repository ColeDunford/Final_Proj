using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Bullet2 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Player1_Health player1_Health;
    public int Damage;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.left * speed;
    }
    private void OnCollisionEnter2D(Collision2D hitinfo)
    {
        Debug.Log(hitinfo.gameObject.name);
        Destroy(gameObject);
        player1_Health.takeDamage(Damage);
    }

}
