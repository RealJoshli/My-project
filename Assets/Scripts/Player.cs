using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Player: MonoBehaviour
{
    public int movementSpeed; // Erstellt ein �ffentlicher Integer namens movementSpeed
    private Rigidbody rb; // Erstellet einen privaten Rigidbody namens rb
    [HideInInspector] // Versteckt den folgenden Integer
    public float x = 0.5f; // Erstellt ein �ffentlichen float mit dem Wert 0.5 und Namen x
    [HideInInspector] // Versteckt den folgenden Integer
    public float y = 0.5f; // Erstellt ein �ffentlichen float mit dem Wert 0.5 und Namen y
    [HideInInspector] // Versteckt den folgenden Integer
    public float z = 0.5f; // Erstellt ein �ffentlichen float mit dem Wert 0.5 und Namen z
    [HideInInspector] // Versteckt den folgenden Integer
    public int level; // �ffentlicher Integer namens level wird erstellt
    [HideInInspector] // Versteckt den folgenden Integer
    public int score1; // �ffentlicher Integer namens score1 wird erstellt
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // F�gt dem GameObject ein Rigidbody hinzu
        transform.SetPositionAndRotation(new Vector3(0.5f, -14.6f, 0.5f), Quaternion.identity); // Setzt das GameObject an die gew�nschte Anfangsposition
    }

    // Update is called once per frame
    void Update()
    {
        level = SceneManager.GetActiveScene().buildIndex; // Das level ist die aktuelle Szene als Wert im buildIndex
        x = transform.position.x; // Gibt dem float x den Wert der x-Koordinate
        y = transform.position.y; // Gibt dem float y den Wert der y-Koordinate
        z = transform.position.z; // Gibt dem float z den Wert der z-Koordinate
        FindObjectOfType<PMiniMap>().SetCoordinates(x, y, z); // Die Koordinaten des Spielers werden an den Spieler der Mini-Map geschickt
        FindObjectOfType<CameraFollow>().FollowCoordinates(x, y, z); // Gibt die Koordinaten an ein anderes Script weiter

        if (Input.GetKey(KeyCode.W)) // F�hrt Befehl aus sobald die Taste W gedr�ckt wird
        {
            rb.AddRelativeForce(new Vector3(0.0f,0.0f, movementSpeed)); // Kraft nach vorne, vom GameObject aus gesehen
        }
        if (Input.GetKey(KeyCode.S)) // F�hrt Befehl aus sobald die Taste S gedr�ckt wird
        {
            rb.AddRelativeForce(new Vector3(0.0f, 0.0f, -movementSpeed)); // Kraft nach hinten
        }
        if (Input.GetKey(KeyCode.A)) // F�hrt Befehl aus sobald die Taste A gedr�ckt wird
        {
            rb.AddRelativeForce(new Vector3(-movementSpeed, 0.0f, 0.0f)); // Kraft nach links
        }
        if (Input.GetKey(KeyCode.D)) // F�hrt Befehl aus sobald die Taste D gedr�ckt wird
        {
            rb.AddRelativeForce(new Vector3(movementSpeed, 0.0f, 0.0f)); // Kraft nach rechts
        }
        if (Input.GetKeyDown(KeyCode.Space)) // F�hrt Befehl aus sobald die Leertaste gedr�ckt wird
        {
            if (transform.position.y < -6) // Beschr�nkt den Bereich in dem dieser Befehl ausgef�hrt wird
            {
                rb.transform.position = rb.transform.position + new Vector3(0, 1f, 0); // Eine Ebene h�her
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) // F�hrt Befehl aus sobald die Shift-Taste gedr�ckt wird
        {
            if (transform.position.y > -14) // Beschr�nkt den Bereich in dem dieser Befehl ausgef�hrt wird
            {
                rb.transform.position = rb.transform.position + new Vector3(0, -1f, 0); // Eine Ebene tiefer
            }
        }
        if (Input.GetKeyDown(KeyCode.E)) // F�hrt Befehl aus sobald die Taste E gedr�ckt wird
        {
            if (transform.position.x < 98.5f) // Beschr�nkt den Bereich in dem dieser Befehl ausgef�hrt wird
            {
                rb.transform.position = rb.transform.position + new Vector3(11f, 0, 0); // Ein Schritt vorw�rts in der 4. Dimension
            }
        }
        if (Input.GetKeyDown(KeyCode.Q)) // F�hrt Befehl aus sobald die Taste Q gedr�ckt wird
        {
            if (transform.position.x > 10.5f) // Beschr�nkt den Bereich in dem dieser Befehl ausgef�hrt wird
            {
                rb.transform.position = rb.transform.position + new Vector3(-11f, 0, 0); // Ein Schritt r�ckw�rts in der 4. Dimension
            }
        }
    }

    public void GetScore(int actualscore) // �ffentliche Funktion mit einem Integer als Input
    {
        score1 = actualscore; // der Score wird aktualisiert
    }

    public void SavePlayer() // �ffentliche Funktion
    {
        SaveSystem.SavePlayer(this); // Dieser Spieler wird gespeichert
    }

    public void LoadPlayer() // �ffentliche Funktion
    {
        PlayerData data = SaveSystem.LoadPlayer(); // Die Daten werden abgerufen und auf "data" gespeichert

        level = data.level; // Level wird aus Speicherstand geladen
        score1 = data.score1; // Der Score wird aus dem Speicherstand geladen

        Vector3 position; // Ein dreidimensionaler Vektor wird erstellt namens position
        position.x = data.position[0]; // Die X-Koordinate wird aus dem Speicherstand abgerufen
        position.y = data.position[1]; // Die Y-Koordinate wird aus dem Speicherstand abgerufen
        position.z = data.position[2]; // Die Z-Koordinate wird aus dem Speicherstand abgerufen
        transform.position = position; // Die Position wird auf die abgerufene position gesetzt
        FindObjectOfType<Scorer>().SetScore(score1); // Funktion in einem anderen Script wird ausgef�ht mit dem eingegebenen Wert "score1"
        SceneManager.LoadScene(level); // L�dt die gespeicherte Szene
        FindObjectOfType<PauseMenu>().Pause(); // Funktion in einem anderen Script wird ausgel�st, das Spiel wird pausiert
    }
}