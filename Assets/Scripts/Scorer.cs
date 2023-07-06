using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        FindObjectOfType<Score>().Scored(score); // Sobald ein Spieler einen Gem eingesammelt hat, dann geht sein Score hoch
    }
}
