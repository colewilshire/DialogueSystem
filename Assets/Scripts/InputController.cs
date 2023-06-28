using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : Singleton<InputController>
{
    private PlayerInputActions playerInputActions;
    private InputAction stepForwardAction;
    private InputAction stepBackwardAction;
    private InputAction repeatLineAction;

    private void Start()
    {
        EnableInputs();
    }

    private void OnDestroy()
    {
        DisableInputs();
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
