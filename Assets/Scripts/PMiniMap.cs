using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PMiniMap : MonoBehaviour
{
    public void setCoordinates(float x, float y, float z)
    {
        transform.position = new Vector3(x, (y + 14.6f) * 11 + 0.4f, z); // Die Position wird an die des Spielers angepasst
    }
}
