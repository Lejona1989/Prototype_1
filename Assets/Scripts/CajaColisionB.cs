using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColisionB : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra al trigger pertenece a un equipo
        if (other.CompareTag("EquipoA") || other.CompareTag("EquipoB"))
        {
            // Encuentra el gestor de puntos
            PuntosManager puntosManager = FindObjectOfType<PuntosManager>();

            if (puntosManager != null)
            {
                // Agrega un punto al equipo correspondiente
                puntosManager.AgregarPunto(other.tag);
                Debug.Log("Punto agregado por: " + other.tag);
            }
        }
    }
}
