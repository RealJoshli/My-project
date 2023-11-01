using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PMiniMap : MonoBehaviour
{
    public GameObject PMM; // Öffentliches GameObject wird hinzugefügt
    public void SetCoordinates(float x, float y, float z) // Öffentliche Funktion mit den Eingaben float x, y und z
    {
        transform.position = new Vector3(x, 0.4f, (y + 14.6f) * 11 + z); // Die Position wird an die des Spielers angepasst
    }

    public void SetRotation(Vector2 turn) // Öffentliche Funktion
    {
        PMM.transform.localRotation = Quaternion.Euler(0, turn.x, 0); // Die Bewegung der Maus wir in Rotation des Spielers übertragen
    }
}