using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class running_state : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger( "run_count", animator.GetInteger("run_count") - 1 ) ;
    }
}
