using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveKeep
{
    public static void SavePuan(SahneDuzeni sahnecim)
    {
        BinaryFormatter formatcý = new BinaryFormatter();
        string yol = Application.persistentDataPath + "/sahnecim.puantiye";
        FileStream stream = new FileStream(yol, FileMode.Create);

        SaveSystem data = new SaveSystem(sahnecim);

        formatcý.Serialize(stream, data);
        stream.Close();
    }

    public static SaveSystem loadsave()
    {
        string yol = Application.persistentDataPath + "/sahnecim.puantiye";
        if (File.Exists(yol))
        {
            BinaryFormatter formatci = new BinaryFormatter();
            FileStream stream = new FileStream(yol, FileMode.Open);
            SaveSystem data = formatci.Deserialize(stream) as SaveSystem;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("SaveYok");
            return null;
        }
    }
}
