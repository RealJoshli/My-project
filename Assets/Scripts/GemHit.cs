using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // Ausgelöst durch Kollision
    {
        //Play sound (WIP)
        Destroy(gameObject); // Sobald der Spieler den Gem berührt, ist er weg, um ein Einsammeln zu simulieren
    }
}