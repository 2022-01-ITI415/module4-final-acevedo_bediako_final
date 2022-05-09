using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    public float time;
    public AudioClip audio;
    private AudioSource m_source;
    private int count = 0;


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            m_source.clip = audio;
            m_source.Play();
        }
    }

    void Awake()
    {
        time = 0.0f;
    }

    void Update()
    {
        time += Time.deltaTime;
    }
}
