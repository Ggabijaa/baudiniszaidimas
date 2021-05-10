using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour
{
   public AudioMixer audioMixer;

   public void SetEffectsVolume(float volume)
   {
      audioMixer.SetFloat("Master", volume);
   }

   public void SetMusicVolume(float volume)
   {
      audioMixer.SetFloat("effects", volume);
      //audioMixer.SetFloat("Bass", volume);
   }
}
