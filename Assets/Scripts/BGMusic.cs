using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public AudioClip[] bgMusics;
    public float maxTime;

    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayAudioOnLoop(bgMusics[Random.Range(0, bgMusics.Length)], 0.3F);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= maxTime)
        {
            currentTime = 0;
            AudioManager.instance.PlayAudioOnLoop(bgMusics[Random.Range(0, bgMusics.Length)], 0.3F);
        }
    }
}
