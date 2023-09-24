using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detruirmoneda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jugador"))
        {
            contadormonedas contarmonedas = FindObjectOfType<contadormonedas>();
            if (contarmonedas != null)
            {
                contarmonedas.Increasecontarmonedas(); // Aumenta el contador de monedas.
            }

            Destroy(gameObject); // Destruye la moneda.
        }
    }
}
