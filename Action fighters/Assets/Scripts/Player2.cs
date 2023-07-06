using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    private Rigidbody2D PlayerRb;
    private Animator Anim;
    public float jump;
    public Transform ATKpnt;
    public float ATKRange = 0.5f;
    public Player1_Health player1_Health;
    public int Damage;
    public LayerMask enemyLayers;
    public Transform Groundcheck;
    public LayerMask GroundLayer;

    private bool isAttacking = false;

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
  

    public void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(ATKpnt.position, ATKRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We Hit" + enemy.name);
            player1_Health.takeDamage(Damage);
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

        //move left and right

        if (Input.GetKey(KeyCode.LeftArrow))
            horizontalInput = -1;
        else if (Input.GetKey(KeyCode.RightArrow))
            horizontalInput = 1;
        else
            horizontalInput = 0;

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            Anim.SetBool("IsMoving2", true);
        }

        else
        {
            Anim.SetBool("IsMoving2", false);
        }

        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightShift))
        {
            Anim.SetTrigger("Jump2");
        }

        if (Input.GetKeyDown(KeyCode.Slash))
        {
            Anim.SetTrigger("LiteATK2");
            Attack();


        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightShift))
        {
            Anim.SetTrigger("UpATK2");
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Anim.SetTrigger("HvyATK2");
            Attack();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Anim.SetTrigger("Shoot2");
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            Anim.SetTrigger("RunShoot2");
        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && IsOnGround())
        {
            PlayerRb.AddForce(new Vector2(PlayerRb.velocity.x, jump));
        }
    }
}
