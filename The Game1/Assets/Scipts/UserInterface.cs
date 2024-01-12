using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UserInterface : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void homescreen()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    private int[] levelOrder = { 4, 1, 4, 2, 4, 3 }; // Define the order of levels
    private int currentLevelIndex = 1; // Index of the current level

    public void LevelAdvance()
    {
        // Load the next level in the predefined order
        int nextSceneIndex = levelOrder[currentLevelIndex];

        // Load the next scene
        SceneManager.LoadScene(nextSceneIndex);

        // Update the current level index for the next button click
        currentLevelIndex = (currentLevelIndex + 1) % levelOrder.Length;
    }
        public void home()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void level1()
    {
        SceneManager.LoadScene("Game");
    }
    public void level2()
    {
        SceneManager.LoadScene("Level 1");
    }



}

