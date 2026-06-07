using UnityEngine;
using TMPro;

public class PomodoroTimer : MonoBehaviour
{
    [Header("Timer UI")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float totalTime = 1500f; // 25 menit

    private float currentTime;
    private bool isRunning = false;

    void Start()
    {
        currentTime = totalTime;
        UpdateTimerText();
    }

    void Update()
    {
        if (isRunning)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                isRunning = false;
            }

            UpdateTimerText();
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void PauseTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        isRunning = false;
        currentTime = totalTime;
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}