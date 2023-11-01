using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public static class SaveSystem // Öffentliche Klasse, von überall darauf zugreifbar
{
    public static void SavePlayer(Player player) // Öffentliche statische Funktion
    {
        BinaryFormatter formatter = new (); // Ein neuer BinaryFormatter wird erstellt
        string path = Application.persistentDataPath + "/player.fun"; // Der Speicherort der Dateien wird gesetzt
        FileStream stream = new (path, FileMode.Create); // Ein stream wird geöffnet mit Eingabe path

        PlayerData data = new (player); // Neuer Datensatz wird erstellt mit den Daten des Spielers

        formatter.Serialize(stream, data); // Die Daten des Spielers werden formatiert und dem stream hinzugefügt
        stream.Close(); // Der stream wird geschlossen
    }

    public static PlayerData LoadPlayer() // Öffentliche statische Funktion
    {
        string path = Application.persistentDataPath + "/player.fun"; // Speicherort wird gesetzt
        if (File.Exists(path)) // Falls die Datei schon existiert
        {
            BinaryFormatter formatter = new (); // Neuer BinaryFormatter wird erstellt
            FileStream stream = new (path, FileMode.Open); // Stream wird geöffnet

            PlayerData data = formatter.Deserialize(stream) as PlayerData; // Die Daten des streams werden auf data abgespeichert
            
            stream.Close(); // Der stream wird geschlossen 
            return data; // Die Daten werden ausgegeben
        }
        else // Falls die Datei nicht existiert
        {
            Debug.LogError("Save file not found in " + path); // Meldung wird gesendet
            return null; // Nichts wird ausgegeben
        }
    }
}