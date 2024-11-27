using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoratingObjet2 : MonoBehaviour
{
    public float rotationSpeed = 200f; // Velocidad de rotación
    private bool isRotating = true;    // Comienza girando

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collision collision)
    {
        Debug.Log($"Colisión detectada con: {collision.gameObject.name}");

        var test = collision.gameObject.CompareTag("Koopa");
        if (collision.gameObject.CompareTag("Koopa"))
        {
            Debug.Log("Tag detectado: Koopa. Deteniendo rotación.");
            StopRotation();
        }
    }

    private void StopRotation()
    {
        isRotating = false; // Detiene la rotación
    }
}
