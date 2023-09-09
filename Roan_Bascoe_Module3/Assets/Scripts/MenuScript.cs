using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public string sceneName;
    public TMP_Text textField;
    public string favoriteGame = "Final Fantasy X";

    void Start()
    {
        textField = GetComponent<TMP_Text>();
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
        }

    }


}
