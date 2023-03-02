using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class StatisticSaver : MonoBehaviour
{
    [SerializeField] private GameStatistics statistics;
    private string path;
    private string filestring = "/statistics.txt";
    private void Start()
    {
        path = Application.persistentDataPath + "/GameStatistics";
        Load();
    }
    public void Save()
    {
        if (!IsSaveFile())
        {
            Directory.CreateDirectory(path);
        }

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Create(path + filestring);
        var json = JsonUtility.ToJson(statistics);
        formatter.Serialize(file, json);
        file.Close();
    }

    public void Load()
    {
        if (!IsSaveFile())
        {
            Directory.CreateDirectory(path);
        }
        BinaryFormatter formatter = new BinaryFormatter();
        if (File.Exists(path + filestring))
        {

            FileStream file = File.Open(path + filestring, FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)formatter.Deserialize(file), statistics);
            file.Close();
        }
    }

    public bool IsSaveFile()
    {
        return Directory.Exists(path);
    }
}


