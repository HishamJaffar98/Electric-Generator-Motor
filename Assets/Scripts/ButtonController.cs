using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    SplashScreenUI splashScreen;
    SelectionUI selectionScreen;
    GeneratorUI generatorUI;

    bool labelToggled = true;
    bool rotationToggled = true;
    bool informationToggled = false;
    void Start()
    {
        splashScreen = FindObjectOfType<SplashScreenUI>();
        selectionScreen = FindObjectOfType<SelectionUI>();
        generatorUI = FindObjectOfType<GeneratorUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NeonBolt()
    {
        splashScreen.StopAnimators();
        splashScreen.NeonGlow();
    }

    public void StartButton()
    {
        StartCoroutine(LevelManager.LoadNextLevel(1.5f));
    }

    public void ButtonSFX(AudioClip buttonFX)
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(buttonFX);
    }

    public void QuitButton()
    {
        StartCoroutine(LevelManager.QuitApplication());
    }

    public void GeneratorButton()
    {
        selectionScreen.ToggleButtonActiveState(1);
        StartCoroutine(LevelManager.LoadLevel(1.5f,3));
    }

    public void MotorButton()
    {
        selectionScreen.ToggleButtonActiveState(0);
        StartCoroutine(LevelManager.LoadLevel(1.5f, 4));
    }

    public void ToggleLabel()
    {
        if(labelToggled)
        {
            labelToggled = false;
        }
        else
        {
            labelToggled = true;
        }
        generatorUI.ToggleSprite("Label", labelToggled);
        generatorUI.ToggleLabel(labelToggled);
    }

    public void ToggleRotation()
    {
        if(rotationToggled)
        {
            rotationToggled = false;
        }
        else
        {
            rotationToggled = true;
        }
        generatorUI.ToggleSprite("Rotate", rotationToggled);
        generatorUI.ToggleRotation(rotationToggled);
    }

    public void ToggleInformation()
    {
        if(informationToggled)
        {
            informationToggled = false;
        }
        else
        {
            informationToggled = true;
        }
        generatorUI.ToggleSprite("Info", informationToggled);
        generatorUI.PlayNarration(informationToggled);
        generatorUI.ReduceMusicVolume(informationToggled);
    }

    public void SelectionScreenButton()
    {
        StartCoroutine(LevelManager.LoadLevel(0.5f, 2));
        generatorUI.ToggleSprite("Info", false);
        generatorUI.PlayNarration(false);
        generatorUI.ReduceMusicVolume(false);
    }

    public void BackButton()
    {
        StartCoroutine(LevelManager.LoadPrevLevel(0.5f));
    }
}
