
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip deletionSound; // Le son de suppression que vous souhaitez jouer
    private AudioSource audioSource;

    // Assurez-vous d'attacher un composant AudioSource � l'objet contenant ce script

    //private void Awake()
    //{
    //    audioSource = GetComponent<AudioSource>();

    //    if (audioSource == null)
    //    {
    //        Debug.LogError("AudioSource non trouv�. Veuillez attacher un AudioSource � l'objet contenant ce script.");
    //    }
    //}
    void Start()
    {
        Debug.LogError("Audio manager");

        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("AudioSource non trouv�. Veuillez attacher un AudioSource � l'objet contenant ce script.");
        }
    }

    public void PlayDeletionSound()
    {
        Debug.LogError("PlayDeletionSound");

        if (deletionSound != null && audioSource != null)
        {
            Debug.LogError("deletionSound");

            audioSource.PlayOneShot(deletionSound);
        }
        else
        {
            Debug.LogError("Le son de suppression ou AudioSource n'est pas configur�. Veuillez v�rifier la configuration de l'AudioManager.");
        }
    }
}
