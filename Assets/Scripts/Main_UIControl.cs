using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_UIControl : MonoBehaviour
{
    public GameObject MainTab;
    public GameObject MiniTab;
    void Start()
    {
        CloseTab();
    }
    public void Eslesme()
    {
        SceneManager.LoadScene(1);
    }
    public void Siralama()
    {
        SceneManager.LoadScene(5);
    }
    public void MiniGame()
    {
        MiniTab.SetActive(true);
        MainTab.SetActive(false);
    }
    public void CloseTab()
    {
        MainTab.SetActive(true);
        MiniTab.SetActive(false);
    }
    public void ElmaTopla()
    {
        SceneManager.LoadScene(9);
    }
    public void Sula()
    {
        SceneManager.LoadScene(10);
    }
    public void Buda()
    {
        SceneManager.LoadScene(11);
    }
}
