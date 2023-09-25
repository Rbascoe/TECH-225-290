using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MidtermExercise : MonoBehaviour
{

    public string hobbyName = "Gaming";

    public TextMeshProUGUI hobbyDisplay;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // run when H key is pressed
        if (Input.GetKeyDown(KeyCode.H))
        {
            ProcessText(hobbyName);
        }
    }

    public void ProcessText(string text)
    {
        //Debug.Log("Process Text Method triggered!");

        hobbyDisplay.text = $"My favorite hobby is {text}";

    }
}
