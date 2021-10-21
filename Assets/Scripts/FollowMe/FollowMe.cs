using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JMRSDK.InputModule;
using JMRSDK;

namespace JMRSDKExampleSnippets.FollowMe
{
    /// <summary>
    /// The FollowMe class handles the functionality for making the gameObject follow the user.
    /// </summary>
    /// 
    /// <remarks>
    /// Create an Empty gameObject called 'Follower' and set its position to the position of the JMRMixedRealityPrefab. Attach the FollowMe Script to 'Follower'.
    /// Add the other gameObjects as a child of 'Follower' and give it a required offset 
    /// </remarks>
    public class FollowMe : MonoBehaviour
    {
        /// <summary>
        /// The speed the gameObjects will follow the user
        /// </summary>
        public float speed = 1f;
        Transform target;

        void Start()
        {
            SetTarget();
        }

        void Update()
        {
            Follow();
        }

        /// <summary>
        /// Sets the target to the Head Transform of the JMRMixedReality
        /// </summary>
        public void SetTarget()
        {
            target = JMRTrackerManager.Instance.GetHeadTransform();
        }

        /// <summary>
        /// Handles the following functionality
        /// </summary>
        public void Follow()
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
            transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime *
            speed);
        }
    }
}
