using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    private Rigidbody2D PlayerRb;
    private Animator Anim;
    public float jump;
    public Transform ATKpnt;
    public float ATKRange = 0.5f;
    public LayerMask enemyLayers;
    public Player2_Health player2_Health;
    public int Damage;
    public Transform Groundcheck;
    public LayerMask GroundLayer;
    public LayerMask player2layer;
    public LayerMask player1layer;



    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    private bool IsOnGround()
    {
        return Physics2D.OverlapCircle(Groundcheck.position, 0.2f, GroundLayer);
    }

    void Attack()
    {

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(ATKpnt.position, ATKRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We Hit" + enemy.name);
            // call takedamge on player 2
            player2_Health.takeDamage(Damage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (ATKpnt == null)
            return;

        Gizmos.DrawWireSphere(ATKpnt.position, ATKRange);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.A))
            horizontalInput = -1;
            
        else if (Input.GetKey(KeyCode.D))
            horizontalInput = 1;
            
        else
            horizontalInput = 0;
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

         if (Input.GetKeyDown(KeyCode.Q))
        {
            Anim.SetTrigger("LiteATK");
            Attack();

        }

        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            Anim.SetTrigger("UpATK");
            Attack();
        }

         if (Input.GetKeyDown(KeyCode.E))
        {
            Anim.SetTrigger("HvyATK");
            Attack();
        }

         if (Input.GetKey(KeyCode.S))
        {
            Anim.SetTrigger("Shoot");
        }

        else
        {
            Anim.SetBool("RunShoot", false);
        }


        if (Input.GetKeyDown(KeyCode.W) && IsOnGround())
        {
            PlayerRb.AddForce(new Vector2(PlayerRb.velocity.x, jump));
        }

       
       //if (player2layer.position.x > player1layer.position.x)
       //{
       //     gameObject.transform.localScale = new Vector3(-1, 1, 1);
       //}


    }





}
