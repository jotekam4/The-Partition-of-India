using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnnouncement : MonoBehaviour
{

    public AudioSource soundPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAnnouncement()
    {
        soundPlayer.Play();
    }
}
