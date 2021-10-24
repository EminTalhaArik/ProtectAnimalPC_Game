using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    public float speed;

    public float JumpPower = 1f;

    public bool isGrounded;

    public Transform checkGroundPosition;
    public float checkGroundRadios;
    public LayerMask checkGroundLayer;

    private Animator myAnimator;

    public int jumpCount;

    public Joystick joystick;
    float joyX;

    public AudioSource jumpSound;
    public AudioSource potionSound;
    public AudioSource spikeSound;
    public AudioSource destroyerPlatformSound;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        //joystick = GameObject.Find("FixedJoystick").GetComponent<FixedJoystick>();
        
    }

    void Update()
    {
        onGroundChecked();

        Move();

        //Masaüstü
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        
    }
    
    public void Jump()
    {

        if (isGrounded || jumpCount < 1)
        {
            myAnimator.SetBool("isJump", true);
            myRigidbody.AddForce(new Vector2(0f, JumpPower));
            jumpSoundPlay();
            jumpCount++;
        }
        
    }

    private void Move()
    {
        // Masaüstü
        float moveInput = Input.GetAxis("Horizontal");

        if (moveInput < 0)
        {
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (moveInput > 0)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        myAnimator.SetFloat("playerSpeed", Math.Abs(moveInput));

        myRigidbody.velocity = new Vector2(moveInput * speed, myRigidbody.velocity.y);

        //Mobil

        //joyX = joystick.Horizontal;

        //if (joyX < 0)
        //{
        //    this.transform.rotation = Quaternion.Euler(0, 180, 0);
        //}else if(joyX > 0)
        //{
        //    this.transform.rotation = Quaternion.Euler(0, 0, 0);
        //}

        //myAnimator.SetFloat("playerSpeed", Math.Abs(joyX));
        //myRigidbody.velocity = new Vector2(joyX * speed, myRigidbody.velocity.y);

    }

    void onGroundChecked()
    {
        isGrounded = Physics2D.OverlapCircle(checkGroundPosition.position, checkGroundRadios, checkGroundLayer);
        if (isGrounded)
        {
            myAnimator.SetBool("isJump", false);
            jumpCount = 0;
        }
    }

    public void potionSoundPlay()
    {
        potionSound.Play();
    }

    public void spikeSoundPlay()
    {
        spikeSound.Play();
    }

    public void jumpSoundPlay()
    {
        jumpSound.Play();
    }
    
    public void destroyerPlatformSoundPlay()
    {
        destroyerPlatformSound.Play();
    }
    
    public void scoreDeleterPlatformSoundPlay()
    {
        spikeSound.Play();
    }
}
