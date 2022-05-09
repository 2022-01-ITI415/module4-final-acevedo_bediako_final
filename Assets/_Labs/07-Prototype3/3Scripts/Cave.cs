using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cave : MonoBehaviour
{
    public int num;
    public AudioClip a_cave;
    private AudioSource source;

    void Awake()
    {
        source.clip = a_cave;
        source.Play();
    }

    public void RandomGen()
    {
        num = Random.Range(1,3);
    }
    // Update is called once per frame
    void Update()
    {
        RandomGen();
        if(num == 1)
        {
            gameObject.SetActive(false);
        }else{
            gameObject.SetActive(true);
        }
    }
}
