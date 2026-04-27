using NUnit.Framework;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class HumanText : MonoBehaviour
{
    public GameObject Canvas;
    public List<String> Dialouges;
    public TMP_Text Text;
    private int step = 0;
    private Vector3 fixedWorldPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fixedWorldPosition = Canvas.transform.position;
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Transform target = GameObject.Find("CenterEyeAnchor").transform;
        Canvas.transform.position = fixedWorldPosition;

        // The rotation logic remains the same
        Vector3 directionAwayFromTarget = Canvas.transform.position - target.position;
        directionAwayFromTarget.y = 0f;

        if (directionAwayFromTarget != Vector3.zero)
        {
            Canvas.transform.rotation = Quaternion.LookRotation(directionAwayFromTarget);
        }
    }

    public void nextDialouge()
    {
        if (step == 0) {
            Canvas.SetActive(true);
            Text.text = Dialouges[step];
            step++;
        } else if (step == Dialouges.Count)
        {
            Canvas.SetActive(false);
            step = 0;
        }
        else
        {
            Text.text = Dialouges[step];
            step++;
        }
    }
}
