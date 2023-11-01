using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData : MonoBehaviour
{
    [HideInInspector] // Versteckt den folgenden Integer
    public int level; // Öffentlicher Integer namens level
    [HideInInspector] // Versteckt den folgenden Integer
    public int score1; // Öffentlicher Integer namens score1
    [HideInInspector] // Versteckt den folgenden Integer
    public float[] position; // Öffentliche float Liste namens position

    public PlayerData(Player player) // Öffentliche Funktion
    {
        level = player.level; // level wird vom Spieler abgerufen
        score1 = player.score1; // Der Score wird vom Spieler abgerufen

        position = new float[3]; // position wird eine float Liste mir 3 Komponenten zugewiesen
        position[0] = player.x; // Die erste Zahl der Liste position wird zur X-Koordinate des Spielers 
        position[1] = player.y; // Die zweite Zahl der Liste position wird zur Y-Koordinate des Spielers
        position[2] = player.z; // Die dritte Zahl der Liste position wird zur Z-Koordinate des Spielers
    }
}