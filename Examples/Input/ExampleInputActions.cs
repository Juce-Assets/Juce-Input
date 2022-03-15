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
            ""name"": ""Actions"",
            ""id"": ""485fd017-307d-4a10-8a68-8f7acc4b25a2"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""f50accb2-7341-4ff0-bb71-7a2714c403c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""989cd36a-57f0-416f-aeb3-173fc62d8b6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""11be8d18-6440-49c5-9b8e-58be8ee316fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""d4bcf274-33b0-4f5e-88bc-da591f362979"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""e8d2a14b-5ba8-4152-9ed7-cf0ee8eb5359"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""657e5d8a-416c-4165-a4bd-9e97be24bfb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""c7ba2af1-bd84-4087-b258-4720fca9e71a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""ca4057e5-1cd0-486a-a451-1bce595353a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""657a3bbe-f0bf-4726-afd2-e18c1f5def80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""W"",
                    ""type"": ""Button"",
                    ""id"": ""dd633814-8b0b-4a20-9319-428c5fc1fdc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Button"",
                    ""id"": ""fde37d73-1814-492f-8678-4bc712f21c30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""f43d0bfb-bb59-451f-afb5-6fbb4cd367db"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""05216f86-1291-4410-90d0-30dea7faf99c"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e098a69-5a3f-4bd7-8236-0df90d1ab86a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa39b5cb-a055-4911-85d8-86b6e10a1781"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18411381-ca21-4bff-bb0d-65b2853e6a1a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a54a23e-7385-4433-9219-dbc01cda01c4"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d628996-9f85-4cc1-aec7-324cc9a3235d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cb1d881-5605-4d9d-bd20-c7e286f2e068"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fce8b164-b621-4d7f-a0f5-7ecc47960537"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f02bd74-9c2b-4c4c-95be-ae3f167e08e9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6dce6d64-0ab0-462f-8fa5-ba8758b8108c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9b3fac6-e7a6-4445-8080-89f13a65b1db"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a32842d-a419-4b59-b009-b9340705d741"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""099f3bb2-6332-4007-a1e2-6f754ce6f812"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1c8f8b9-bf10-423a-a0a1-aca0e365c540"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a966c7bc-3168-4b85-9a4b-d0b7b200b2b5"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffd68894-f386-47c9-9a97-41c94e6756ee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a053241-1b6f-4edb-a98b-325a410e89f1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73a181ec-b3a3-49ba-9fef-a4cb1f49a5a8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
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
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_A = m_Actions.FindAction("A", throwIfNotFound: true);
        m_Actions_B = m_Actions.FindAction("B", throwIfNotFound: true);
        m_Actions_Y = m_Actions.FindAction("Y", throwIfNotFound: true);
        m_Actions_X = m_Actions.FindAction("X", throwIfNotFound: true);
        m_Actions_Left = m_Actions.FindAction("Left", throwIfNotFound: true);
        m_Actions_Right = m_Actions.FindAction("Right", throwIfNotFound: true);
        m_Actions_Up = m_Actions.FindAction("Up", throwIfNotFound: true);
        m_Actions_Down = m_Actions.FindAction("Down", throwIfNotFound: true);
        m_Actions_Start = m_Actions.FindAction("Start", throwIfNotFound: true);
        m_Actions_W = m_Actions.FindAction("W", throwIfNotFound: true);
        m_Actions_S = m_Actions.FindAction("S", throwIfNotFound: true);
        m_Actions_D = m_Actions.FindAction("D", throwIfNotFound: true);
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

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_A;
    private readonly InputAction m_Actions_B;
    private readonly InputAction m_Actions_Y;
    private readonly InputAction m_Actions_X;
    private readonly InputAction m_Actions_Left;
    private readonly InputAction m_Actions_Right;
    private readonly InputAction m_Actions_Up;
    private readonly InputAction m_Actions_Down;
    private readonly InputAction m_Actions_Start;
    private readonly InputAction m_Actions_W;
    private readonly InputAction m_Actions_S;
    private readonly InputAction m_Actions_D;
    public struct ActionsActions
    {
        private @ExampleInputActions m_Wrapper;
        public ActionsActions(@ExampleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Actions_A;
        public InputAction @B => m_Wrapper.m_Actions_B;
        public InputAction @Y => m_Wrapper.m_Actions_Y;
        public InputAction @X => m_Wrapper.m_Actions_X;
        public InputAction @Left => m_Wrapper.m_Actions_Left;
        public InputAction @Right => m_Wrapper.m_Actions_Right;
        public InputAction @Up => m_Wrapper.m_Actions_Up;
        public InputAction @Down => m_Wrapper.m_Actions_Down;
        public InputAction @Start => m_Wrapper.m_Actions_Start;
        public InputAction @W => m_Wrapper.m_Actions_W;
        public InputAction @S => m_Wrapper.m_Actions_S;
        public InputAction @D => m_Wrapper.m_Actions_D;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnB;
                @Y.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnY;
                @X.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnX;
                @Left.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnRight;
                @Up.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnDown;
                @Start.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnStart;
                @W.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnW;
                @W.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnW;
                @W.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnW;
                @S.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnS;
                @S.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnS;
                @S.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnS;
                @D.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnD;
                @D.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnD;
                @D.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnD;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @W.started += instance.OnW;
                @W.performed += instance.OnW;
                @W.canceled += instance.OnW;
                @S.started += instance.OnS;
                @S.performed += instance.OnS;
                @S.canceled += instance.OnS;
                @D.started += instance.OnD;
                @D.performed += instance.OnD;
                @D.canceled += instance.OnD;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);
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
    public interface IActionsActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnW(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
    }
}
