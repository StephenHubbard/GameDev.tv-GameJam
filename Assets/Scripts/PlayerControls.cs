// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""98e544d3-6109-4bc8-b8f2-af82d6832fdc"",
            ""actions"": [
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""4dc171ef-59f3-4fc6-9126-700dd9554a78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20b19aac-ea33-4857-b544-57ca8e6ba11c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Hotbar"",
            ""id"": ""4ad0eedc-a70f-4704-9f51-a4702f68484c"",
            ""actions"": [
                {
                    ""name"": ""KeySelection_1"",
                    ""type"": ""Button"",
                    ""id"": ""46d037e1-ea31-4a2c-a175-6f638e3a497a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeySelection_2"",
                    ""type"": ""Button"",
                    ""id"": ""25188bbd-ebc8-47f5-9e9f-c8cffe4850fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeySelection_3"",
                    ""type"": ""Button"",
                    ""id"": ""9f82a8b1-1ec2-4e07-b7d7-8ec8be7783e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""be0bbef7-d53f-4625-ba0c-f423af465515"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeySelection_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee760c73-888d-45fb-9631-c43779a5cfda"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeySelection_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb8d0a96-fb2a-44c4-9717-d7b94aa696d6"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeySelection_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Action = m_PlayerActions.FindAction("Action", throwIfNotFound: true);
        // Hotbar
        m_Hotbar = asset.FindActionMap("Hotbar", throwIfNotFound: true);
        m_Hotbar_KeySelection_1 = m_Hotbar.FindAction("KeySelection_1", throwIfNotFound: true);
        m_Hotbar_KeySelection_2 = m_Hotbar.FindAction("KeySelection_2", throwIfNotFound: true);
        m_Hotbar_KeySelection_3 = m_Hotbar.FindAction("KeySelection_3", throwIfNotFound: true);
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

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Action;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action => m_Wrapper.m_PlayerActions_Action;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Action.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // Hotbar
    private readonly InputActionMap m_Hotbar;
    private IHotbarActions m_HotbarActionsCallbackInterface;
    private readonly InputAction m_Hotbar_KeySelection_1;
    private readonly InputAction m_Hotbar_KeySelection_2;
    private readonly InputAction m_Hotbar_KeySelection_3;
    public struct HotbarActions
    {
        private @PlayerControls m_Wrapper;
        public HotbarActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @KeySelection_1 => m_Wrapper.m_Hotbar_KeySelection_1;
        public InputAction @KeySelection_2 => m_Wrapper.m_Hotbar_KeySelection_2;
        public InputAction @KeySelection_3 => m_Wrapper.m_Hotbar_KeySelection_3;
        public InputActionMap Get() { return m_Wrapper.m_Hotbar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HotbarActions set) { return set.Get(); }
        public void SetCallbacks(IHotbarActions instance)
        {
            if (m_Wrapper.m_HotbarActionsCallbackInterface != null)
            {
                @KeySelection_1.started -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_1;
                @KeySelection_1.performed -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_1;
                @KeySelection_1.canceled -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_1;
                @KeySelection_2.started -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_2;
                @KeySelection_2.performed -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_2;
                @KeySelection_2.canceled -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_2;
                @KeySelection_3.started -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_3;
                @KeySelection_3.performed -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_3;
                @KeySelection_3.canceled -= m_Wrapper.m_HotbarActionsCallbackInterface.OnKeySelection_3;
            }
            m_Wrapper.m_HotbarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @KeySelection_1.started += instance.OnKeySelection_1;
                @KeySelection_1.performed += instance.OnKeySelection_1;
                @KeySelection_1.canceled += instance.OnKeySelection_1;
                @KeySelection_2.started += instance.OnKeySelection_2;
                @KeySelection_2.performed += instance.OnKeySelection_2;
                @KeySelection_2.canceled += instance.OnKeySelection_2;
                @KeySelection_3.started += instance.OnKeySelection_3;
                @KeySelection_3.performed += instance.OnKeySelection_3;
                @KeySelection_3.canceled += instance.OnKeySelection_3;
            }
        }
    }
    public HotbarActions @Hotbar => new HotbarActions(this);
    public interface IPlayerActionsActions
    {
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IHotbarActions
    {
        void OnKeySelection_1(InputAction.CallbackContext context);
        void OnKeySelection_2(InputAction.CallbackContext context);
        void OnKeySelection_3(InputAction.CallbackContext context);
    }
}
