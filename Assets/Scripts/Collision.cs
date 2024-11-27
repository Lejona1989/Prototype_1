using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject BonusMario; // Referencia al objeto que queremos detener

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == BonusMario)
        {
            // Detener el objeto giratorio
            BonusMario.GetComponent<Rigidbody>().velocity *= -10;
            BonusMario.GetComponent<Rigidbody>().angularVelocity *= -10;
        }
    }
}
