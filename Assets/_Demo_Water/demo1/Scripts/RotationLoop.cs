using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLoop : MonoBehaviour
{
    public float speed = 50;

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
    }
}
