using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gems : MonoBehaviour
{
    public GameObject Gem; // Öffentliches GameObject

    // Start is called before the first frame update
    void Start()
    {
        for (int u = 0; u < 10; u++) // Die Gems werden auf jedem Feld verteilt und dies in vier Dimensionen, Bereich (0 - 9)
        {
            for (int v = 0; v < 10; v++) 
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        Instantiate(Gem, new Vector3(x + 0.5f + (11 * u), v - 14.8f, z + 0.5f), Quaternion.identity); // In den Würfeln
                        Instantiate(Gem, new Vector3(x + 0.5f + (11 * u), 0.2f, z + 0.5f + (11 * v)), Quaternion.identity); // Auf der Mini-Map
                    }
                }
            }
        }
    }

    public void End(int ende) // Öffentliche Funktion
    {
        if (ende == 10000) // Wenn Variable ende gleich 10000
        {
            Time.timeScale = 0f; // Zeit wird angehalten
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Szene geht zur nächsten, im buildIndex 1 höher
            FindObjectOfType<Scorer>().Finished(); // Funktion aus einem anderen Script wird ausgeführt
        }
    }
}