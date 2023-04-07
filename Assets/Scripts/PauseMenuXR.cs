using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PauseMenuXR : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    [SerializeField] private videoPlayer360 _SessionMenu;
    [SerializeField] private DiaphragmaticBreathing _diaphtagmaticBreathing;
    private bool isActive;

    private void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        _SessionMenu.pauseMenuTriggered();

    }
}
