using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector2 turn; // Ein �ffentlicher, zweidimensionaler Vektor names turn wird erstellt
    public float sensitivity = .5f; // Eine �ffentliche Variable names sensitivity wird mit dem Wert float 0.5 erstellt
    public GameObject Player1; // Ein �ffentliches GameObject wird hinzugef�gt
    private int i = 1; // Ein �ffentlicher Integer mit Wert 1 wird erstellt

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; // Der Cursor wird hiermit auf das Spielfenster limitiert
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity; // Die Bewegung der Maus wir gespeichert
        Player1.transform.localRotation = Quaternion.Euler(0, turn.x, 0); // Die Bewegung der Maus wir in Rotation des Spielers �bertragen
        FindObjectOfType<PMiniMap>().SetRotation(turn); // Funktion eines anderen Scripts wird ausgef�hrt

        if (Input.GetKeyDown(KeyCode.L)) // Bei Taste L gedr�ckt
        {
            if (i == 1)
            {
                Cursor.lockState = CursorLockMode.Confined; // Der Cursor wird hiermit auf das Spielfenster limitiert
                i++;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked; // Der Cursor wird gesperrt und unsichtbar, die Bewegung wird immer noch aufgezeichnet
                i--;
            }
        }
    }
}