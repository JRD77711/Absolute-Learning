using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject homePanel;
    public GameObject pomodoroPanel;
    public GameObject materialsPanel;
    public GameObject progressPanel;

    [Header("Navigation Buttons")]
    public Button pomodoroButton;
    public Button materialsButton;
    public Button progressButton;

    [Header("Button Colors")]
    public Color activeColor = new Color(0.82f, 1f, 0.48f, 1f);
    public Color inactiveColor = new Color(0.82f, 1f, 0.48f, 0.45f);

    void Start()
    {
        ShowHome();
    }

    public void ShowHome()
    {
        homePanel.SetActive(true);
        pomodoroPanel.SetActive(false);
        materialsPanel.SetActive(false);
        progressPanel.SetActive(false);

        ResetButtonColors();
    }

    public void ShowPomodoro()
    {
        homePanel.SetActive(false);
        pomodoroPanel.SetActive(true);
        materialsPanel.SetActive(false);
        progressPanel.SetActive(false);

        SetActiveButton(pomodoroButton);
    }

    public void ShowMaterials()
    {
        homePanel.SetActive(false);
        pomodoroPanel.SetActive(false);
        materialsPanel.SetActive(true);
        progressPanel.SetActive(false);

        SetActiveButton(materialsButton);
    }

    public void ShowProgress()
    {
        homePanel.SetActive(false);
        pomodoroPanel.SetActive(false);
        materialsPanel.SetActive(false);
        progressPanel.SetActive(true);

        SetActiveButton(progressButton);
    }

    void ResetButtonColors()
    {
        pomodoroButton.image.color = inactiveColor;
        materialsButton.image.color = inactiveColor;
        progressButton.image.color = inactiveColor;
    }

    void SetActiveButton(Button activeButton)
    {
        ResetButtonColors();
        activeButton.image.color = activeColor;
    }
}