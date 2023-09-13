using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private GameObject player;

    public float objectSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        moveForwardBack();
        moveLeftRight();
    }

    public void moveForwardBack()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * verticalInput;

        transform.Translate(moveDirection * objectSpeed * Time.deltaTime);
    }

    public void moveLeftRight()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 moveDirection = transform.right * horizontalInput;

        transform.Translate(moveDirection * objectSpeed * Time.deltaTime);
    }

}
