using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    public float time;
    public AudioClip a_coin;
    //public AudioClip a_cave;
    private AudioSource source;
    private int count = 0;


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            source.clip = a_coin;
            source.Play();
        }
       /* if(other.gameObject.CompareTag("Cave"))
        {
            source.clip = a_cave;
            source.Play();
        }*/
    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
        time = 0.0f;
    }

    void Update()
    {
        time += Time.deltaTime;
    }
}
