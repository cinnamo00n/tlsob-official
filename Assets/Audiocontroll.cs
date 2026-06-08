using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;
public class audiocontroll : MonoBehaviour
{
  public AudioMixer audiomixer;             // Reference to the AudioMixer
    public Slider musicSlider;              // Reference to the UI Slider for music volume
    void Start()
    {
        musicSlider.onValueChanged.AddListener(SetVolume);     // Add listener to the slider to call SetVolume when the value changes
    }
    public void SetVolume(float value)            // Method to set the volume based on the slider value
    {
        if (value <= 0) value  = 0.0001f; // Avoid log of zero
        audiomixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);     // Convert slider value to decibels and set it in the AudioMixer
    }
}
