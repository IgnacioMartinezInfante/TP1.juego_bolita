using UnityEngine;
using UnityEngine.UI;

public class parartiempo : MonoBehaviour
{
    public tiempo Parartiempo;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("jugador"))
        {
            Parartiempo.StopGame(); // Detiene el contador de tiempo cuando el jugador llega a la meta.
            // Puedes agregar aquí cualquier otra lógica que necesites cuando el jugador llega a la meta.
        }
    }
}

