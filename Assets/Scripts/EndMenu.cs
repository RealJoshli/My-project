using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject newHS; // Öffentliches GameObject wird hinzugefügt
    private int score1; // Privater Integer mit namen score1
    
    public void QuitButton() // Öffentliche Funktion
    {
        PlayerPrefs.SetInt("Score", 0); // Der Score wird auf null gesetzt
        Application.Quit(); // Schliesst die Applikation
    }

    public void HomeButton() // Öffentliche Funktion
    {
        SceneManager.LoadScene(0); // Lädt die erste Szene im BuildIndex
    }

    // Start is called before the first frame update
    void Start()
    {
        score1 = PlayerPrefs.GetInt("Score", 0); // Der score wird abgerufen
        FindObjectOfType<EndScore>().SetTheScore(score1); // Löst eine Funktion in einem anderen Script aus
        if (score1 > PlayerPrefs.GetInt("HighScore", 0)) // Falls neuer HighScore erzielt
        {
            newHS.SetActive(true); // Das GameObject wird eingeblendet
        }
    }
}