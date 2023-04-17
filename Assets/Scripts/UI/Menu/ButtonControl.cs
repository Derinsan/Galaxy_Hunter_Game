using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    [SerializeField] private GameObject _settings;

    void Awake()
    {
        _settings.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SettingsOpen()
    {
        _settings.SetActive(true);
    }

    public void SettingsClose()
    {
        _settings.SetActive(false);
    }
}
