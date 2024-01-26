using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadToScenes : MonoBehaviour
{
    public float timerDuration = 5f; // The duration of the timer in seconds
    public int sceneToLoad = 1;

    private void Start()
    {
        StartCoroutine(StartTimer()); // Start the timer coroutine
    }

    private System.Collections.IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(timerDuration); // Wait for the specified duration

        LoadNextScene(); // Call the function to load the next scene
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Load the specified scene
    }
}
