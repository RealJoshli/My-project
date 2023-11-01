using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TMP_Text m_TextComponent; // Erstellt eine private Variable

    public void Scored(int score) // Öffentliche Funktion mit der Eingabe eines Integers namens score
    {
        m_TextComponent = GetComponent<TMP_Text>(); // Komponente wird zugewiesen
        m_TextComponent.text = score.ToString(); // Score wird zu Text konvertiert und ausgeschrieben
    }
}