using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoCharacterJump1 : MonoBehaviour
{
    public KeyCode jumpKeyPeach = KeyCode.Space; // Tecla para el salto del Jugador 1
    public KeyCode jumpKeyLuigi = KeyCode.Delete; // Tecla para el salto del Jugador 2

    public float jumpForce = 5f; // Fuerza del salto
    public LayerMask groundLayer; // Capa que define el suelo
    public Transform groundCheck; // Punto de verificación del suelo
    public float groundCheckRadius = 0.2f; // Radio para verificar si está en el suelo

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Verificar si el personaje está en el suelo
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
        Debug.Log($"IsGrounded ({gameObject.name}): {isGrounded}");

        // Permitir saltar si está en el suelo
        if (isGrounded && Input.GetKeyDown(jumpKeyPeach) && gameObject.name == "Peach")
        {
            Jump();
            Debug.Log("Peach saltó.");
        }
        else if (isGrounded && Input.GetKeyDown(jumpKeyLuigi) && gameObject.name == "Luigi")
        {
            Jump();
            Debug.Log("Luigi saltó.");
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // Restablecer la velocidad en Y para un salto consistente
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void OnDrawGizmosSelected()
    {
        // Dibujar un gizmo para mostrar el área de verificación del suelo
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }

       
        
}
}

        
    
