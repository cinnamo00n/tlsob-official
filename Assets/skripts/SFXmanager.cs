using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SFXVolumeSlider : MonoBehaviour
{
    public AudioMixer auduimixer;   // Dein AudioMixer
    public Slider SFXslider;          // Dein UI Slider
    public string SFXVolume = "SFXVolume"; // Name des exposed Parameters

    void Start()
    {
        // Slider mit aktuellem Mixerwert starten
        float value;
        auduimixer.GetFloat(SFXVolume, out value);
        SFXslider.value = Mathf.Pow(10, value / 20f); // dB in 0–1 umrechnen

        // Slider Event
        SFXslider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        // Wert 0–1 auf dB umrechnen (-80 bis 0)
        float dB = Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1f)) * 20f;
        auduimixer.SetFloat(SFXVolume, dB);
    }
}