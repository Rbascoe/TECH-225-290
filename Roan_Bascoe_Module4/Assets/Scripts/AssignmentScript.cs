using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SearchService;

public class AssignmentScript : MonoBehaviour
{

    public TMP_Text textField;

    public int allCollectibles;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        displayTagAmount("Collectible");
    }


    public void displayTagAmount(string tagName)
    {

        GameObject[] objects = GameObject.FindGameObjectsWithTag(tagName);

        // Debug.Log(objects.Length);

        allCollectibles = objects.Length;

        textField.text = $"Collectibles remaining: {allCollectibles}";

        Debug.Log("Number of Tags Displayed!");

    }
}
