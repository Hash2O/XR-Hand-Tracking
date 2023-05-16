using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playingChord : MonoBehaviour
{
    [SerializeField] AudioSource chordAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("hand"))
        {
            Debug.Log("Contact corde : " + gameObject.name);
            chordAudioSource.Play();
        }
    }
}
