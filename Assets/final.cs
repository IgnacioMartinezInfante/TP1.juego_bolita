using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para gestionar las escenas

public class final : MonoBehaviour
{
    public GameObject jugador; // Referencia al objeto del jugador
    public GameObject meta; // Referencia al objeto de la meta
    public GameObject levelcompletedCanvas;

    private void Start()
    {
        // Configurar gameoverCanvas como falso al inicio del juego
        levelcompletedCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jugador && meta != null)
        {
            levelcompletedCanvas.SetActive(true);
            Time.timeScale = 0f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
