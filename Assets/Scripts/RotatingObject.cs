using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private bool isRotating = true;

    public string Koopa { get; private set; }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);

        }

    }

    public void StopRotation()
    {
        isRotating = false;
        transform.Rotate(Vector3.left, 0 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Koopa"))
        {
            StopRotation();
        }
        StopRotation();
    }
}

