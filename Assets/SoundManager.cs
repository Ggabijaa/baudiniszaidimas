using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip slimeSound, collectHPSound;

    private static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        collectHPSound = Resources.Load<AudioClip>("collect");
        slimeSound = Resources.Load<AudioClip>("slimy");
        
        audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "collect":
                audioScr.PlayOneShot(collectHPSound);
                break;
            case "slimy":
                audioScr.PlayOneShot(slimeSound);
                break;
        }
    }
}
