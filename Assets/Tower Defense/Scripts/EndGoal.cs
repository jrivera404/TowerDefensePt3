using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Lost!");
        PlayerPrefs.SetString("Win/Loss", "You lost!");
        SceneManager.LoadScene(2);
    }
}
