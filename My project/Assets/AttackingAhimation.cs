using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingAnimation : MonoBehaviour
{
    private Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_animator.SetTrigger("Attack");
        }
    }
}
