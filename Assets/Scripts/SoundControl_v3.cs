using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl_v3 : MonoBehaviour {

    public AudioClip[] audioClips;
    public AudioSource myAudioSource;
    public GameObject BtnObj;
    string btnName;

    // Use this for initialization
    void Start () {
        myAudioSource =  GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update () {
        print("It is starting");
        Debug.Log("Debug Prints");
        if(Input.touchCount > 0 && Input.touches[0].phase ==  TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                Debug.Log(Hit.collider);

                switch (btnName)
                {
                    case "TestButton":
                        myAudioSource.clip = audioClips[0];
                        myAudioSource.Play();
                        break;
                    case "Canvas":
                        myAudioSource.clip = audioClips[1];
                        myAudioSource.Play();
                        break;
                    default:
                        break;
                }
            }
            if (Hit.collider == null){
                Debug.Log("Raycast hit nothing");
            }
        }
    }
}
