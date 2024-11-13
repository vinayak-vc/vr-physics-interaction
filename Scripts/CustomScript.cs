using Autohand;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomScript : MonoBehaviour {
    [SerializeField] private Transform sitPosition;
    [SerializeField] private Transform dropPosition;
    [SerializeField] private GameObject trackables;
    [SerializeField] private AutoHandPlayer autohandplayer;
    private bool isSet;

    // Start is called before the first frame update
    private void Start() {
    }

    // Update is called once per frame
    private void Update() {
    }

    public void SetonLoader() {
        isSet = !isSet;
        //autohandplayer.enabled = !isSet;
        trackables.transform.position = isSet ? sitPosition.position : dropPosition.position;
        autohandplayer.transform.position = trackables.transform.position;
        //trackables.SetActive(isSet);
    }
}