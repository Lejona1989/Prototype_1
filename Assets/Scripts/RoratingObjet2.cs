using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoratingObjet2 : MonoBehaviour
{
    public float rotationSpeed = 200f; // Velocidad de rotaci�n
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
        Debug.Log($"Colisi�n detectada con: {collision.gameObject.name}");

        var test = collision.gameObject.CompareTag("Koopa");
        if (collision.gameObject.CompareTag("Koopa"))
        {
            Debug.Log("Tag detectado: Koopa. Deteniendo rotaci�n.");
            StopRotation();
        }
    }

    private void StopRotation()
    {
        isRotating = false; // Detiene la rotaci�n
    }
}
