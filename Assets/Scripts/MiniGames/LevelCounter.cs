using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
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
        if (sulamami == true)
        {

        }
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
        SceneManager.LoadScene(NextScene);
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3); 
        SceneManager.LoadScene(NextScene);
    }
    public void LevelReloader()
    {
        SceneManager.LoadScene(0);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
