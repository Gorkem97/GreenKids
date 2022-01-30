using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
    public AudioSource kilik;
    public AudioSource kalm;
    public GameObject ReplayButton;
    public float HowMuchPuzzle;
    public AudioSource finish_sound;
    public int thisScene;
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
        SceneManager.LoadScene(thisScene);
    }
}
