// GENERATED AUTOMATICALLY FROM 'Assets/Juce-Input/Examples/Input/ExampleInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ExampleInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ExampleInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ExampleInputActions"",
    ""maps"": [
        {
            ""name"": ""ActionA"",
            ""id"": ""485fd017-307d-4a10-8a68-8f7acc4b25a2"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""f50accb2-7341-4ff0-bb71-7a2714c403c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2013a855-d674-4eda-8f32-cabcee2b4823"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7f9d410-31f0-4c7d-9d36-6954d102e858"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ActionDPad"",
            ""id"": ""e86b7f24-a239-4bef-8c15-b51dd2471007"",
            ""actions"": [
                {
                    ""name"": ""DPadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e5ef9a52-29b2-4c17-8b28-03ca8e027ac8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0d1b1e5d-ae81-471f-81d1-10ea1b50162f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""DPadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // ActionA
        m_ActionA = asset.FindActionMap("ActionA", throwIfNotFound: true);
        m_ActionA_A = m_ActionA.FindAction("A", throwIfNotFound: true);
        // ActionDPad
        m_ActionDPad = asset.FindActionMap("ActionDPad", throwIfNotFound: true);
        m_ActionDPad_DPadLeft = m_ActionDPad.FindAction("DPadLeft", throwIfNotFound: true);
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

    // ActionA
    private readonly InputActionMap m_ActionA;
    private IActionAActions m_ActionAActionsCallbackInterface;
    private readonly InputAction m_ActionA_A;
    public struct ActionAActions
    {
        private @ExampleInputActions m_Wrapper;
        public ActionAActions(@ExampleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_ActionA_A;
        public InputActionMap Get() { return m_Wrapper.m_ActionA; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionAActions set) { return set.Get(); }
        public void SetCallbacks(IActionAActions instance)
        {
            if (m_Wrapper.m_ActionAActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_ActionAActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_ActionAActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_ActionAActionsCallbackInterface.OnA;
            }
            m_Wrapper.m_ActionAActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
            }
        }
    }
    public ActionAActions @ActionA => new ActionAActions(this);

    // ActionDPad
    private readonly InputActionMap m_ActionDPad;
    private IActionDPadActions m_ActionDPadActionsCallbackInterface;
    private readonly InputAction m_ActionDPad_DPadLeft;
    public struct ActionDPadActions
    {
        private @ExampleInputActions m_Wrapper;
        public ActionDPadActions(@ExampleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @DPadLeft => m_Wrapper.m_ActionDPad_DPadLeft;
        public InputActionMap Get() { return m_Wrapper.m_ActionDPad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionDPadActions set) { return set.Get(); }
        public void SetCallbacks(IActionDPadActions instance)
        {
            if (m_Wrapper.m_ActionDPadActionsCallbackInterface != null)
            {
                @DPadLeft.started -= m_Wrapper.m_ActionDPadActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.performed -= m_Wrapper.m_ActionDPadActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.canceled -= m_Wrapper.m_ActionDPadActionsCallbackInterface.OnDPadLeft;
            }
            m_Wrapper.m_ActionDPadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DPadLeft.started += instance.OnDPadLeft;
                @DPadLeft.performed += instance.OnDPadLeft;
                @DPadLeft.canceled += instance.OnDPadLeft;
            }
        }
    }
    public ActionDPadActions @ActionDPad => new ActionDPadActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IActionAActions
    {
        void OnA(InputAction.CallbackContext context);
    }
    public interface IActionDPadActions
    {
        void OnDPadLeft(InputAction.CallbackContext context);
    }
}
