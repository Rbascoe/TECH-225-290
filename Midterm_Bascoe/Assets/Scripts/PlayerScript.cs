using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{

    private GameObject player;

    //public TextMeshProUGUI healthDisplay;

    public TMP_Text healthDisplay;
    public float playerSpeed = 10.0f;
    public float turnSpeed = 40.0f;

    public int PlayerHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        healthDisplay = GameObject.Find("playerHealth").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        movePlayer();
        turnPlayer();
        displayHealth();
    }

    public void movePlayer()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * verticalInput;

        transform.Translate(moveDirection * playerSpeed * Time.deltaTime);

        //Debug.Log("Player is Moving!");
    }

    public void turnPlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float rotationAmount = horizontalInput * turnSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up * rotationAmount);

        //Debug.Log("Player is turning!");
    }

    public void displayHealth()
    {
        // converts player health to a string to be displayed in text field
        string remainingHealth = PlayerHealth.ToString();
        healthDisplay.text = $"Health: {remainingHealth}";
        Debug.Log(remainingHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        // run when objects with Danger tag are hit
        if (other.CompareTag("Danger"))
        {
            PlayerHealth -= 20;
            //Debug.Log(PlayerHealth);
            Debug.Log("Enemy Hit");
        }
    }
}
