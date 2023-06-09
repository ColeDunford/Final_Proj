using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    private Rigidbody2D PlayerRb;
    private Animation PlayerAnimator;
    public float jump;
    public float movemetTest;
    public AnimationClip RunClip, IdleClip;
    bool canStart = true, canStop = true;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        movemetTest = Input.GetAxisRaw("Horizontal");
        //move left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if ((Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") < 0) && canStart) { canStart = false; canStop = true; PlayerAnimator.Stop(); PlayerAnimator.clip = (RunClip); PlayerAnimator.Play(); }
        else if (Input.GetAxisRaw("Horizontal") == 0 && canStart) { canStop = false; canStart = true; PlayerAnimator.Stop(); PlayerAnimator.clip = (IdleClip); PlayerAnimator.Play(); }

       
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerRb.AddForce(new Vector2(PlayerRb.velocity.x, jump));
        }
    }

}
