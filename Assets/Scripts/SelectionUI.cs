﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectionUI : MonoBehaviour
{
    [SerializeField] Button[] topicButtons;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleButtonActiveState(int buttonIndex)
    {
        topicButtons[buttonIndex].interactable = false;
    }
}
