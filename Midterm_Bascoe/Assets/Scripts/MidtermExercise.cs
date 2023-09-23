using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MidtermExercise : MonoBehaviour
{

    public string hobbyName;

    public TextMeshProUGUI hobbyDisplay;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ProcessText("Gaming");
        }
    }

    public void ProcessText(string hobbyName)
    {
        Debug.Log("Process Text Method triggered!");

        hobbyDisplay.text = $"My favorite hobby is {hobbyName}";

    }
}
