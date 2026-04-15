using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public Vector3 rotateAngles;

    void Update()
    {
        transform.Rotate(rotateAngles);
    }
}
