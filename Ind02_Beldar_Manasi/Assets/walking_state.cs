using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking_state : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       animator.SetInteger( "walk_count", animator.GetInteger("walk_count") - 1 ) ;
    }
}
