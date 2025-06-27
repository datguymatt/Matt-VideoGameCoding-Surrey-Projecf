using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRigidbody : MonoBehaviour
{
    //reference variables
    private Rigidbody2D rb;

    //input controls
    private bool leftArrowPressed = false;
    private bool rightArrowPressed = false;
    private bool upArrowPressed = false;
    private bool downArrowPressed = false;
    //


    [SerializeField] private float movementVelocity = 15f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //input monitoring
        rightArrowPressed = Input.GetKey(KeyCode.RightArrow);
        leftArrowPressed = Input.GetKey(KeyCode.LeftArrow);
        downArrowPressed = Input.GetKey(KeyCode.DownArrow);
        upArrowPressed = Input.GetKey(KeyCode.UpArrow);
    }

    private void FixedUpdate()
    {
        //apply physics force
        if (rightArrowPressed)
        {
            rb.velocity = new Vector2(movementVelocity, 0);

        } else if (leftArrowPressed)
        {
            rb.velocity = new Vector2(-movementVelocity, 0);

        } else if (downArrowPressed) 
        {
            rb.velocity = new Vector2(0, -movementVelocity);

        } else if (upArrowPressed)
        {
            rb.velocity = new Vector2(0, movementVelocity);

        } else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
