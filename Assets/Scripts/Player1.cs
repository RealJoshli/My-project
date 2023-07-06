using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Player1: MonoBehaviour
{
    public int movementSpeed;
    private Rigidbody rb;
    private float x = 0.5f;
    private float y = 0.5f;
    private float z = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        FindObjectOfType<PMiniMap>().setCoordinates(x, y, z); // Die Koordinaten des Spielers werden an den Spieler der Mini-Map geschickt

        if (Input.GetKey(KeyCode.W)) // Kraft nach vorne
        {
            rb.AddRelativeForce(new Vector3(0.0f,0.0f, movementSpeed));
        }
        if (Input.GetKey(KeyCode.S)) // Kraft nach hinten
        {
            rb.AddRelativeForce(new Vector3(0.0f, 0.0f, -movementSpeed));
        }
        if (Input.GetKey(KeyCode.A)) // Kraft nach links
        {
            rb.AddRelativeForce(new Vector3(-movementSpeed, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.D)) // Kraft nach rechts
        {
            rb.AddRelativeForce(new Vector3(movementSpeed, 0.0f, 0.0f));
        }
        if (Input.GetKeyDown(KeyCode.Space)) // Eine Ebene höher
        {
            if (transform.position.y < -6)
            {
                rb.transform.position = rb.transform.position + new Vector3(0, 1, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) // Eine Ebene tiefer
        {
            if (transform.position.y > -14)
            {
                rb.transform.position = rb.transform.position + new Vector3(0, -1, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.E)) // Ein Schritt vorwärts in der 4. Dimension
        {
            if (transform.position.x < 98.5f)
            {
                rb.transform.position = rb.transform.position + new Vector3(11, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q)) // Ein Schritt rückwärts in der 4. Dimension
        {
            if (transform.position.x > 10.5f)
            {
                rb.transform.position = rb.transform.position + new Vector3(-11, 0, 0);
            }
        }
    }
}
