using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AppleTree : MonoBehaviour {
    [Header("Inscribed")]
    // Prefab for instantiating objects
    public GameObject applePrefab;
    public GameObject branchPrefab;

    // Speed at which the AppleTree	moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;
    
    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;

    // Rate at which Branches will be instantiated
    public float secondsBetweenBranchDrops = 5f;

    void Start() {
        // Dropping apples every second
        Invoke("DropApple",	2f);
        Invoke("DropBranch", 2f);
        }

    void DropApple() {
        GameObject apple = Instantiate<GameObject>(applePrefab);	
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);	
    }

    void DropBranch() {
        GameObject branch = Instantiate<GameObject>(branchPrefab);	
        branch.transform.position = transform.position;
        Invoke("DropBranch", secondsBetweenBranchDrops);
    }

    void Update() {
        // Basic Movement
        Vector3	pos = transform.position;	
        pos.x += speed * Time.deltaTime;	
        transform.position = pos;	
        // Changing Direction
        if (pos.x < -leftAndRightEdge) {	
            speed = Mathf.Abs(speed);	// Move right
        } else if (pos.x > leftAndRightEdge) {	
            speed = -Mathf.Abs(speed);	// Move left
        }
    }

    void FixedUpdate() {
    // Changing Direction Randomly is time-based
        if	(Random.value < chanceToChangeDirections)	{	
        speed *= -1; // Change direction
        }
    }
}