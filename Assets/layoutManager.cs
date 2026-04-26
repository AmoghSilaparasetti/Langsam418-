using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class layoutManager : MonoBehaviour
{
    [SerializeField] List<GameObject> layouts;
    [SerializeField] List<GameObject> layoutImages;
    [SerializeField] GameObject screen;
    [SerializeField] int activeLayout = -1;
    bool canUpdate = true;

    [SerializeField] 
    InputActionReference cycleLayoutAction;

    private void Awake()
    {
        foreach(Transform child in transform)
        {
            layouts.Add(child.gameObject);
        }
        foreach(Transform child in screen.transform)
        {
            layoutImages.Add(child.gameObject);
        }
    }

    private void OnEnable()
    {
        // Subscribe to the "performed" event (triggered when button is pressed)
        cycleLayoutAction.action.performed += OnButtonPressed;
        cycleLayoutAction.action.Enable();
    }

    private void OnDisable()
    {
        // Clean up to avoid memory leaks
        cycleLayoutAction.action.performed -= OnButtonPressed;
        cycleLayoutAction.action.Disable();
    }

    private void OnButtonPressed(InputAction.CallbackContext context)
    {
        activeLayout = (activeLayout + 1) % (layouts.Count + 1);
            canUpdate = false;

            for (int i = 0; i < layouts.Count; i++)
            {
                if (i == activeLayout)
                {
                    layouts[i].SetActive(true);
                    layoutImages[i].SetActive(true);
                }
                else
                {
                    layouts[i].SetActive(false);
                    layoutImages[i].SetActive(false);
                }  
            }
    }

    private void OnButtonReleased(InputAction.CallbackContext context)
    {
        canUpdate = true;
    }
}
