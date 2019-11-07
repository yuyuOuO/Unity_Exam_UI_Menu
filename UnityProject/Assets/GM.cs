using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GM : MonoBehaviour {

    public AudioMixer mixer;

	public void SetSFX(float value)
    {
        mixer.SetFloat("SFX", value);
    }

}
