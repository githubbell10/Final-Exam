using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenes : MonoBehaviour

{
    public void GoTo1Intro()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void GoTo2HighScores()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void GoTo3Game()
    {
        SceneManager.LoadScene("3Game");
    }

    public void GoTo4Exit()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
