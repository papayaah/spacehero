﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {

	private Explodable _explodable;

	void Start()
	{
		_explodable = GetComponent<Explodable>();

        //_explodable.explode();

        //ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
        //ef.doExplosion(transform.position);
    }
	void OnMouseDown()
    {
        //_explodable.explode();
        //ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
        //ef.doExplosion(transform.position);
    }
}