using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuntosManager : MonoBehaviour
{
    public int puntosEquipoA = 0;
    public int puntosEquipoB = 0;

    public Text PuntajeA;
    public Text PuntajeB;
    public Text textoGanador;

    public int puntajeMaximo = 3;

    private void Start()

      {
        // Inicializar el marcador
        textoGanador.gameObject.SetActive(false);
        ActualizarMarcadores();
    }

    public void AgregarPunto(string equipo)
    {
        if (equipo == "EquipoA")
        {
            puntosEquipoA++;
        }
        else if (equipo == "EquipoB")
        {
            puntosEquipoB++;
        }
        ActualizarMarcadores();

        VerificarGanador();
    }

    private void ActualizarMarcadores()
    {
        PuntajeA.text = "Equipo A: " + puntosEquipoA;
        PuntajeB.text = "Equipo B: " + puntosEquipoB;
    }

    private void VerificarGanador()
    {
        if (puntosEquipoA >= puntajeMaximo)
        {
            MostrarGanador("WINNER A");
        }
        else if (puntosEquipoB >= puntajeMaximo)
        {
            MostrarGanador("WINNER B");
        }
    }

    private void MostrarGanador(string equipo)
    {
        textoGanador.gameObject.SetActive(true);
        textoGanador.text = equipo + " GANADOR!";
        Debug.Log(equipo + " ha ganado el juego.");

        StartCoroutine(RegresarAlMenu());
    }

    private IEnumerator RegresarAlMenu()
    {
        yield return new WaitForSeconds(3f); 
        SceneManager.LoadScene("MenuInicial");
    }
}
