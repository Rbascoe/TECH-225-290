using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public string sceneName;
    public TMP_Text textField;
    public string initialText;
    public string favoriteGame = "Final Fantasy X";

    void Awake()
    {
        textField = GetComponent<TMP_Text>();
        initialText = textField.ToString();
        initialText = "Press 'F' Key";
        textField.text = initialText;
    }

    void Update()
    {
        UpdateTextField();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Play Button Pushed!");
    }

    public void UpdateTextField()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            textField.text = favoriteGame;
            Debug.Log("Text Field Updated!");
        }


    }


}
