using UnityEngine;

namespace LotteMakesStuff.Mathmatics
{
    [System.Serializable]
    public struct BoundingSphere
    {
        public Vector3 Position;
        public float Radius;

        public BoundingSphere(Vector3 position, float radius)
        {
            Position = position;
            Radius = radius;
        }
    
        public static bool Intersect(BoundingSphere a, BoundingSphere b)
        {
            // calculate squared distance between the centers of both spheres
            Vector3 direction = a.Position - b.Position;
            float distanceSquared = Vector3.Dot(direction, direction);

            // if the distance is less than the sum of both radius, then there is an intersection
            float radius = a.Radius + b.Radius;
            return distanceSquared <= radius * radius;
        }
    }
}