using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGame : MonoBehaviour
{
    private bool _isPause;
    [SerializeField] private GameObject _panelPause;

    private void SwitchPauseStatus(bool status)
    {
        Time.timeScale = status ? 1 : 0;
        _isPause = !status;
        _panelPause.SetActive(!status);
    }

    public void PauseButton()
    {
        SwitchPauseStatus(_isPause);
    }

    public void ContinueGame()
    {
        SwitchPauseStatus(_isPause);
    }

    public void Continue()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
