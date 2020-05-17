using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public float follow_height = 8f;
    public float follow_distance = 6f;
    private Transform player;
    private float target_height;
    private float current_height;
    private float current_Rotation;



    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;


    }


    // Update is called once per frame
    void Update()
    {
        target_height = player.position.y + follow_height;

        current_Rotation = transform.eulerAngles.y;

        current_height = Mathf.Lerp(transform.position.y,target_height, 0.9f * Time.deltaTime);

        Quaternion euler = Quaternion.Euler(0f, current_Rotation,0f);

        Vector3 target_Position = player.position - (euler * Vector3.forward) * follow_distance;

        target_Position.y = current_height;

        transform.position = target_Position;
        transform.LookAt(player);



    }
} // classe























