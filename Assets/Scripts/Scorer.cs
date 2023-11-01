using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [HideInInspector] // Versteckt den folgenden Integer
    public int score = 0; // privater Integer mit dem Wert 0 und Namen score
    private int ende = 0; // privater Integer mit dem Wert 0 und Namen score

    public void SetScore(int savedscore) // �ffentliche Funktion
    {
        score = savedscore; // Der Score wird zum gespeicherten Score
    }

    private void OnTriggerEnter(Collider other) // Wird aufgerufen, wenn eine Kollision passiert
    {
        score++; // Der Integer score wird um 1 h�her
        FindObjectOfType<Score>().Scored(score); // Sobald ein Spieler einen Gem eingesammelt hat, geht sein Score hoch; Funktion aus einem anderen Script wird ausgef�hrt
        FindObjectOfType<Player>().GetScore(score); // Sendet die Variable score an das Script Player
        ende++; // Der Integer ende wird um 1 h�her
        FindObjectOfType<Gems>().End(ende); // Funktion aus einem anderen Script wird ausgef�hrt
    }

    public void Finished() // �ffentliche Funktion
    {
        PlayerPrefs.SetInt("Score", score); // Speichert den Score ab
    }
}