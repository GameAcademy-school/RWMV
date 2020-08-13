using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{



    //    // multiplier for walk AnimationClip
    //    [Range(0.5f, 3f)]
    [SerializeField] private float walkAnimSpeed = 1f;

    //    // player Animator Controller
    [SerializeField] private Animator animController;


    // Start is called before the first frame update
    void Start()
    {
        // set AnimationClip speed
        animController?.SetFloat("walkSpeedMultiplier", walkAnimSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //    // toggle between idle and walking animation
    public void ToggleAnimation(bool state)
    {
        animController?.SetBool("isMoving", state);
    }
}
