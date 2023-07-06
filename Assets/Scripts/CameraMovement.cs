using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject Player1;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Der Cursor wird hiermit gesperrt, also man kann ihn nicht bewegen, jedoch kann die Bewegung immer noch registriert werden
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity; // Die Bewegung der Maus wir gespeichert
        Player1.transform.localRotation = Quaternion.Euler(0, turn.x, 0); // Die Bewegung der Maus wir in Bewegung des Spielers übertragen
        deltaMove = speed * Time.deltaTime * new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }
}
