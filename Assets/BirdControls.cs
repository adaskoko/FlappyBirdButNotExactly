// GENERATED AUTOMATICALLY FROM 'Assets/BirdControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BirdControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BirdControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BirdControls"",
    ""maps"": [
        {
            ""name"": ""Bird"",
            ""id"": ""87294ead-d9da-4217-bca5-fc5c0ef47ac6"",
            ""actions"": [
                {
                    ""name"": ""FlyUp"",
                    ""type"": ""Button"",
                    ""id"": ""174a9b57-77b5-4922-879f-740b1fa15b37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""130d0a6d-bbb9-42dc-b32f-949e1612748c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""22ac9395-6bb5-4176-9278-d1cd2107fd79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""660a1922-da38-4f15-aa18-83aca3337fdf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b493a48e-2eac-40b3-9bb2-ce6b349bbb08"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5809610-5b4e-4b8e-b263-14b619090fd2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d9988b0-e069-4b0f-8700-1782d8421391"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5690d42-1159-49ee-9a0b-635ccd8d6bcf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""05046cec-c8fd-4d55-9ad8-b3fb1c09e788"",
            ""actions"": [
                {
                    ""name"": ""Level1"",
                    ""type"": ""Button"",
                    ""id"": ""6e449b42-ce00-4192-a8f3-74db02242c53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Level2"",
                    ""type"": ""Button"",
                    ""id"": ""a7769c91-a853-4d37-afc7-7fb85a96f813"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""68ae276b-3d5e-4b32-b14e-ce677c3b8b02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SoundUp"",
                    ""type"": ""Button"",
                    ""id"": ""71c52d87-3110-424b-b896-71614450839c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SoundDown"",
                    ""type"": ""Button"",
                    ""id"": ""f9db0d22-4713-463b-a47e-529206714983"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d0f2e5fa-d6b7-4da6-a3b7-ee2da8c0972c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Level1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d174cc9f-b2b9-4e6b-a40c-b8f00c2c2534"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Level2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""373476d7-adbb-4820-a792-54816e6c7840"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df0b49fb-654a-4549-a0c2-df739c5aa2ac"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SoundUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fbc33dc-dde0-496a-b1d3-10b6c546c9ba"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SoundDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bird
        m_Bird = asset.FindActionMap("Bird", throwIfNotFound: true);
        m_Bird_FlyUp = m_Bird.FindAction("FlyUp", throwIfNotFound: true);
        m_Bird_MoveRight = m_Bird.FindAction("MoveRight", throwIfNotFound: true);
        m_Bird_MoveLeft = m_Bird.FindAction("MoveLeft", throwIfNotFound: true);
        m_Bird_Shoot = m_Bird.FindAction("Shoot", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Level1 = m_Menu.FindAction("Level1", throwIfNotFound: true);
        m_Menu_Level2 = m_Menu.FindAction("Level2", throwIfNotFound: true);
        m_Menu_Menu = m_Menu.FindAction("Menu", throwIfNotFound: true);
        m_Menu_SoundUp = m_Menu.FindAction("SoundUp", throwIfNotFound: true);
        m_Menu_SoundDown = m_Menu.FindAction("SoundDown", throwIfNotFound: true);
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

    // Bird
    private readonly InputActionMap m_Bird;
    private IBirdActions m_BirdActionsCallbackInterface;
    private readonly InputAction m_Bird_FlyUp;
    private readonly InputAction m_Bird_MoveRight;
    private readonly InputAction m_Bird_MoveLeft;
    private readonly InputAction m_Bird_Shoot;
    public struct BirdActions
    {
        private @BirdControls m_Wrapper;
        public BirdActions(@BirdControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FlyUp => m_Wrapper.m_Bird_FlyUp;
        public InputAction @MoveRight => m_Wrapper.m_Bird_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_Bird_MoveLeft;
        public InputAction @Shoot => m_Wrapper.m_Bird_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Bird; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdActions set) { return set.Get(); }
        public void SetCallbacks(IBirdActions instance)
        {
            if (m_Wrapper.m_BirdActionsCallbackInterface != null)
            {
                @FlyUp.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlyUp;
                @FlyUp.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlyUp;
                @FlyUp.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlyUp;
                @MoveRight.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnMoveLeft;
                @Shoot.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_BirdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FlyUp.started += instance.OnFlyUp;
                @FlyUp.performed += instance.OnFlyUp;
                @FlyUp.canceled += instance.OnFlyUp;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public BirdActions @Bird => new BirdActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Level1;
    private readonly InputAction m_Menu_Level2;
    private readonly InputAction m_Menu_Menu;
    private readonly InputAction m_Menu_SoundUp;
    private readonly InputAction m_Menu_SoundDown;
    public struct MenuActions
    {
        private @BirdControls m_Wrapper;
        public MenuActions(@BirdControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Level1 => m_Wrapper.m_Menu_Level1;
        public InputAction @Level2 => m_Wrapper.m_Menu_Level2;
        public InputAction @Menu => m_Wrapper.m_Menu_Menu;
        public InputAction @SoundUp => m_Wrapper.m_Menu_SoundUp;
        public InputAction @SoundDown => m_Wrapper.m_Menu_SoundDown;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Level1.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnLevel1;
                @Level1.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnLevel1;
                @Level1.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnLevel1;
                @Level2.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnLevel2;
                @Level2.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnLevel2;
                @Level2.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnLevel2;
                @Menu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @SoundUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSoundUp;
                @SoundUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSoundUp;
                @SoundUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSoundUp;
                @SoundDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSoundDown;
                @SoundDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSoundDown;
                @SoundDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSoundDown;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Level1.started += instance.OnLevel1;
                @Level1.performed += instance.OnLevel1;
                @Level1.canceled += instance.OnLevel1;
                @Level2.started += instance.OnLevel2;
                @Level2.performed += instance.OnLevel2;
                @Level2.canceled += instance.OnLevel2;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @SoundUp.started += instance.OnSoundUp;
                @SoundUp.performed += instance.OnSoundUp;
                @SoundUp.canceled += instance.OnSoundUp;
                @SoundDown.started += instance.OnSoundDown;
                @SoundDown.performed += instance.OnSoundDown;
                @SoundDown.canceled += instance.OnSoundDown;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IBirdActions
    {
        void OnFlyUp(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnLevel1(InputAction.CallbackContext context);
        void OnLevel2(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnSoundUp(InputAction.CallbackContext context);
        void OnSoundDown(InputAction.CallbackContext context);
    }
}
