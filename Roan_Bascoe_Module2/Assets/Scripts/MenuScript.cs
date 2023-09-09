using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public string sceneName;
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Play Button Pushed!");
    }

}
