using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] MainMenuController mainMenuController;
    [SerializeField] Animator animator;
    [SerializeField] MainMenuFunctions animatorFunctions;
    [SerializeField] int thisIndex;

    void Update()
    {
        if (mainMenuController.index == thisIndex)
        {
            animator.SetBool("selected", true);
            if (Input.GetAxis("Submit") == 1)
            {
                animator.SetBool("pressed", true);
            }
            else if (animator.GetBool("pressed"))
            {
                animator.SetBool("pressed", false);
                animatorFunctions.disableOnce = true;
            }
        }
        else
        {
            animator.SetBool("selected", false);
        }

    }
}
