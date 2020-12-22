using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorUI : MonoBehaviour
{
    [SerializeField] GameObject[] UIButtons;
    GameObject labelObject;
    AudioManager audioManager;
    Color transparent = new Color(1, 1, 1, 0.2f);
    Color opaque = new Color(1, 1, 1, 1);
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        labelObject = GameObject.FindGameObjectWithTag("Label");
    }
    void Update()
    {
        
    }

    public void ToggleSprite(string buttonName,bool toggleValue)
    {
        if(buttonName=="Label" && toggleValue==false)
        {
            UIButtons[0].GetComponent<Image>().color = transparent;
        }
        else if(buttonName=="Label" && toggleValue==true)
        {
            UIButtons[0].GetComponent<Image>().color = opaque;
        }
        else if (buttonName == "Rotate" && toggleValue == false)
        {
            UIButtons[1].GetComponent<Image>().color = transparent;
        }
        else if (buttonName == "Rotate" && toggleValue == true)
        {
            UIButtons[1].GetComponent<Image>().color = opaque;
        }
        else if (buttonName == "Info" && toggleValue == false)
        {
            UIButtons[2].GetComponent<Image>().color = transparent;
        }
        else if (buttonName == "Info" && toggleValue == true)
        {
            UIButtons[2].GetComponent<Image>().color = opaque;
        }
    }

    public void ToggleLabel(bool toggleValue)
    {
        if (toggleValue)
        {
            labelObject.SetActive(true);
        }
        else
        {
            labelObject.SetActive(false);
        }
    }

    public void ToggleRotation(bool toggleValue)
    {
        if(toggleValue)
        {
            GameObject.FindGameObjectWithTag("CameraRotator").GetComponent<SmoothRotation>().enabled = true;
        }
        else if(!toggleValue)
        {
            GameObject.FindGameObjectWithTag("CameraRotator").GetComponent<SmoothRotation>().enabled = false;
        }
        
    }

    public void PlayNarration(bool narrationPlay)
    {
        if(narrationPlay)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
    }

    public void ReduceMusicVolume(bool reduceToggle)
    {
        if(reduceToggle)
        {
            audioManager.GetComponent<AudioSource>().volume = 0.05f;
        }
        else
        {
            audioManager.GetComponent<AudioSource>().volume = 0.3f;
        }
    }
}
