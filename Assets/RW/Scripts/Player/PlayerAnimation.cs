using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    // multiplier for walk AnimationClip
    [Range(0.5f, 3f)]
    [SerializeField] private float walkAnimSpeed = 1f;

    // player Animator Controller
    [SerializeField] private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        if (animator != null)
        {
            // set AnimationClip speed
            animator.SetFloat("walkSpeedMultiplier", walkAnimSpeed);
        }
    }

    //    // toggle between idle and walking animation
    public void ToggleAnimation(bool state)
    {
        if (animator != null)
        {
            animator?.SetBool("isMoving", state);
        }

    }
}
