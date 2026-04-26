using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class layoutManager : MonoBehaviour
{
    [SerializeField] List<GameObject> layouts;
    [SerializeField] int activeLayout = -1;
    bool canUpdate = true;

    [SerializeField] 
    InputActionReference cycleLayoutAction;

    private void Awake()
    {
        // Find all GameObjects with the "Layout" tag and store them in the array
        foreach(Transform child in transform)
        {
            layouts.Add(child.gameObject);
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
        activeLayout = (activeLayout + 1) % layouts.Count;
            canUpdate = false;

            for (int i = 0; i < layouts.Count; i++)
            {
                if (i == activeLayout)
                {
                    layouts[i].SetActive(true);
                }
                else
                {
                    layouts[i].SetActive(false);
                }  
            }
    }

    private void OnButtonReleased(InputAction.CallbackContext context)
    {
        canUpdate = true;
    }
}
