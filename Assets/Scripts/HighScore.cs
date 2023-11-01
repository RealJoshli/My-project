using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScore : MonoBehaviour
{
    public TMP_Text tmpHighScore; // Text Komponent wird hinzugefügt
    private int score; // Privater Integer

    void Awake() // Ausgeführt wenn aktiviert
    {
        score = PlayerPrefs.GetInt("Score", 0); // Der Score wird abgerufen
        if (score > PlayerPrefs.GetInt("HighScore", 0)) // Wenn erzielter Score höher ist als gespeicherter HighScore
        {
            tmpHighScore = GetComponent<TMP_Text>(); // Komponente wird zugewiesen
            tmpHighScore.text = score.ToString(); //score wird als Text geschrieben
            PlayerPrefs.SetInt("HighScore", score); // Der HighScore bekommt einen neuen Wert
        }
    }

    private void Update()
    {
        if (gameObject.activeInHierarchy) // Wenn das GameObject aktiviert ist
        {
            tmpHighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); // Der Highscore wird gesetzt
        }
    }
}