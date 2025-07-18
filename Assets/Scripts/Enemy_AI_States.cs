using UnityEngine;

[System.Serializable]
public enum State { Idle, Patrol, Stalking, Rage, High }

public class Enemy_AI_States : MonoBehaviour
{
    public State currentState = State.Idle;

    void Update()
    {
        switch (currentState)
        {
            case State.Idle:
                Debug.Log("Waiting...");
                break;

            case State.Patrol:
                Debug.Log("Patrolling");
                break;

            case State.Stalking:
                Debug.Log("Following Player");
                break;

            case State.Rage:
                Debug.Log("I need more");
                break;

            case State.High:
                Debug.Log("Chillin");
                break;
        }
    }
}


