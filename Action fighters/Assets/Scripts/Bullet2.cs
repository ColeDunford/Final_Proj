using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.left * speed;
    }
    private void OnCollisionEnter2D(Collision2D hitinfo)
    {
        Debug.Log(hitinfo.gameObject.name);
        Destroy(gameObject);
    }

}
