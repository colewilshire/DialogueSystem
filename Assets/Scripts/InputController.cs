using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputController : Singleton<InputController>
{
    private PlayerInputActions playerInputActions;
    private InputAction stepForwardAction;
    private InputAction stepBackwardAction;
    private InputAction repeatLineAction;
    [SerializeField] private Button stepForwardButton;
    [SerializeField] private Button stepBackwardButton;
    [SerializeField] private Button repeatLineButton;

    private void Start()
    {
        EnableInputs();
        SetUpButtons();
    }

    private void OnDestroy()
    {
        DisableInputs();
        TearDownButtons();
    }

    private void EnableInputs()
    {
        playerInputActions = new PlayerInputActions();
        stepForwardAction = playerInputActions.Dialogue.StepForward;
        stepBackwardAction = playerInputActions.Dialogue.StepBackward;
        repeatLineAction = playerInputActions.Dialogue.RepeatLine;

        stepForwardAction.performed += OnStepForward;
        stepBackwardAction.performed += OnStepBackward;
        repeatLineAction.performed += OnRepeatLine;

        stepForwardAction.Enable();
        stepBackwardAction.Enable();
        repeatLineAction.Enable();
    }

    private void DisableInputs()
    {
        stepForwardAction.performed -= OnStepForward;
        stepBackwardAction.performed -= OnStepBackward;
        repeatLineAction.performed -= OnRepeatLine;

        stepForwardAction.Disable();
        stepBackwardAction.Disable();
        repeatLineAction.Disable();
    }

    private void SetUpButtons()
    {
        if (stepForwardButton)
        {
            stepForwardButton.onClick.AddListener(DialogueController.Instance.StepForward);
        }

        if (stepBackwardButton)
        {
            stepBackwardButton.onClick.AddListener(DialogueController.Instance.StepBackward);
        }

        if (repeatLineButton)
        {
            repeatLineButton.onClick.AddListener(DialogueController.Instance.RepeatLine);
        }
    }

    private void TearDownButtons()
    {
        if (stepForwardButton)
        {
            stepForwardButton.onClick.RemoveListener(DialogueController.Instance.StepForward);
        }

        if (stepBackwardButton)
        {
            stepBackwardButton.onClick.RemoveListener(DialogueController.Instance.StepBackward);
        }

        if (repeatLineButton)
        {
            repeatLineButton.onClick.RemoveListener(DialogueController.Instance.RepeatLine);
        }
    }

    private void OnStepForward(InputAction.CallbackContext context)
    {
        DialogueController.Instance.StepForward();
    }

    private void OnStepBackward(InputAction.CallbackContext context)
    {
        DialogueController.Instance.StepBackward();
    }

    private void OnRepeatLine(InputAction.CallbackContext context)
    {
        DialogueController.Instance.RepeatLine();
    }
}
