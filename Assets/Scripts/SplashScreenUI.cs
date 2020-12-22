using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreenUI : MonoBehaviour
{
    [Header("Neon Objects")]
    [SerializeField] Animator[] neonObjectAnimators;
    [SerializeField] GameObject neonBolt;
    bool startGlowing = false;
    float glowTimer = 0f;

    [Header("Fader Panel")]
    [SerializeField] Animator faderPanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startGlowing)
        {
            glowTimer += Time.deltaTime;
            neonBolt.GetComponent<Image>().color=new Color(neonBolt.GetComponent<Image>().color.r, neonBolt.GetComponent<Image>().color.g,
                                                           neonBolt.GetComponent<Image>().color.b,
                                                           Mathf.Lerp(neonBolt.GetComponent<Image>().color.a, 1f, glowTimer));
            if (glowTimer>=1f)
            {
                GetComponent<AudioSource>().Play();
                faderPanel.SetTrigger("startFader");
                startGlowing = false;
            }
        }
    }

    public void StopAnimators()
    {
        foreach (Animator neonAnimator in neonObjectAnimators)
        {
            neonAnimator.enabled = false;
        }
    }

    public void NeonGlow()
    {
        if (neonBolt.GetComponent<Image>().color.a != 1)
        {
            startGlowing = true;
        }
        else
        {
            return;
        }
    }
}
