using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
    public AudioSource kilik;
    public AudioSource kalm;
    public GameObject ReplayButton;
    public GameObject sphere;
    public float HowMuchPuzzle = 6;
    public AudioSource finish_sound;
    // Start is called before the first frame update
    void Start()
    {
        
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
            sphere.SetActive(true);
            ReplayButton.SetActive(true);
            finish_sound.Play();
        }
    }
    public void LevelEnder()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {

        yield return new WaitForSeconds(0.1f); 
        SceneManager.LoadScene(0);
    }
}
