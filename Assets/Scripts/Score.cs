using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TMP_Text m_TextComponent;

    public void Scored(int score)
    {
        m_TextComponent = GetComponent<TMP_Text>();
        m_TextComponent.text = score.ToString();
    }
}