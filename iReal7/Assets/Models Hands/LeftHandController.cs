using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;



public enum Handtype
{
    Left,
    Right
}
public class LeftHandController : MonoBehaviour
{
    public Handtype handType;

    private Animator animator;
    private InputDevice inputDevice;

    private float indexValue;
    private float thumbValue;
    private float threeFinguersValue;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        inputDevice = GetInputDevice();
    }

    // Update is called once per frame
    void Update()
    {
        AnimatedHand();
    }

    InputDevice GetInputDevice()
    {
        InputDeviceCharacteristics controllerCharacteristics = InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.Controller;

        if (handType == Handtype.Left)
        {
            controllerCharacteristics = controllerCharacteristics | InputDeviceCharacteristics.Left;
        }
        else
        {
            controllerCharacteristics = controllerCharacteristics | InputDeviceCharacteristics.Right;
        }
        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, inputDevices);

        return inputDevices[0];
    }

    void AnimatedHand()
    {
        inputDevice.TryGetFeatureValue(CommonUsages.trigger, out indexValue);
        inputDevice.TryGetFeatureValue(CommonUsages.grip, out threeFinguersValue);

        animator.SetFloat("Index", indexValue);
        animator.SetFloat("ThreeFinguers", threeFinguersValue);
    }
}
