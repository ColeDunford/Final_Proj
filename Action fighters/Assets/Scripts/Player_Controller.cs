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
    public Transform ATKpnt;
    public float ATKRange = 0.5f;
    public LayerMask enemyLayers;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    void Attack()
    {

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(ATKpnt.position, ATKRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We Hit" + enemy.name);

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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S))
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
            Attack();

        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            Anim.SetTrigger("UpATK");
            Attack();
        }

         if (Input.GetKey(KeyCode.E))
        {
            Anim.SetTrigger("HvyATK");
            Attack();
        }

         if (Input.GetKey(KeyCode.S))
        {
            Anim.SetTrigger("Shoot");
        }

         if (Input.GetKey(KeyCode.A ) || Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            Anim.SetTrigger("RunShoot");
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerRb.AddForce(new Vector2(PlayerRb.velocity.x, jump));
        }

       



    }

}
