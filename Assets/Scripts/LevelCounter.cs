using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
    public AudioSource kilik;
    public AudioSource kalm;
    public GameObject Congrats;
    public GameObject toMainMenu;
    public float HowMuchPuzzle;
    public AudioSource finish_sound;
    public int NextScene;
    // Start is called before the first frame update
    void Start()
    {
        Congrats.SetActive(false);
        toMainMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LevelCounting()
    {
        HowMuchPuzzle -= 1;
        if (HowMuchPuzzle>0)
        {
            kalm.Play();
        }
        if (HowMuchPuzzle <= 0)
        {
            Congrats.SetActive(true);
            toMainMenu.SetActive(true);
            StartCoroutine(wait());
            finish_sound.Play();
        }
    }
    public void LevelEnder()
    {
        SceneManager.LoadScene(NextScene);
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3); 
        SceneManager.LoadScene(NextScene);
    }
}
