using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject WallPiece; // F�gt ein �ffentliches GameObject hinzu
    public GameObject WallPiece2; // F�gt ein �ffentliches GameObject hinzu
    public GameObject Floor; // F�gt ein �ffentliches GameObject hinzu
    public GameObject Floor2; // F�gt ein �ffentliches GameObject hinzu
    private int prob;
    private int t = 1;
    private int j = 1;
    private int k = 1;
    private int a = 1;
    private int c = 1;

    // Start is called before the first frame update
    void Start()
    {
        // B�den
        for (int x = 0; x < 10; x++) // Wird ausgef�hrt solange x kleiner als 10 ist und setzt x jede Runde um 1 h�her
        {
            for (int z = 0; z < 10; z++)
            {
                if (t > 0)
                {
                    Instantiate(Floor, new Vector3(((11 * x) + 5), 0, ((z * 11) + 5)), Quaternion.identity); // Boden wird in der Mini-Map platziert
                    Instantiate(Floor, new Vector3(((11 * x) + 5), (z - 15), 5), Quaternion.identity); // Boden wir platziert
                }
                else // F�r Abwechslung wird jeder W�rfel anders gef�rbt
                {
                    Instantiate(Floor2, new Vector3(((11 * x) + 5), 0, ((z * 11) + 5)), Quaternion.identity); // Minimap
                    Instantiate(Floor2, new Vector3(((11 * x) + 5), (z - 15), 5), Quaternion.identity); // Map
                }
            }
            if (t > 0) 
            {
                Instantiate(Floor, new Vector3(((11 * x) + 5), -5, 5), Quaternion.identity); // Die Decke der W�rfel
            }
            else 
            {
                Instantiate(Floor2, new Vector3(((11 * x) + 5), -5, 5), Quaternion.identity); // Zweite Decke in einer anderen Farbe
            }
            t *= -1;
        }

        // Aussenw�nde
        for (int u = 0; u < 10; u++)
        {
            if (j > 0)
            {
                for (int v = 0; v < 2; v++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            Instantiate(WallPiece, new Vector3(((x + 0.5f) + (11 * u)), 0.5f, ((z * 11) + (v * 10))), Quaternion.identity); // F�r die Mini-Map
                            Instantiate(WallPiece, new Vector3(((x + 0.5f) + (11 * u)), (z - 14.5f), (10 * v)), Quaternion.identity); // F�r den W�rfel
                        }
                    }
                }
            }
            else // Mit einer anderen Farbe
            {
                for (int v = 0; v < 2; v++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            Instantiate(WallPiece2, new Vector3(((x + 0.5f) + (11 * u)), 0.5f, ((z * 11) + (v * 10))), Quaternion.identity); // F�r die Mini-Map
                            Instantiate(WallPiece2, new Vector3(((x + 0.5f) + (11 * u)), (z - 14.5f), (10 * v)), Quaternion.identity); // F�r den W�rfel
                        }
                    }
                }
            }
            j *= -1;
        }
        for (int x = 0; x < 10; x++) // Um 90� gedreht
        {
            if (k > 0)
            {
                for (int v = 0; v < 2; v++)
                {
                    for (int u = 0; u < 10; u++)
                    {
                        for (int z = 0; z < 10; z++)
                        {
                            Instantiate(WallPiece, new Vector3(((x * 11) + (10 * v)), 0.5f, ((z + 0.5f) + (11 * u))), Quaternion.Euler(0, 90, 0)); // F�r die Mini-Map
                            Instantiate(WallPiece, new Vector3(((v * 10) + (11 * x)), (u - 14.5f), (z + 0.5f)), Quaternion.Euler(0, 90, 0)); // F�r den W�rfel
                        }
                    }
                }
            }
            else // Mit einer anderen Farbe
            {
                for (int v = 0; v < 2; v++)
                {
                    for (int u = 0; u < 10; u++)
                    {
                        for (int z = 0; z < 10; z++)
                        {
                            Instantiate(WallPiece2, new Vector3(((x * 11) + (10 * v)), 0.5f, ((z + 0.5f) + (11 * u))), Quaternion.Euler(0, 90, 0)); // F�r die Mini-Map
                            Instantiate(WallPiece2, new Vector3(((v * 10) + (11 * x)), (u - 14.5f), (z + 0.5f)), Quaternion.Euler(0, 90, 0)); // F�r den W�rfel
                        }
                    }
                }
            }
            k *= -1;
        }

        // Innenw�nde
        for (int u = 0; u < 10; u++)
        {
            if (a > 0)
            {
                for (int v = 0; v < 10; v++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        for (int z = 0; z < 10; z++)
                        {
                            prob = UnityEngine.Random.Range(1, 3); // eine zuf�llige Zahle von 1 - 2 wird generiert und auf die Variable prob abgespeichert
                            if (prob == 1)
                            {
                                Instantiate(WallPiece, new Vector3(((x + 0.5f) + (11 * u)), 0.5f, (z + (11 * v))), Quaternion.identity); // F�r die Mini-Map
                                Instantiate(WallPiece, new Vector3(((x + 0.5f) + (11 * u)), (v - 14.5f), z), Quaternion.identity); // F�r den W�rfel
                            }
                        }
                    }
                }
            }
            else // Mit einer anderen Farbe
            {
                for (int v = 0; v < 10; v++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        for (int z = 0; z < 10; z++)
                        {
                            prob = UnityEngine.Random.Range(1, 3); // eine zuf�llige Zahle von 1 - 2 wird generiert und auf die Variable prob abgespeichert
                            if (prob == 1)
                            {
                                Instantiate(WallPiece2, new Vector3(((x + 0.5f) + (11 * u)), 0.5f, (z + (11 * v))), Quaternion.identity); // F�r die Mini-Map
                                Instantiate(WallPiece2, new Vector3(((x + 0.5f) + (11 * u)), (v - 14.5f), z), Quaternion.identity); // F�r den W�rfel
                            }
                        }
                    }
                }
            }
            a *= -1;
        }
        for (int u = 0; u < 10; u++) // Um 90� gedreht
        {
            if (c > 0)
            {
                for (int v = 0; v < 10; v++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        for (int z = 0; z < 10; z++)
                        {
                            prob = UnityEngine.Random.Range(1, 3); // eine zuf�llige Zahle von 1 - 2 wird generiert und auf die Variable prob abgespeichert
                            if (prob == 1)
                            {
                                Instantiate(WallPiece, new Vector3(((x + 1) + (11 * u)), 0.5f, ((z + 0.5f) + (11 * v))), Quaternion.Euler(0, 90, 0)); // F�r die Mini-Map
                                Instantiate(WallPiece, new Vector3(((x + 1) + (11 * u)), (v - 14.5f), (z + 0.5f)), Quaternion.Euler(0, 90, 0)); // F�r den W�rfel
                            }
                        }
                    }
                }
            }
            else // Mit einer anderen Farbe
            {
                for (int v = 0; v < 10; v++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        for (int z = 0; z < 10; z++)
                        {
                            prob = UnityEngine.Random.Range(1, 3); // eine zuf�llige Zahle von 1 - 2 wird generiert und auf die Variable prob abgespeichert
                            if (prob == 1)
                            {
                                Instantiate(WallPiece2, new Vector3(((x + 1) + (11 * u)), 0.5f, ((z + 0.5f) + (11 * v))), Quaternion.Euler(0, 90, 0)); // F�r die Mini-Map
                                Instantiate(WallPiece2, new Vector3(((x + 1) + (11 * u)), (v - 14.5f), (z + 0.5f)), Quaternion.Euler(0, 90, 0)); // F�r den W�rfel
                            }
                        }
                    }
                }
            }
            c *= -1;
        }
    }
}