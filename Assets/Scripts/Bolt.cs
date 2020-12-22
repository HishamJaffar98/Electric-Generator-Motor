using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    [SerializeField] AudioClip flickeringSound;

    public void PlayFlickeringSound()
    {
        GetComponent<AudioSource>().PlayOneShot(flickeringSound);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
