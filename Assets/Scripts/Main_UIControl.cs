using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_UIControl : MonoBehaviour
{
    public GameObject MainTab;
    public GameObject EsleSecenek;
    // Start is called before the first frame update
    void Start()
    {
        MainTab.SetActive(true);
        EsleSecenek.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EslestirmePenceresi()
    {
        MainTab.SetActive(false);
        EsleSecenek.SetActive(true);
    }
    public void EsledenDon()
    {
        MainTab.SetActive(true);
        EsleSecenek.SetActive(false);
    }
    public void UcluEsleme()
    {
        SceneManager.LoadScene(1);
    }
    public void AltiliSecme()
    {
        SceneManager.LoadScene(2);
    }
}
