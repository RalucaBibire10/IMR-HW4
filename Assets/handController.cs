using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            animator.Play("Armature|peace");
        }
        else if (Input.GetKeyDown("2"))
        {
            animator.Play("Armature|thumbs up");
        }
        else if (Input.GetKeyDown("3"))
        {
            animator.Play("Armature|wave");
        }
        else if (Input.GetKeyDown("r"))
        {
            animator.Play("New State");
        }
    }
}
