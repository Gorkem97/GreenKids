using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
    public Animator transition;
    public float transitiontime = 1;

    public bool sulamami = false;
    public AudioSource kilik;
    public AudioSource kalm;
    public GameObject Congrats;
    public GameObject toMainMenu;
    public GameObject DONBUTTON;
    public float HowMuchPuzzle;
    public AudioSource finish_sound;
    public int NextScene;
    // Start is called before the first frame update
    void Start()
    {
        DONBUTTON.SetActive(true);
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
            DONBUTTON.SetActive(false);
            Congrats.SetActive(true);
            toMainMenu.SetActive(true);
            if (NextScene !=0)
            {
                StartCoroutine(wait());
            }
            finish_sound.Play();
        }
    }
    public void LevelEnder()
    {
        StartCoroutine(Reload(NextScene));
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        transition.SetTrigger("Change");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(NextScene);
    }
    public void LevelReloader()
    {
        StartCoroutine(Reload(0));
    }
    public void AlternateEnd()
    {

        DONBUTTON.SetActive(false);
        Congrats.SetActive(true);
        toMainMenu.SetActive(true);
        finish_sound.Play();
    }
    public void Replay()
    {
        StartCoroutine(Reload(SceneManager.GetActiveScene().buildIndex));
    }
    IEnumerator Reload(int gidecekalan)
    {

        transition.SetTrigger("Change");
        yield return new WaitForSeconds(transitiontime);
        SceneManager.LoadScene(gidecekalan);
    }
}
