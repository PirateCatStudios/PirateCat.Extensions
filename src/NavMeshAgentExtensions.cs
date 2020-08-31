using UnityEngine;
using UnityEngine.AI;

namespace PirateCat.Extensions
{
    public static class NavMeshAgentExtensions
    {
        /// <summary>
        ///
        /// NavMeshAgent helper function that returns the nearest valid point for a
        /// given destination. This is really useful for click & wsad movement
        /// because the player may click into all kinds of unwalkable paths:
        ///
        ///       ________
        ///      |xxxxxxx|
        ///      |x|   |x|
        /// P   A|B| C |x|
        ///      |x|___|x|
        ///      |xxxxxxx|
        ///
        /// if a player is at position P and tries to go to:
        /// - A: the path is walkable, everything is fine
        /// - C: C is on a NavMesh, but we can't get there directly. CalcualatePath
        ///      will return A as the last walkable point
        /// - B: B is not on a NavMesh, CalulatePath doesn't work here. We need to
        ///   find the nearest point on a NavMesh first (might be A or C) and then
        ///   calculate the nearest valid one (A)
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static Vector3 NearestValidDestination(this NavMeshAgent agent, Vector3 destination)
        {
            // can we calculate a path there? then return the closest valid point
            NavMeshPath path = new NavMeshPath();
            if (agent.CalculatePath(destination, path))
                return path.corners[path.corners.Length - 1];

            // otherwise find nearest navmesh position first. we use a radius of
            // speed*2 which works fine. afterwards we find the closest valid point.
            NavMeshHit hit;
            if (NavMesh.SamplePosition(destination, out hit, agent.speed * 2, NavMesh.AllAreas))
                if (agent.CalculatePath(hit.position, path))
                    return path.corners[path.corners.Length - 1];

            // nothing worked, don't go anywhere.
            return agent.transform.position;
        }

        /// <summary>
        ///
        /// NavMeshAgent's ResetPath() function clears the path, but doesn't clear
        /// the velocity immediately. This is a nightmare for finite state machines
        /// because we often reset a path, then switch to casting, which would then
        /// receive a movement event because velocity still isn't 0 until a few
        /// frames later.
        ///
        /// We need a function that truly stops all movement.
        /// </summary>
        /// <param name="agent"></param>
        public static void ResetMovement(this NavMeshAgent agent)
        {
            agent.ResetPath();
            agent.velocity = Vector3.zero;
        }
    }
}
