using UnityEngine;
using TMPro;

public class AudioManager : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource backgroundMusic;

    [Header("UI")]
    public TextMeshProUGUI muteButtonText;

    private bool isMuted = false;

    void Start()
    {
        UpdateButtonText();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;

        backgroundMusic.mute = isMuted;

        UpdateButtonText();
    }

    void UpdateButtonText()
    {
        if (isMuted)
        {
            muteButtonText.text = "Sound: OFF";
        }
        else
        {
            muteButtonText.text = "Sound: ON";
        }
    }
}