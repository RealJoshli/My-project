using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScore : MonoBehaviour
{
    public TMP_Text tMP_Text;
    
    // Start is called before the first frame update
    public void SetTheScore(int score) // Öffentliche Funktion
    {
        tMP_Text = GetComponent<TMP_Text>(); // Eine Komponente wird dem Objekt zugewiesen
        tMP_Text.text = score.ToString(); // Der Score wird in Text umgewandelt und ausgeschrieben
    }
}
