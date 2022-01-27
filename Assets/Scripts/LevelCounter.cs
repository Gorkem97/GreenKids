using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCounter : MonoBehaviour
{
    public GameObject sphere;
    public float HowMuchPuzzle = 3;
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
        if (HowMuchPuzzle <= 0)
        {
            sphere.SetActive(true);
            finish_sound.Play();
        }
    }
}
