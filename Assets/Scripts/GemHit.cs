using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Sobald der Spieler den Gem ber�hrt, ist er weg, um ein Einsammeln zu simulieren
    }
}
