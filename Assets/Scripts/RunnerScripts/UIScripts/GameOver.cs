using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class GameOver : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private RunnerPlayer _player;

    private CanvasGroup _gameOverGroup;
    private void OnEnable()
    {
        _player.Died += OnDied;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
    }
    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
    }
    private void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha = 0;
    }
    private void OnDied()
    {
        _gameOverGroup.alpha = 1;
        Time.timeScale = 0;
    }
    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    private void OnExitButtonClick()
    {
        Application.Quit();
    }
}