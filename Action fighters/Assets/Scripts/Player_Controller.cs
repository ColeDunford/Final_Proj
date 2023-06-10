using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    private Rigidbody2D PlayerRb;
    private Animator Anim;
    public float jump;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //move left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Anim.SetBool("IsMoving", true);
        }
           
        else
        {
            Anim.SetBool("IsMoving", false);
        }

        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.E))
        {
            Anim.SetTrigger("Jump");
        }

         if (Input.GetKey(KeyCode.Q))
        {
            Anim.SetTrigger("LiteATK");
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            Anim.SetTrigger("UpATK");
        }

         if (Input.GetKey(KeyCode.E))
        {
            Anim.SetTrigger("HvyATK");
        }

         if (Input.GetKey(KeyCode.S))
        {
            Anim.SetTrigger("Shoot");
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerRb.AddForce(new Vector2(PlayerRb.velocity.x, jump));
        }
       
    }

}
