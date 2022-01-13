using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthyScript : MonoBehaviour
{

    private AudioSource healthySound;
    // Start is called before the first frame update
    void Start()
    {
        healthySound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            healthySound.Play();
        }
    }
}
