using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource buySound;
    public AudioSource slimeKill;

    public void buy() 
    {
        buySound.Play();
    }
    public void KillSlime() 
    {
        slimeKill.Play();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
