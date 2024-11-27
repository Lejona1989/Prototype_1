using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void Iniciar(string Nivel1)
    {
        SceneManager.LoadScene(Nivel1);
    }

    public void Salir()

    {
        Application.Quit();

        Debug.Log("Aquí se acaba el juego");


    }
        
   
}
