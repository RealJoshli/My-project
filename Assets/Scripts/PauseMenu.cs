using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; // Fügt eine Variable hinzu mit dem Boolean false
    public GameObject pauseUI; // Fügt ein GameObject hinzu

    public void Quit() // Öffentliche Funktion
    {
        PlayerPrefs.SetInt("Score", 0); // Score wird auf null gesetzt
        Application.Quit(); // Schliesst die Applikation
    }
    
    public void Menu() // Öffentliche Funktion
    {
        Time.timeScale = 0f; // Pausiert die Zeit
        SceneManager.LoadScene(0); // Wechselt die Szene zur ersten im buildIndex
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Ausgeführt wenn Escape gedrückt
        {
            if (GameIsPaused) // Wenn der Boolean GameIsPaused true ist
            {
                Resume(); // Funktion Resume wird ausgeführt
            }
            else // Wenn der Boolean false ist
            {
                Pause(); // Funkktion Pause wird ausgeführt
            }
        }
    }

    public void Resume() // Öffentliche Funktion
    {
        pauseUI.SetActive(false); // Setzt das GameObject auf inaktive, resp. nicht sichtbar im Spiel
        Time.timeScale = 1.0f; // Setzt die Zeit auf normale Geschwindigkeit
        GameIsPaused = false; // Der Boolean wird auf false gesetzt
    }

    public void Pause() // Öffentliche Funktion
    {
        pauseUI.SetActive(true); // Setzt das GameObject auf aktive, resp. wird im Spiel angezeigt
        Time.timeScale = 0f; // Pausiert die Zeit
        GameIsPaused = true; // Der Boolean wird auf true gesetzt
    }
    
    public void SaveTheGame() // Öffentliche Funktion
    {
        FindObjectOfType<Player>().SavePlayer(); // Löst eine Funktion in einem anderen Script aus, Speichert den Spieler
    }
}