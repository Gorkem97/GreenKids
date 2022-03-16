using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_UIControl : MonoBehaviour
{
    public Animator transition;
    public float transitiontime;


    public GameObject MainTab;
    public GameObject MiniTab;
    public GameObject HafizaHub;
    public GameObject Credits;
    public LevelManager seviyeler;

    public GameObject message;

    public SahneDuzeni scener;

    bool bekledim;

    void Start()
    {
        scener.LanguageIdentifier();
        if (SceneManager.GetActiveScene().name == "Main")
        {
            CloseTab();
        }
    }
    private void Update()
    {
        if (bekledim == true)
        {
            SceneManager.LoadScene(13);
            bekledim = false;
        }
    }
    public void SceneOpener(int sceneNumber)
    {
        StartCoroutine(LoadLevel(sceneNumber));
    }
    public void MiniGame()
    {
        MiniTab.SetActive(true);
        MainTab.SetActive(false);
    }
    public void CloseTab()
    {
        MainTab.SetActive(true);
        Credits.SetActive(false);
        MiniTab.SetActive(false);
        HafizaHub.SetActive(false);
    }
    public void Hafiza4(int kacli)
    {
        for (int i = 0; i < kacli-2; i++)
        {
            scener.kacolduartir();
        }
        StartCoroutine(beklemek());
    }
    public void HafizaTab()
    {
        HafizaHub.SetActive(true);
        MainTab.SetActive(false);
        MiniTab.SetActive(false);
    }
    public void creditTab()
    {

        Credits.SetActive(true);
        MainTab.SetActive(false);
        MiniTab.SetActive(false);
    }


    IEnumerator beklemek()
    {
        yield return new WaitForSeconds(0.1f);
        bekledim = true;
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Change");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(levelIndex);
    }
}
