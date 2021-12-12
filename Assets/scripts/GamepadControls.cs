// GENERATED AUTOMATICALLY FROM 'Assets/scripst/GamepadControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GamepadControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GamepadControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamepadControls"",
    ""maps"": [
        {
            ""name"": ""Gamepad"",
            ""id"": ""edf71a96-d56a-46f6-8131-9a9320c4be5f"",
            ""actions"": [
                {
                    ""name"": ""Joystickl"",
                    ""type"": ""Value"",
                    ""id"": ""96c5961b-82fd-45c8-93a3-38c94bbe01ee"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Joystickr"",
                    ""type"": ""Value"",
                    ""id"": ""d97f5be2-a87e-4e11-9b33-07aade227d47"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d5571c20-8d66-4f4e-8e98-5dcfea2b9cb7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystickl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1443acae-fb2c-42d1-888c-22c4bf9bb200"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystickr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gamepad
        m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
        m_Gamepad_Joystickl = m_Gamepad.FindAction("Joystickl", throwIfNotFound: true);
        m_Gamepad_Joystickr = m_Gamepad.FindAction("Joystickr", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gamepad
    private readonly InputActionMap m_Gamepad;
    private IGamepadActions m_GamepadActionsCallbackInterface;
    private readonly InputAction m_Gamepad_Joystickl;
    private readonly InputAction m_Gamepad_Joystickr;
    public struct GamepadActions
    {
        private @GamepadControls m_Wrapper;
        public GamepadActions(@GamepadControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Joystickl => m_Wrapper.m_Gamepad_Joystickl;
        public InputAction @Joystickr => m_Wrapper.m_Gamepad_Joystickr;
        public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadActions instance)
        {
            if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
            {
                @Joystickl.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJoystickl;
                @Joystickl.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJoystickl;
                @Joystickl.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJoystickl;
                @Joystickr.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJoystickr;
                @Joystickr.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJoystickr;
                @Joystickr.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnJoystickr;
            }
            m_Wrapper.m_GamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Joystickl.started += instance.OnJoystickl;
                @Joystickl.performed += instance.OnJoystickl;
                @Joystickl.canceled += instance.OnJoystickl;
                @Joystickr.started += instance.OnJoystickr;
                @Joystickr.performed += instance.OnJoystickr;
                @Joystickr.canceled += instance.OnJoystickr;
            }
        }
    }
    public GamepadActions @Gamepad => new GamepadActions(this);
    public interface IGamepadActions
    {
        void OnJoystickl(InputAction.CallbackContext context);
        void OnJoystickr(InputAction.CallbackContext context);
    }
}
