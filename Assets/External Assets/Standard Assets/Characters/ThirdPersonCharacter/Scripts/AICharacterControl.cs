using System;
using UnityEngine;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Character))]
public class AICharacterControl : MonoBehaviour
{
    public NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
    public Character character { get; private set; } // the character we are controlling
    public Transform target;                                   // target to aim for

    private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
    private bool crouch;
    private bool m_Attack;
    private bool m_Skill1;
    private bool m_Skill2;
    private bool m_Skill3;

    private void Start()
    {
        // get the components on the object we need ( should not be null due to require component so no need to check )
        agent = GetComponentInChildren<NavMeshAgent>();
        character = GetComponent<Character>();

        agent.updateRotation = false;
        agent.updatePosition = true;
    }


    private void Update()
    {

        if (target != null)
            agent.SetDestination(target.position);

    }
    private void FixedUpdate()
    {
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, crouch, m_Jump, m_Attack, m_Skill1, m_Skill2, m_Skill3);
            character.UpdateAnimator(agent.desiredVelocity, m_Attack, m_Skill1, m_Skill2, m_Skill3);
        }
        else
        {
            m_Attack = true;
            character.Move(Vector3.zero, crouch, m_Jump, m_Attack, m_Skill1, m_Skill2, m_Skill3);
            character.UpdateAnimator(Vector3.zero, m_Attack, m_Skill1, m_Skill2, m_Skill3);
        }

        crouch = false;
        m_Attack = false;
        m_Skill1 = false;
        m_Skill2 = false;
        m_Skill3 = false;
    }


    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
