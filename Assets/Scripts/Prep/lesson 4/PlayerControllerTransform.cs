using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTransform : MonoBehaviour
{
    //reference variables
    public Transform playerTransform;

    //input control variables
    public bool leftArrowPressed = false;
    public bool rightArrowPressed = false;
    public bool upArrowPressed = false;
    public bool downArrowPressed = false;

    //
    public float speed = 10f;
    //

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        leftArrowPressed = Input.GetKey(KeyCode.LeftArrow);
        rightArrowPressed = Input.GetKey(KeyCode.RightArrow);
        upArrowPressed = Input.GetKey(KeyCode.UpArrow);
        downArrowPressed = Input.GetKey(KeyCode.DownArrow);

        if (leftArrowPressed)
        {
            playerTransform.position = new Vector3(playerTransform.position.x - (speed / 1000), playerTransform.position.y, playerTransform.position.z);

        }
        else if (rightArrowPressed)
        {
            playerTransform.position = new Vector3(playerTransform.position.x + (speed / 1000), playerTransform.position.y, playerTransform.position.z);
        }
        else if (upArrowPressed)
        {
            playerTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y + (speed / 1000), playerTransform.position.z);
        }
        else if (downArrowPressed)
        {
            playerTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y - (speed / 1000), playerTransform.position.z);
        }
    }
}
