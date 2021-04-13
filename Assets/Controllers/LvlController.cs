using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlController : MonoBehaviour
{
    public static int lvl1Score;
    public static int lvl2Score;

    public static int volume = 50;
    public static int minVolume = 0;
    public static int maxVolume = 100;

    [SerializeField] Text score;
    [SerializeField] Text volumeText;

    AudioSource audio;

    private BirdControls _controls;

    private void Awake()
    {
        _controls = new BirdControls();
        _controls.Menu.Level1.performed += ctx => Level1();
        _controls.Menu.Level2.performed += ctx => Level2();
        _controls.Menu.SoundUp.performed += ctx => SoundUp();
        _controls.Menu.SoundDown.performed += ctx => SoundDown();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void Start()
    {
        score.text = $"Level 1: {lvl1Score}\nLevel 2: {lvl2Score}";
        volumeText.text = $"{volume}%";
    }

    public void Level1()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Lvl2");
    }

    public void SoundUp()
    {
        if (volume < maxVolume)
        {
            volume += 5;
            volumeText.text = $"{volume}%";
            audio = GetComponent<AudioSource>();
            audio.volume = volume;
        }
    }

    public void SoundDown()
    {
        if (volume > minVolume)
        {
            volume -= 5;
            volumeText.text = $"{volume}%";
            audio = GetComponent<AudioSource>();
            audio.volume = volume;
        }
    }
}
