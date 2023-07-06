using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    public GameObject Gem;

    // Start is called before the first frame update
    void Start()
    {
        for (int u = 0; u < 10; u++) // Die Gems werden auf jedem Feld verteilt
        {
            for (int v = 0; v < 10; v++)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        Instantiate(Gem, new Vector3(x + 0.5f + (11 * u), v - 14.5f, z + 0.5f), Quaternion.identity); // In den Würfeln
                        Instantiate(Gem, new Vector3(x + 0.5f + (11 * u), 0.5f, z + 0.5f + (11 * v)), Quaternion.identity); // Auf den Mini-Map
                    }
                }
            }
        }
    }
}
