using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    [SerializeField]
    private Animator playerHandlerAnimation, choiceAnimation;

    public void ResetAnimations()
    {
        //playerHandlerAnimation.Play("Show Handler");
        //choiceAnimation.Play("Remove Choice");
        playerHandlerAnimation.SetBool("showHandler", true);
        choiceAnimation.SetBool("showChoice", false);
        Debug.Log("=== Reset Animations ===");
    }

    public void PlayerMadeChoice()
    {
        //playerHandlerAnimation.Play("Remove Handler");
        //choiceAnimation.Play("Show Choice");
        playerHandlerAnimation.SetBool("showHandler", false);
        choiceAnimation.SetBool("showChoice", true);
        Debug.Log("=== Player Made Choice ===");
    }
}

