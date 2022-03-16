using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveSystem 
{
    public int tumpuan = 0;
    public int diling = 0;

    public SaveSystem(SahneDuzeni puancek)
    {
        tumpuan = puancek.nihaisender;
        diling = puancek.dil;
    }
}
