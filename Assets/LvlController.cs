using System;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Audio;

public class LvlController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int lvl;
    private float time;
    public GameObject tryAgain;
    public GameObject changeLvl;
    public GameObject youLose;
    public GameObject youWin;
    public PlayerController player;
    [SerializeField] TextMeshProUGUI scoreText;
    public bool gamePause = false;

    [SerializeField] GameObject audioPanel;
    [SerializeField] AudioMixer mixer;
    [SerializeField] UnityEngine.UI.Slider musicSlider;
    [SerializeField] UnityEngine.UI.Slider SFXSlider;
    [SerializeField] string musicParamName;
    [SerializeField] string SFXParamName;

    //private GameObject menuManager;
    void Start()
    {
        if (menuManagerScript.Instance != null)
        {
            Debug.Log("found menuManager");
            lvl = menuManagerScript.Instance.level;
        }
        else lvl = 0;
        time = 0f;
        broadCastReset();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (!gamePause )
        {
            double milliseconds = Math.Floor((time - MathF.Floor(time)) * 1000);
            scoreText.text = MathF.Floor(time).ToString() + ":";
            if (milliseconds > 99)  scoreText.text += milliseconds.ToString();
            else if (milliseconds > 9) scoreText.text += "0" + milliseconds.ToString();
            else scoreText.text += "00" + milliseconds.ToString();
        }
    }

    public void gameLost()
    {
        if (gamePause == false)
        {
            gamePause = true;
            tryAgain.SetActive(true);
            changeLvl.SetActive(true);
            youLose.SetActive(true);
            player.stopPlayer = true;
        }
    }
    public void gameWon()
    {
        gamePause = true;
        tryAgain.SetActive(true);
        changeLvl.SetActive(true);
        youWin.SetActive(true);
        player.stopPlayer = true;
    }

    public void broadCastReset()
    {
        gamePause = false;
        tryAgain.SetActive(false);
        changeLvl.SetActive(false);
        youLose.SetActive(false);
        youWin.SetActive(false);
        time = 0f;

        gameObject.BroadcastMessage("resetLevel", lvl);
        gameObject.BroadcastMessage("resetCounter", lvl);
        gameObject.BroadcastMessage("resetGround", lvl);
    }

    public void ToggleAudio()
    {
        audioPanel.SetActive(!audioPanel.activeSelf);
    }

    public void SetMusicVolume()
    {
        float volume = Mathf.Log10(Mathf.Max(musicSlider.value, 0.0000001f)) * 20;
        mixer.SetFloat(musicParamName, volume);
    }
    public void SetSFXVolume()
    {
        float volume = Mathf.Log10(Mathf.Max(SFXSlider.value, 0.0000001f)) * 20;
        mixer.SetFloat(SFXParamName, volume);
    }
}
