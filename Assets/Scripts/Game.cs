using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public void PlayGame() // Ein öffentlicher Begehl
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // wechselt die Szene zur nächsten, im Build-Index 1 höhere Stufe
    }

    public void QuitGame() // Ein öffentlicher Begehl
    {
        PlayerPrefs.SetInt("Score", 0); // Der Score wird auf null gesetzt
        Application.Quit(); // Die Applikation schliesst sich
    }
}