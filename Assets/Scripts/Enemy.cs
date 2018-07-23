using UnityEngine;

public class Enemy : MonoBehaviour
{
      
public static Enemy instance;

[Header("Attributes")]
public float speed = 2f;
public int cost = 100;

private Transform waypoints;
private Transform waypoint;
private int waypointIndex = -1;
private int health = 100;

void Start()
   {
      instance = this;
      waypoints = GameObject.Find("WayPoints").transform;
      NextWaypoint();
   }
   
void Update()
   {
      Vector3 dir = waypoint.transform.position - transform.position;
      dir.y = 0;

      float _speed = Time.deltaTime * speed;
      transform.Translate(dir.normalized * _speed);

      if (dir.magnitude <= _speed)
         NextWaypoint();
   }

   void NextWaypoint()
   {
      waypointIndex++;

      if (waypointIndex >= waypoints.childCount)
      {
         Destroy(gameObject);
         return;
      }

      waypoint = waypoints.GetChild(waypointIndex);
   }
}