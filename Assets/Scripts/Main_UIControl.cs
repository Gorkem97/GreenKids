using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_UIControl : MonoBehaviour
{
    public GameObject MainTab;
    public GameObject MiniTab;
    public GameObject HafizaHub;

    public SahneDuzeni scener;

    bool bekledim;

    void Start()
    {
        CloseTab();
    }
    private void Update()
    {
        if (bekledim == true)
        {
            SceneManager.LoadScene(13);
            bekledim = false;
        }
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
        HafizaHub.SetActive(false);
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
    public void Eslestir()
    {
        SceneManager.LoadScene(12);
    }
    public void Hafiza3()
    {
        StartCoroutine(beklemek());
    }
    public void Hafiza4()
    {
        for (int i = 0; i < 1; i++)
        {
            scener.kacolduartir();
        }
        StartCoroutine(beklemek());
    }
    public void Hafiza5()
    {
        for (int i = 0; i < 2; i++)
        {
            scener.kacolduartir();
        }
        StartCoroutine(beklemek());
    }
    public void Hafiza6()
    {
        for (int i = 0; i < 3; i++)
        {
            scener.kacolduartir();
        }
        StartCoroutine(beklemek());
    }
    public void Hafiza7()
    {
        for (int i = 0; i < 4; i++)
        {
            scener.kacolduartir();
        }
        StartCoroutine(beklemek());
    }
    public void Hafiza8()
    {
        for (int i = 0; i < 5; i++)
        {
            scener.kacolduartir();
        }
        StartCoroutine(beklemek());
    }
    public void HafizaYardir()
    {
        SceneManager.LoadScene(12);
    }
    public void HafizaTab()
    {
        HafizaHub.SetActive(true);
        MainTab.SetActive(false);
        MiniTab.SetActive(false);
    }

    IEnumerator beklemek()
    {
        yield return new WaitForSeconds(0.1f);
        bekledim = true;
    }
}
