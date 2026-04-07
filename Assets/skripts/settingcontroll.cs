using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class audio : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;  //der AudioMixer, der die Lautstärke regelt
    [SerializeField] private Slider musicSlider;    //der Slider, der die Lautstärke regelt
    [SerializeField] private Slider sfxSlider;      //der Slider, der die Lautstärke regelt
    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))   //wenn es einen gespeicherten Wert für die Lautstärke gibt, wird dieser geladen
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();         //damit die Lautstärke auch beim Starten des Spiels übernommen
            SetSFXVolume(); 
        }
    }
    public void SetMusicVolume()
    {
        float volume = musicSlider.value;                            //damit die Lautstärke auch beim Starten des Spiels übernommen wird, muss die Funktion hier aufgerufen werden
        audioMixer.SetFloat("music", Mathf.Log10(volume)*20);        //die Lautstärke wird logarithmisch angepasst, damit sie natürlicher klingt
        PlayerPrefs.SetFloat("musicVolume", volume);                 //der Wert wird gespeichert, damit er beim nächsten Starten des Spiels wieder geladen werden kann
    }

    public void SetSFXVolume()
    {
        float volume = sfxSlider.value;                            //damit die Lautstärke auch beim Starten des Spiels übernommen wird, muss die Funktion hier aufgerufen werden
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);        //die Lautstärke wird logarithmisch angepasst, damit sie natürlicher klingt
        PlayerPrefs.SetFloat("SFXVolume", volume);                 //der Wert wird gespeichert, damit er beim nächsten Starten des Spiels wieder geladen werden kann
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");     //der gespeicherte Wert wird geladen und auf den Slider angewendet
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");
        SetMusicVolume();         //damit die Lautstärke auch beim Starten des Spiels übernommen wird, muss die Funktion hier aufgerufen werden
        SetSFXVolume();
    }

    
}
//NOCH TESTEN, OB ES FUNKTIONIERT, ABER ES SOLLTE FUNKTIONIEREN