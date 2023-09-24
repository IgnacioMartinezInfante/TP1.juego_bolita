using UnityEngine;
using UnityEngine.UI;

public class tiempo : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool gameIsRunning = true;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (gameIsRunning)
        {
            float currentTime = Time.time - startTime;
            string minutes = ((int)currentTime / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("00");
            timerText.text = minutes + ":" + seconds;
        }
    }

    public void StopGame()
    {
        gameIsRunning = false;
    }
}
