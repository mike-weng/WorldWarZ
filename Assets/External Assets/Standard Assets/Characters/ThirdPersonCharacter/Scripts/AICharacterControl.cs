
using UnityEngine;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Character))]
public class AICharacterControl : MonoBehaviour
{
    public NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
    public Character character { get; private set; } // the character we are controlling
    public Transform target;                                   // target to aim for

    private bool jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
    private bool crouch;
    private bool attack;
    private bool skill1;
    private bool skill2;
    private bool skill3;

    private void Start()
    {
        // get the components on the object we need ( should not be null due to require component so no need to check )
        agent = GetComponentInChildren<NavMeshAgent>();
        character = GetComponent<Character>();
        this.target = FindObjectOfType<PlayerCharacter>().transform;
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
            character.Move(agent.desiredVelocity, crouch, jump, attack, skill1, skill2, skill3);
            character.UpdateAnimator(agent.desiredVelocity, attack, skill1, skill2, skill3);
        }
        else
        {
            if (character.GetComponent<Health>().health > 0)
            {
                float randomIndex = Random.Range(0, 2);
                if (randomIndex == 0)
                {
                    attack = true;
                }
                else if (randomIndex == 1)
                {
                    skill1 = true;
                }
            }
            character.Move(Vector3.zero, crouch, jump, attack, skill1, skill2, skill3);
            character.UpdateAnimator(Vector3.zero, attack, skill1, skill2, skill3);
        }

        crouch = false;
        attack = false;
        skill1 = false;
        skill2 = false;
        skill3 = false;
    }


    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
