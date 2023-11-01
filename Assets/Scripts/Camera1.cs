using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Camera1 : MonoBehaviour
{
    public NavMeshAgent agent; // Öffentlicher NavMesh Agent
    public GameObject enemy; // Öffentliches GameObject
    private readonly float speed = 1f; // Privat float (kann nur gelesen werden und nicht verändert)
    private bool walkedRight = false; // Privater Boolean der auf false gesetzt ist
    private bool walkedLeft = false; // Privater Boolean der auf false gesetzt ist
    private bool walkedUp = false; // Privater Boolean der auf false gesetzt ist
    private bool walkedDown = false; // Privater Boolean der auf false gesetzt ist
    private bool walking = false; // Privater Boolean der auf false gesetzt ist

    public void Walk() // Öffentliche Funktion namens Walk
    {
        float x = transform.position.x; // Float mit dem Namen x
        float y = transform.position.y; // Float mit dem Namen y
        float z = transform.position.z; // Float mit dem Namen z
        transform.rotation = Quaternion.Euler(0f, 0f, 0f); // Rotation des Objekts wird auf Null gesetzt

        int r = Random.Range(0, 10); // Eine zufällige Zahl wird auf den Integer r gespeichert
        walking = true; // sezt den Boolean walking auf true
        print(r); // schreibt die Zahl r in der Konsole von Unity
        if (r == 0 || r == 6) // Wird ausgeführt wenn r 0 oder 6 ist
        {
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed) && !walkedUp) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed) && !walkedRight) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed) && !walkedLeft) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed) && !walkedDown) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
            }
        }
        if (r == 1 || r == 7) // Wird ausgeführt wenn r 1 oder 7 ist
        {
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed) && !walkedRight) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed) && !walkedLeft) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed) && !walkedDown) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed) && !walkedUp) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt 
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
            }
        }
        if (r == 2 || r == 8) // Wird ausgeführt wenn r 2 oder 8 ist
        {
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed) && !walkedLeft) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt 
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed) && !walkedDown) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed) && !walkedUp) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed) && !walkedRight) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = false;  // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
        }
        if (r == 3 || r == 9) // Wird ausgeführt wenn r 3 oder 9 ist
        {
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed) && !walkedDown) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed) && !walkedUp) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed) && !walkedRight) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed) && !walkedLeft) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z - speed)); // Der Agent bekommt ein neues Ziel
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedUp = true; // Der Boolean wird auf true gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x, y, z + speed)); // Der Agent bekommt ein neues Ziel
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedRight = false; // Der Boolean wird auf false gesezt
                walkedDown = true; // Der Boolean wird auf true gesezt
                walkedLeft = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x + speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedRight = false; // Der Boolean wird auf false gesezt 
                walkedUp = false; // Der Boolean wird auf false gesezt
                walkedLeft = true; // Der Boolean wird auf true gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
            }
            else if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), speed)) // Wenn der Raycast in der Distanz von speed auf nichts stösst
            {
                agent.SetDestination(new Vector3(x - speed, y, z)); // Der Agent bekommt ein neues Ziel
                walkedLeft = false; // Der Boolean wird auf false gesezt
                walkedDown = false; // Der Boolean wird auf false gesezt
                walkedRight = true; // Der Boolean wird auf true gesezt
                walkedUp = false; // Der Boolean wird auf false gesezt
            }
        }
        /*if (r == 4) // (WIP) dient der Bewegung in der dritten und vierten Dimension
        {
            walking = true;
            int t = Random.Range(0, 2);
            if (t == 0)
            {
                if (transform.position.x < 10.5)
                {
                    Instantiate(enemy, new Vector3(x + 11, y, z), Quaternion.Euler(0, 0, 0));
                    Destroy(gameObject);
                    walking = false;
                }
            }
            else
            {
                if (transform.position.x > 10.5)
                {
                    Instantiate(enemy, new Vector3(x - 11, y, z), Quaternion.Euler(0, 0, 0));
                    Destroy(gameObject);
                    walking = false;
                }
            }
        }
        if (r == 5) // (WIP) dient der Bewegung in der dritten und vierten Dimension
        {
            walking = true;
            int j = Random.Range(0, 2);
            if (j == 0)
            {
                if (transform.position.z < 10.5)
                {
                    Instantiate(enemy, new Vector3(x, y, z + 11), Quaternion.Euler(0, 0, 0));
                    Destroy(gameObject);
                    walking = false;
                }
            }
            else
            {
                if (transform.position.z > 10.5)
                {
                    Instantiate(enemy, new Vector3(x, y, z - 11), Quaternion.Euler(0, 0, 0));
                    Destroy(gameObject);
                    walking = false;
                }
            }
        }*/
    }

    void Update() // Wird jedes Frame ausgeführt
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f); // Sezt die Rotation des Objekts auf Null
        if (!walking) // Wenn der Boolean walking false ist
        {
            StartCoroutine(GoForAWalk()); // Führt die Routine GoForAWalk aus
        }
        if (!agent.hasPath) // Wenn der Agent keinen Weg hat, den er gehen muss, resp. kein Ziel hat
        {
            walking = false; // Sezt den Boolean walking auf false
        }

    }

    private IEnumerator GoForAWalk() // Funktion in welcher z.B. mir yield gearbeitet werden kann
    {
        yield return new WaitForSecondsRealtime(5f); // Wartet für 5 Sekunden echte Zeit
        Walk(); // Führt die Funktion Walk aus
    }
}