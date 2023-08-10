using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Movement : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private int count;
    public MovementJoystick movementJoystick;
    public float playerSpeed = 6f;
    private Rigidbody2D rb;
    
    public GameManager gameManager;

    

    Vector2 movement;

 
    void Update()
    {
        MovementInput();
    }
    void Start()
    {
        count = 0;

        SetCountText();

        rb = GetComponent<Rigidbody2D>();
    }

     void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        float yatay = Input.GetAxis("Horizontal");
        
        Dondur(yatay);
        if (movementJoystick.joystickVec.y != 0)
            {
                rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
            }
            else
            {
                rb.velocity = Vector2.zero;
            }

    }
    private void Dondur(float yatay)
    {
        Vector3 karakterscale = transform.localScale;

        if (yatay > 0)
        {
            karakterscale.x = 2;
        }
        if (yatay < 0)
        {
            karakterscale.x = -2;
        }
        transform.localScale = karakterscale;
    }

    void MovementInput()
    {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector2(mx, my).normalized;
    }

    void SetCountText()
    {
        countText.text = count.ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }

        if (other.gameObject.CompareTag("GreenSquare"))
        {
            gameManager.EndLevel();
        }
    }

    
}
