//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/Scripts/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Dialogue"",
            ""id"": ""0d4dc481-4858-4c49-9212-9e605d4aecc5"",
            ""actions"": [
                {
                    ""name"": ""StepForward"",
                    ""type"": ""Button"",
                    ""id"": ""e21ab552-32d6-4815-baa9-ca51187011e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StepBackward"",
                    ""type"": ""Button"",
                    ""id"": ""b6795db9-d4e3-4d52-9ae1-87bd90aedffd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RepeatLine"",
                    ""type"": ""Button"",
                    ""id"": ""ae3b6f38-3d32-4921-a82f-513f68c9ff1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quicksave"",
                    ""type"": ""Button"",
                    ""id"": ""6f5c6e6e-8167-4f85-8ed1-47af3e05bcda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quickload"",
                    ""type"": ""Button"",
                    ""id"": ""df9647f5-12bb-48a1-acb7-2786a8108067"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7dc9b090-6895-47fe-833e-37191a726458"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StepForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6de2a43c-c67a-46df-a795-773f71423c57"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StepBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc255c47-93bf-474d-87d2-b3b2ffc0ab73"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RepeatLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42bcc985-8b36-41ae-a275-b2547f066bee"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Quicksave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6881f8b-aeff-4fd4-bcd2-6f45377e628b"",
                    ""path"": ""<Keyboard>/f9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Quickload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touchscreen"",
            ""bindingGroup"": ""Touchscreen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_StepForward = m_Dialogue.FindAction("StepForward", throwIfNotFound: true);
        m_Dialogue_StepBackward = m_Dialogue.FindAction("StepBackward", throwIfNotFound: true);
        m_Dialogue_RepeatLine = m_Dialogue.FindAction("RepeatLine", throwIfNotFound: true);
        m_Dialogue_Quicksave = m_Dialogue.FindAction("Quicksave", throwIfNotFound: true);
        m_Dialogue_Quickload = m_Dialogue.FindAction("Quickload", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private List<IDialogueActions> m_DialogueActionsCallbackInterfaces = new List<IDialogueActions>();
    private readonly InputAction m_Dialogue_StepForward;
    private readonly InputAction m_Dialogue_StepBackward;
    private readonly InputAction m_Dialogue_RepeatLine;
    private readonly InputAction m_Dialogue_Quicksave;
    private readonly InputAction m_Dialogue_Quickload;
    public struct DialogueActions
    {
        private @PlayerInputActions m_Wrapper;
        public DialogueActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @StepForward => m_Wrapper.m_Dialogue_StepForward;
        public InputAction @StepBackward => m_Wrapper.m_Dialogue_StepBackward;
        public InputAction @RepeatLine => m_Wrapper.m_Dialogue_RepeatLine;
        public InputAction @Quicksave => m_Wrapper.m_Dialogue_Quicksave;
        public InputAction @Quickload => m_Wrapper.m_Dialogue_Quickload;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void AddCallbacks(IDialogueActions instance)
        {
            if (instance == null || m_Wrapper.m_DialogueActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DialogueActionsCallbackInterfaces.Add(instance);
            @StepForward.started += instance.OnStepForward;
            @StepForward.performed += instance.OnStepForward;
            @StepForward.canceled += instance.OnStepForward;
            @StepBackward.started += instance.OnStepBackward;
            @StepBackward.performed += instance.OnStepBackward;
            @StepBackward.canceled += instance.OnStepBackward;
            @RepeatLine.started += instance.OnRepeatLine;
            @RepeatLine.performed += instance.OnRepeatLine;
            @RepeatLine.canceled += instance.OnRepeatLine;
            @Quicksave.started += instance.OnQuicksave;
            @Quicksave.performed += instance.OnQuicksave;
            @Quicksave.canceled += instance.OnQuicksave;
            @Quickload.started += instance.OnQuickload;
            @Quickload.performed += instance.OnQuickload;
            @Quickload.canceled += instance.OnQuickload;
        }

        private void UnregisterCallbacks(IDialogueActions instance)
        {
            @StepForward.started -= instance.OnStepForward;
            @StepForward.performed -= instance.OnStepForward;
            @StepForward.canceled -= instance.OnStepForward;
            @StepBackward.started -= instance.OnStepBackward;
            @StepBackward.performed -= instance.OnStepBackward;
            @StepBackward.canceled -= instance.OnStepBackward;
            @RepeatLine.started -= instance.OnRepeatLine;
            @RepeatLine.performed -= instance.OnRepeatLine;
            @RepeatLine.canceled -= instance.OnRepeatLine;
            @Quicksave.started -= instance.OnQuicksave;
            @Quicksave.performed -= instance.OnQuicksave;
            @Quicksave.canceled -= instance.OnQuicksave;
            @Quickload.started -= instance.OnQuickload;
            @Quickload.performed -= instance.OnQuickload;
            @Quickload.canceled -= instance.OnQuickload;
        }

        public void RemoveCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDialogueActions instance)
        {
            foreach (var item in m_Wrapper.m_DialogueActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DialogueActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchscreenSchemeIndex = -1;
    public InputControlScheme TouchscreenScheme
    {
        get
        {
            if (m_TouchscreenSchemeIndex == -1) m_TouchscreenSchemeIndex = asset.FindControlSchemeIndex("Touchscreen");
            return asset.controlSchemes[m_TouchscreenSchemeIndex];
        }
    }
    public interface IDialogueActions
    {
        void OnStepForward(InputAction.CallbackContext context);
        void OnStepBackward(InputAction.CallbackContext context);
        void OnRepeatLine(InputAction.CallbackContext context);
        void OnQuicksave(InputAction.CallbackContext context);
        void OnQuickload(InputAction.CallbackContext context);
    }
}