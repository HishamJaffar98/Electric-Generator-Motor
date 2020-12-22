using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderPanel : MonoBehaviour
{
    private void Awake()
    {
        if(LevelManager.UpdateLevelIndex()==1)
        {
            gameObject.GetComponent<Animator>().SetTrigger("faderDissolve");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndOfAnimationEvent()
    {
        StartCoroutine(LevelManager.LoadNextLevel(0f));
    }

    public void DisablePanel()
    {
        gameObject.SetActive(false);
    }    
}
