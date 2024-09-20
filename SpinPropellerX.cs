using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 1000f; // Vitesse de rotation en degrés par seconde

    // Update is called once per frame
    void Update()
    {
        // Faire tourner l'objet autour de l'axe Z
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
