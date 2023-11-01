using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer; // Erstellt einen öffentlichen AudioMixer namens audioMixer
    public TMP_Dropdown resolutionDropdown; // Erstellt ein öffentliches Dropdown namens resolutionDropdown

    Resolution[] resolutions; // Gibt der Auflösung (Liste) den Namen resolutions

    // Start is called before the first frame update
    private void Start()
    {
        resolutions = Screen.resolutions; // Fügt alle, vom Computer des Gebrauchers, Auflösungen der Liste resolutions hinzu

        resolutionDropdown.ClearOptions(); // Löscht alle Optionen im Dropdown

        List<string> options = new (); // Erstellt einen neue Liste mit options (Text) als Inhalt

        int currentResolutionIndex = 0; // Erstellt einen Integer mit dem Wert 0

        for (int i = 0; i < resolutions.Length; i++) // Im Bereich von i = 0 bis i den gleichen Wert hat wie die Länge der Liste resolutions, i wird mit jedem Durchlauf 1 grösser
        {
            string option = resolutions[i].width + " x " + resolutions[i].height; // Die Variable bekommt den Text der Auflösung (Breite x Höhe)
            options.Add(option); // Fügt die Variable option der Liste options hinzu

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) // Auflösung vom Computer gleich der Auflösung der Liste resolutions (die Höhe und die Breite kann nur separat angeschaut werden)
            {
                currentResolutionIndex = i; // Der Integer erhält den Wert von i
            }
        }

        resolutionDropdown.AddOptions(options); // Das Dropdown erhält alle Optionen der Liste options
        resolutionDropdown.value = currentResolutionIndex; // Die angezeigte Option des Dopdowns wird zum currentResolutionIndex gesetzt
        resolutionDropdown.RefreshShownValue(); // Die angezeigt Option wird aktualisiert
    }

    public void SetResolution(int resolutionIndex) // Öffentliche Funktion mit eingabe eines Integers
    {
        Resolution resolution = resolutions[resolutionIndex]; // Die Variable resolution wird zur ausgewählten Auflösung des Dropdowns, indem der erhaltene Wert resolutionIndex angibt, welches Element der Liste resolutions verwerdet wird
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen); // Die Auflösung wird auf die gewünschten Auflösung gesetzt
    }

    public void SetVolume(float volume) // Öffentliche Funktion mit Eingabe eines Floats
    {
        audioMixer.SetFloat("volume", volume); // Der AudioMixer erhält den Wert volume, welcher von einem Schiebregler kommt
    }

    public void SetQuality(int qualityIndex) // Öffentliche Funktion mit Eingabe eines Integers
    {
        QualitySettings.SetQualityLevel(qualityIndex); // Die Qualitätsstufe wird auf die gewünschte Stufe gesetzt, welche aus einem Dropdown ausgewählt wurde
    }

    public void SetFullscreen(bool isFullscreen) // Öffentliche Funktion mit Eingabe eines Booleans
    {
        Screen.fullScreen = isFullscreen; // Der Fullscreen bekommt den Boolean isFullscreen des Knopfs (true/false)
    }

    public void Load() // Öffentliche Funktion
    {
        SaveSystem.LoadPlayer(); // Der Spielstand des Spielers wird geladen
    }

    public void ResetHighScore() // Öffentliche Funktion
    {
        PlayerPrefs.SetInt("HighScore", 0); // Der HighScore wird gelöscht
    }

    public void ResetGame() // Öffentliche Funktion
    {
        PlayerPrefs.DeleteAll(); // Alle gespeicherten Daten werden gelöscht
    }
}