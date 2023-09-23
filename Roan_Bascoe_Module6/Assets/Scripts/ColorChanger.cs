using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    private Renderer playerColor;


    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerColor = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.C))
        {
            changeColor();
        }



    }

    void changeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        playerColor.material.color = randomColor;
    }


}
