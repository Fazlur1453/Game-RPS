using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private AnimationController animatorController;
    [SerializeField] private GameplayController gameController;
    private string playersChoice;

    void Awake()
    {
        
        UnityEngine.UI.Selectable firstSelectable = FindObjectOfType<UnityEngine.UI.Selectable>();
        UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(firstSelectable.gameObject);
    }


    public void GetChoice()
    {
        GameObject currentObject = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        if (currentObject == null)
        {
            Debug.Log("No object is currently selected.");
            return;
        }
        string choiceName = currentObject.name;
        GameChoices selectedChoice = GameChoices.NONE;

        //Debug.Log("=== Get Choice ===");
        switch (choiceName)
        {
            case "Rock":
                selectedChoice = GameChoices.ROCK;
                //Debug.Log("==== I choose ROCK.");
                break;
            case "Paper":
                selectedChoice = GameChoices.PAPER;
                //Debug.Log("==== I choose PAPER.");
                break;
            case "Scissors":
                selectedChoice = GameChoices.SCISSORS;
                //Debug.Log("==== I choose SCISSORS.");
                break;
        }

        //Debug.Log("=== My Game Controller = " + gameController);
        //Debug.Log("=== My Animator Controller = " + animatorController);
        if (gameController != null)
        {
            gameController.SetChoices(selectedChoice);
        }

        if (animatorController != null)
        {
            animatorController.PlayerMadeChoice();
            //animatorController.ResetAnimations();
        }
    }
}
