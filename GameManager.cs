using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject targetsParent; // Assign the "Targets" GameObject here
    public Text timerText;
    public int totalTargets = 5;

    private float timer;
    private int targetsHit;

    void Start()
    {
        timer = 0f;
        targetsHit = 0;
        // Initialize the game state if needed
    }

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;
        UpdateTimerText();

        // Check if all targets are hit
        if (targetsHit >= totalTargets)
        {
            StopTimer();
        }
    }

    public void TargetHit()
    {
        targetsHit++;
    }

    void UpdateTimerText()
    {
        timerText.text = $"Time: {Mathf.Round(timer)}s";
    }

    void StopTimer()
    {
        // Optionally you can disable the timer update
        Time.timeScale = 0; // Pause the game
        // You can also display a message or change UI state
        // Example: timerText.text = $"Congratulations! Time: {Mathf.Round(timer)}s";
    }
}
