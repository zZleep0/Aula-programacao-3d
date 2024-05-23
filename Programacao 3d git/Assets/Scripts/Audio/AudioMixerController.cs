using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    public AudioMixer mix;
    public float volumeLeao = 0;
    public float pitchLeao = 0;
    public float volumeSDA = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mix.SetFloat("VolumeRei", volumeLeao);
        mix.SetFloat("PitchRei", pitchLeao);
        mix.SetFloat("VolumeSDA", volumeSDA);
    }
}
