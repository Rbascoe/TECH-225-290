using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer("Vertical");
        movePlayer("Horizontal");
    }

    void movePlayer(string direction)
    {

        Vector3 moveDirection;
        float directionalInput = Input.GetAxis(direction);

        switch (direction)
        {
            case "Vertical":
                moveDirection = transform.forward * directionalInput;
                break;
            case "Horizontal":
                moveDirection = transform.right * directionalInput;
                break;
            case "Turn Right":
                if (Input.GetKey(KeyCode.M))
                {
                    transform.Rotate(Vector3.forward * playerSpeed * Time.deltaTime);

                }
                break;
            case "Turn Left":
                if (Input.GetKey(KeyCode.N))
                {
                    transform.Rotate(Vector3.forward * playerSpeed * Time.deltaTime);

                }
                break;
            default:
                Debug.Log("");
                break;

        }

        // Input.GetKey(KeyCode.M)
        // if (direction == "Vertical")
        // {
        //     moveDirection = transform.forward * directionalInput;

        // }
        // else if(direction == "Vertical")
        // {
        //     moveDirection = transform.right * directionalInput;

        // }

        // transform.Translate(moveDirection * playerSpeed * Time.deltaTime);
        //transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    void movePlayerBack()
    {

    }

    void turnPlayer()
    {

    }

}
