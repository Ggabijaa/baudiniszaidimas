using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip slimeSound, collectHPSound, JumpSound, FireSound, WalkSound, VitSound, eees;

    private static AudioSource audioScr;
    // Start is called before the first frame update
    void Start()
    {
        collectHPSound = Resources.Load<AudioClip>("collect");
        slimeSound = Resources.Load<AudioClip>("slimy");
        JumpSound = Resources.Load<AudioClip>("Jump");
		FireSound = Resources.Load<AudioClip>("Fire");
		WalkSound = Resources.Load<AudioClip>("Walk");
        VitSound = Resources.Load<AudioClip>("Vit");
		eees = Resources.Load<AudioClip>("eee");
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
            case "Jump":
                audioScr.PlayOneShot(JumpSound);
                break;
			case "fire":
                audioScr.PlayOneShot(FireSound);
                break;
			case "Walk":
                audioScr.PlayOneShot(WalkSound);
                break;
            case "Vit":
                audioScr.PlayOneShot(VitSound);
                break;
			case "eee":
                audioScr.PlayOneShot(eees);
                break;
        }
    }
}
