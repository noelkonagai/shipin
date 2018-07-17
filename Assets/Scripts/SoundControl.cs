using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {

    public AudioClip[] audioClips;
    public AudioSource myAudioSource;
    public GameObject BtnObj;
    public Animator buttonAnimator;
    string btnName;

    // Use this for initialization
    void Start () {
        myAudioSource =  GetComponent<AudioSource>();
        buttonAnimator.GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update () {
        if(Input.touchCount > 0 && Input.touches[0].phase ==  TouchPhase.Began)
        {
            Debug.Log("TOUCH");
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "BlueButton":
                        myAudioSource.clip = audioClips[0];
                        myAudioSource.Play();
                        buttonAnimator.Play("onPress");
                        break;
                    case "TestButton":
                        myAudioSource.clip = audioClips[0];
                        myAudioSource.Play();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
