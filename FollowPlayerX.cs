using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlaneX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Assigning the offset value as per the hint
        offset = new Vector3(30, 0, 10);
    }

    // Update is called once per frame
    void LateUpdate() // Using LateUpdate to ensure camera follows after the plane moves
    {
        // Make the camera follow the plane's position with the offset
        transform.position = plane.transform.position + offset;
    }
}

