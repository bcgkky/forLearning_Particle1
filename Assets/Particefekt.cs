using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particefekt : MonoBehaviour
{
    ParticleSystem parct;

    void Start()
    {
        parct = GetComponent<ParticleSystem>();

    }

    void OnParticleTrigger()
    {
        print("elleme");
    }

    void OnParticleCollision(GameObject other)
    {
        if (!other.CompareTag("ParTag"))
        {
            Destroy(other.gameObject);
            print(other.gameObject.name);
        }
    }
    void OnParticleSystemStopped()
    {
        print("efettin bitti brom.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            parct.Stop();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            parct.Play();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            parct.Pause();
        }

    }
}
