using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NullFrameworkException.AI
{
    public class Spawner : MonoBehaviour
    {

        public Vector3 size = Vector3.one;

        public Vector3 center = Vector3.zero;
        [Header("Floor Position")]
        [SerializeField, Tooltip("Use the GameObject's yPosition always when spawning an object.")]
        private bool floorYPosition = false;

        [SerializeField] private Vector2 spawnRate = new Vector2(0, 1);

        [SerializeField] private bool shouldSpawnBoss = false;

        [SerializeField, Range(0, 100)] private float bossSpawnChance = 1;

        [SerializeField] private GameObject bossPrefab = null;
        [SerializeField] private GameObject enemyPrefab = null;

        private float currentTime = 0;
        private float currentSpawnInterval = 0;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update() { }

        private void OnDrawGizmos()
        {
            // Store the original Gizmos matrix
            Matrix4x4 original = Gizmos.matrix;
            
            //Make the gizmos use the current objects transform
            Gizmos.matrix = transform.localToWorldMatrix;

            //Draw a green, partially transparent cube
            Gizmos.color = new Color(0, 1, 0, 0.25f);
            Gizmos.DrawCube(center, size);
            
            //Reset the Gizmos matrix to the original one
            Gizmos.matrix = original;
        }
    }
}