using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private ParticleSystem particle;
    private MeshRenderer mr;
    public GameManager gm;
    private BoxCollider bc;
    AudioSource Audio;

    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        mr = GetComponent<MeshRenderer>();
        bc = GetComponent<BoxCollider>();
        Audio = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            StartCoroutine( Break());
            gm.UpdateNumberOfBricks();
            Audio.Play();   
        }
    }

    private IEnumerator Break()
    {
        particle.Play();

        mr.enabled = false;

        bc.enabled = false;

        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);

        Destroy(gameObject);

    }

}
