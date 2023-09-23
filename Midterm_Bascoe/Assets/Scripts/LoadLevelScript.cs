using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevelScript : MonoBehaviour
{

    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame()
    {
        //Hardcoding for this exercise
        sceneName = "Game";

        // Loads the desired scene based on the string value of sceneName
        SceneManager.LoadScene(sceneName);

        // Will confirm function is being hit on click
        Debug.Log("Game has Started!");
    }

}
