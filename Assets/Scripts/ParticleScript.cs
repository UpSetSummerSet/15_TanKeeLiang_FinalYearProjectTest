using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    private new ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            particleSystem.time = 0;
            particleSystem.Play();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            particleSystem.time = 0;
            particleSystem.Stop();
        }
    }
}
