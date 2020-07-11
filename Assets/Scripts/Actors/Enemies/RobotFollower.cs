﻿using UnityEngine;

namespace GMTK2020
{
    public class RobotFollower : Enemy
    {
        protected override void Attack(){}

        protected override void Move()
        {
            Debug.Log("Move");
            Debug.Log($"Direction is: {_directionToCurrentWaypoint}");
            _rigidbody.velocity = _directionToCurrentWaypoint * _movingSpeed * Time.fixedDeltaTime;
        }

        protected override void MakeAIDecision()
        {
            Move();
        }
    }
}