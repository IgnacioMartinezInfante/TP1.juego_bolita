using UnityEngine;

public class camarajugador : MonoBehaviour
{
    public Transform target; // Referencia al jugador (la esfera)
    public float distance = 5.0f; // Distancia de la cámara al jugador
    public float height = 2.0f; // Altura de la cámara sobre el jugador
    public float smoothSpeed = 5.0f; // Velocidad de suavizado de la cámara

    private Vector3 offset; // Desplazamiento de la cámara con respecto al jugador

    void Start()
    {
        offset = new Vector3(0, height, -distance);
    }

    void LateUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 desiredPosition = target.position + offset;

        // Utiliza Lerp para suavizar el movimiento de la cámara y evitar saltos bruscos
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Actualiza la posición de la cámara
        transform.position = smoothedPosition;

        // Mira siempre hacia el jugador
        transform.LookAt(target);
    }
}
