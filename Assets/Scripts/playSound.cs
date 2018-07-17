using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class playSound : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject vbBtnObj;
    public AudioSource chineseAudio;

    // Use this for initialization
    void Start () {
        vbBtnObj = GameObject.Find("Play1");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        chineseAudio.GetComponent<AudioSource>();
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        chineseAudio.Play();
        Debug.Log("Audio is playing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Debug.Log("Button released");        
    }

    // Update is called once per frame
    void Update () {
        
    }
}