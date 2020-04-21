﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public readonly float SPEED = 0.05f;
    private Rigidbody2D rigidBody;
    private Vector2 input;

    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
        // 衝突時にobjectを回転させない設定
        this.rigidBody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void Update()
    {
        // 入力を取得
        input = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        if (input == Vector2.zero)
        {
            return;
        }
        // 既存のポジションに対して、移動量(vector)を加算する
        rigidBody.position += input * SPEED;
    }
}