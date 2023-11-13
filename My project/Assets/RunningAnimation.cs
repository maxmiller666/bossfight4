using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAnimation : MonoBehaviour
{
    private Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           Run();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Run();
        }
    }

    void Run()
    {
        m_animator.SetTrigger("Run");
    }
}