using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    public GameObject player;
    public float playerSpeed = 20.0f;
    public float turnSpeed = 40.0f;

    int ammo = 7;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    public void movePlayer()
    {

        float vertMovement = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * vertMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
