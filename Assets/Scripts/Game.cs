using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public void PlayGame() // Ein �ffentlicher Begehl
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // wechselt die Szene zur n�chsten, im Build-Index 1 h�here Stufe
    }

    public void QuitGame() // Ein �ffentlicher Begehl
    {
        PlayerPrefs.SetInt("Score", 0); // Der Score wird auf null gesetzt
        Application.Quit(); // Die Applikation schliesst sich
    }
}