//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player1Map"",
            ""id"": ""d7402c5d-0cb5-4b7e-8d88-72a3ce22ab5b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""4fc667d3-03d0-47d9-b66b-8c75f57bb555"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UseCard"",
                    ""type"": ""Button"",
                    ""id"": ""b0a05565-1859-4ab2-9ed0-b6a93cd645fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeCards"",
                    ""type"": ""Button"",
                    ""id"": ""4f731414-ab45-4ed4-86db-fccabd83e35b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""5fa66e09-dc14-4e48-a7dd-dc37874697d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""821b39b9-dd24-4f6c-af67-45c539ac985e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseCard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4f1e4f52-052e-4708-b264-4c96cab48cea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""69b910b2-1034-48c0-9f89-0d0a9aa6561e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c80ef954-9918-4946-b336-c67d61a92a79"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""89c7a907-b3a2-47d2-9fd4-9c4bbed474c6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d9d7f7ac-8a14-4ac2-bfb6-6eab5c72ef91"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""452154b4-4609-4ba0-b47c-ef7602209d91"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCards"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cc251541-8922-4bd9-98a1-1b10eb289525"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""45d29fa4-bb47-4bf9-aac4-0d8e20f9d942"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5b75084f-aacc-41ef-a798-b84485d1d948"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2Map"",
            ""id"": ""d950bbec-6bd2-4272-a4cb-971ef7d75f61"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""6259a94f-f4ef-41de-824a-175f88f3a4b7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UseCard"",
                    ""type"": ""Button"",
                    ""id"": ""f7eac715-e78b-4eb5-abd7-7d542aace669"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeCards"",
                    ""type"": ""Button"",
                    ""id"": ""2c47ca21-a15f-4eba-aba8-1da6e9dff97c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""ff4e66b0-6b44-4d66-8277-f7d04b447f3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""520d07e4-21a6-4b71-b7ef-03045ac406ff"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseCard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3e8cb979-da46-41b3-a9c2-f354681b1616"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0cea00a2-8955-4745-859a-aebc39ad0b15"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d8e3bbf8-ec65-478c-a5cf-f78fd749d9dd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8d901f1a-751a-4cc8-ab2c-95b46f38c142"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1956d55-48e8-43e2-a404-4bd7134f0eaf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9b7270b3-b64a-43d2-be2b-8eb7e8dd9cd1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCards"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""249cd2c7-7701-481f-bdbc-7abc057fa166"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b645d790-efc1-45db-961c-d5f132c7539e"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""db3d0576-25c2-45a4-95e1-a8b4142806ef"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1Map
        m_Player1Map = asset.FindActionMap("Player1Map", throwIfNotFound: true);
        m_Player1Map_Movement = m_Player1Map.FindAction("Movement", throwIfNotFound: true);
        m_Player1Map_UseCard = m_Player1Map.FindAction("UseCard", throwIfNotFound: true);
        m_Player1Map_ChangeCards = m_Player1Map.FindAction("ChangeCards", throwIfNotFound: true);
        m_Player1Map_Reload = m_Player1Map.FindAction("Reload", throwIfNotFound: true);
        // Player2Map
        m_Player2Map = asset.FindActionMap("Player2Map", throwIfNotFound: true);
        m_Player2Map_Movement = m_Player2Map.FindAction("Movement", throwIfNotFound: true);
        m_Player2Map_UseCard = m_Player2Map.FindAction("UseCard", throwIfNotFound: true);
        m_Player2Map_ChangeCards = m_Player2Map.FindAction("ChangeCards", throwIfNotFound: true);
        m_Player2Map_Reload = m_Player2Map.FindAction("Reload", throwIfNotFound: true);
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

    // Player1Map
    private readonly InputActionMap m_Player1Map;
    private List<IPlayer1MapActions> m_Player1MapActionsCallbackInterfaces = new List<IPlayer1MapActions>();
    private readonly InputAction m_Player1Map_Movement;
    private readonly InputAction m_Player1Map_UseCard;
    private readonly InputAction m_Player1Map_ChangeCards;
    private readonly InputAction m_Player1Map_Reload;
    public struct Player1MapActions
    {
        private @PlayerControls m_Wrapper;
        public Player1MapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player1Map_Movement;
        public InputAction @UseCard => m_Wrapper.m_Player1Map_UseCard;
        public InputAction @ChangeCards => m_Wrapper.m_Player1Map_ChangeCards;
        public InputAction @Reload => m_Wrapper.m_Player1Map_Reload;
        public InputActionMap Get() { return m_Wrapper.m_Player1Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1MapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayer1MapActions instance)
        {
            if (instance == null || m_Wrapper.m_Player1MapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player1MapActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @UseCard.started += instance.OnUseCard;
            @UseCard.performed += instance.OnUseCard;
            @UseCard.canceled += instance.OnUseCard;
            @ChangeCards.started += instance.OnChangeCards;
            @ChangeCards.performed += instance.OnChangeCards;
            @ChangeCards.canceled += instance.OnChangeCards;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
        }

        private void UnregisterCallbacks(IPlayer1MapActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @UseCard.started -= instance.OnUseCard;
            @UseCard.performed -= instance.OnUseCard;
            @UseCard.canceled -= instance.OnUseCard;
            @ChangeCards.started -= instance.OnChangeCards;
            @ChangeCards.performed -= instance.OnChangeCards;
            @ChangeCards.canceled -= instance.OnChangeCards;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
        }

        public void RemoveCallbacks(IPlayer1MapActions instance)
        {
            if (m_Wrapper.m_Player1MapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer1MapActions instance)
        {
            foreach (var item in m_Wrapper.m_Player1MapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player1MapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player1MapActions @Player1Map => new Player1MapActions(this);

    // Player2Map
    private readonly InputActionMap m_Player2Map;
    private List<IPlayer2MapActions> m_Player2MapActionsCallbackInterfaces = new List<IPlayer2MapActions>();
    private readonly InputAction m_Player2Map_Movement;
    private readonly InputAction m_Player2Map_UseCard;
    private readonly InputAction m_Player2Map_ChangeCards;
    private readonly InputAction m_Player2Map_Reload;
    public struct Player2MapActions
    {
        private @PlayerControls m_Wrapper;
        public Player2MapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player2Map_Movement;
        public InputAction @UseCard => m_Wrapper.m_Player2Map_UseCard;
        public InputAction @ChangeCards => m_Wrapper.m_Player2Map_ChangeCards;
        public InputAction @Reload => m_Wrapper.m_Player2Map_Reload;
        public InputActionMap Get() { return m_Wrapper.m_Player2Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2MapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayer2MapActions instance)
        {
            if (instance == null || m_Wrapper.m_Player2MapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player2MapActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @UseCard.started += instance.OnUseCard;
            @UseCard.performed += instance.OnUseCard;
            @UseCard.canceled += instance.OnUseCard;
            @ChangeCards.started += instance.OnChangeCards;
            @ChangeCards.performed += instance.OnChangeCards;
            @ChangeCards.canceled += instance.OnChangeCards;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
        }

        private void UnregisterCallbacks(IPlayer2MapActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @UseCard.started -= instance.OnUseCard;
            @UseCard.performed -= instance.OnUseCard;
            @UseCard.canceled -= instance.OnUseCard;
            @ChangeCards.started -= instance.OnChangeCards;
            @ChangeCards.performed -= instance.OnChangeCards;
            @ChangeCards.canceled -= instance.OnChangeCards;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
        }

        public void RemoveCallbacks(IPlayer2MapActions instance)
        {
            if (m_Wrapper.m_Player2MapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer2MapActions instance)
        {
            foreach (var item in m_Wrapper.m_Player2MapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player2MapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player2MapActions @Player2Map => new Player2MapActions(this);
    public interface IPlayer1MapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnUseCard(InputAction.CallbackContext context);
        void OnChangeCards(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IPlayer2MapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnUseCard(InputAction.CallbackContext context);
        void OnChangeCards(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
}
