using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer; // Erstellt einen �ffentlichen AudioMixer namens audioMixer
    public TMP_Dropdown resolutionDropdown; // Erstellt ein �ffentliches Dropdown namens resolutionDropdown

    Resolution[] resolutions; // Gibt der Aufl�sung (Liste) den Namen resolutions

    // Start is called before the first frame update
    private void Start()
    {
        resolutions = Screen.resolutions; // F�gt alle, vom Computer des Gebrauchers, Aufl�sungen der Liste resolutions hinzu

        resolutionDropdown.ClearOptions(); // L�scht alle Optionen im Dropdown

        List<string> options = new (); // Erstellt einen neue Liste mit options (Text) als Inhalt

        int currentResolutionIndex = 0; // Erstellt einen Integer mit dem Wert 0

        for (int i = 0; i < resolutions.Length; i++) // Im Bereich von i = 0 bis i den gleichen Wert hat wie die L�nge der Liste resolutions, i wird mit jedem Durchlauf 1 gr�sser
        {
            string option = resolutions[i].width + " x " + resolutions[i].height; // Die Variable bekommt den Text der Aufl�sung (Breite x H�he)
            options.Add(option); // F�gt die Variable option der Liste options hinzu

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) // Aufl�sung vom Computer gleich der Aufl�sung der Liste resolutions (die H�he und die Breite kann nur separat angeschaut werden)
            {
                currentResolutionIndex = i; // Der Integer erh�lt den Wert von i
            }
        }

        resolutionDropdown.AddOptions(options); // Das Dropdown erh�lt alle Optionen der Liste options
        resolutionDropdown.value = currentResolutionIndex; // Die angezeigte Option des Dopdowns wird zum currentResolutionIndex gesetzt
        resolutionDropdown.RefreshShownValue(); // Die angezeigt Option wird aktualisiert
    }

    public void SetResolution(int resolutionIndex) // �ffentliche Funktion mit eingabe eines Integers
    {
        Resolution resolution = resolutions[resolutionIndex]; // Die Variable resolution wird zur ausgew�hlten Aufl�sung des Dropdowns, indem der erhaltene Wert resolutionIndex angibt, welches Element der Liste resolutions verwerdet wird
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen); // Die Aufl�sung wird auf die gew�nschten Aufl�sung gesetzt
    }

    public void SetVolume(float volume) // �ffentliche Funktion mit Eingabe eines Floats
    {
        audioMixer.SetFloat("volume", volume); // Der AudioMixer erh�lt den Wert volume, welcher von einem Schiebregler kommt
    }

    public void SetQuality(int qualityIndex) // �ffentliche Funktion mit Eingabe eines Integers
    {
        QualitySettings.SetQualityLevel(qualityIndex); // Die Qualit�tsstufe wird auf die gew�nschte Stufe gesetzt, welche aus einem Dropdown ausgew�hlt wurde
    }

    public void SetFullscreen(bool isFullscreen) // �ffentliche Funktion mit Eingabe eines Booleans
    {
        Screen.fullScreen = isFullscreen; // Der Fullscreen bekommt den Boolean isFullscreen des Knopfs (true/false)
    }

    public void Load() // �ffentliche Funktion
    {
        SaveSystem.LoadPlayer(); // Der Spielstand des Spielers wird geladen
    }

    public void ResetHighScore() // �ffentliche Funktion
    {
        PlayerPrefs.SetInt("HighScore", 0); // Der HighScore wird gel�scht
    }

    public void ResetGame() // �ffentliche Funktion
    {
        PlayerPrefs.DeleteAll(); // Alle gespeicherten Daten werden gel�scht
    }
}