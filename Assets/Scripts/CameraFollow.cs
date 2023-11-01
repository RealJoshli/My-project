using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public void FollowCoordinates(float x, float y, float z) // Öffentliche Funktion mit den Eingaben float x, y und z
    {
        transform.position = new Vector3(x, 5.4f, (y + 14.6f) * 11 + z); // Die Position wird an die des Spielers angepasst
    }
}
