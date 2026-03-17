using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;
public class audiocontroll : MonoBehaviour
{
  public AudioMixer audiomixer;
    public Slider musicSlider;
    void Start()
    {
        musicSlider.onValueChanged.AddListener(SetVolume);
    }
    public void SetVolume(float value)
    {
        if (value <= 0) value  = 0.0001f; // Avoid log of zero
        audiomixer.SetFloat("MusicVolume", Mathf.Log10(value) * 20);
    }
}
