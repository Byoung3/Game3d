using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CommonAITarget : MonoBehaviour
{
    public Transform Target;
    
    private NavMeshAgent m_Agent;
    public float m_speed;
    private float m_Distance;
    public float detect_distance;
    public List<Transform> waypoints;
    private int currentWaypointIndex = 0;

    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        if (waypoints.Count > 0)
        {
            m_Agent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }

    
    void Update()
    {
        m_Distance = Vector3.Distance(transform.position, Target.position);

        if (m_Distance < detect_distance)
        {
            m_Agent.SetDestination(Target.position);
        }
        else if (!m_Agent.pathPending && m_Agent.remainingDistance < 0.5f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count;
            m_Agent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }
}
