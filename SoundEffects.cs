using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource buySound;
    public AudioSource slimeKill;
    public AudioSource ratKill;
    public AudioSource scorpionKill;
    public AudioSource spiderKill;
    public AudioSource wolfKill;
    public AudioSource skeletonKill;


    public void buy() 
    {
        buySound.Play();
    }
    public void KillSlime() 
    {
        slimeKill.Play();
    }
    public void KillRat() 
    {
        ratKill.Play();
    }
    public void KillScorpion() 
    {
        scorpionKill.Play();
    }
    public void KillSpider() 
    {
        spiderKill.Play();
    }
    public void KillWolf() 
    {
        wolfKill.Play();
    }
    public void KillSkeleton() 
    {
        skeletonKill.Play();
    }


}
