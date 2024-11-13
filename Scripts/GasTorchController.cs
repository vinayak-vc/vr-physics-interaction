using Autohand;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class GasTorchController : PhysicsGadgetHingeAngleReader {
    public Transform target;
    public TMP_Text valuetext;

    public Vector3 minScale;
    public Vector3 maxScale;

    Vector3 startScale;
    Vector3 lastScale;

    void Start() {
        base.Start();
        startScale = target.transform.localScale;
        lastScale = target.transform.localScale;
    }

    void Update() {
        HandleScale();
    }

    public void HandleScale() {
        var value = GetValue();
        valuetext.text = value.ToString();

        var scaleDiff = target.transform.localScale.magnitude / startScale.magnitude;

        if (value >= 0)
            target.transform.localScale = Vector3.Lerp(startScale, maxScale, value);
        else if (value < 0)
            target.transform.localScale = Vector3.Lerp(startScale, minScale, -value);

        lastScale = target.transform.localScale;
    }

}
