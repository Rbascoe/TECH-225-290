using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class FinalExamCode : MonoBehaviour
{

    public TextMeshProUGUI textField;
    string[] favMovies = { "The Lion King", "John Wick", "Forest Gump" };

    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        DisplayMovies();
        for (int num = 5; num <= 640; num = num * 2)
        {
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            sceneName = "Game";
            SceneManager.LoadScene(sceneName);
            Debug.Log("Game Scene Loaded successfully");
        }
    }

    public void DisplayMovies()
    {

        textField.text = string.Join("\n\n", favMovies);

    }
}
