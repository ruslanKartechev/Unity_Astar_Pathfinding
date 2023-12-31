﻿using UnityEngine;

namespace Pathfinding.Agents
{
    public interface IPathfindingAgent
    {
        void Stop();
        void MoveTo(Vector3 position, bool avoidOthers = true);
        void SetListener(IPathAgentListener listener);
        void CorrectPosition();
        void ApplyPosition();
        string GetName();
        Vector3 GetPosition();
        Vector3 GetNextPosition();
        public void Kill();
        float GetRadius();
        Vector3 GetTargetPosition();
        Vector3 GetMoveDirection();
        float GetSpeed();
        void NextAction();
    }
}