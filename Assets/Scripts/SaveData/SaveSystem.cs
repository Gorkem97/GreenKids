using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveSystem 
{
    public int tumpuan;


    public SaveSystem(SahneDuzeni puancek)
    {
        tumpuan = puancek.nihaisender;
    }
}
