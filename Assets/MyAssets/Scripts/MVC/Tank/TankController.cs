﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
	public TankController(TankModel tankModel, TankView tankPrefab)
	//public TanController(TankModel tankModel, GameObject tankPrefab)
	{
		TankModel = tankModel;

		//GameObject go = GaemObject.Instantiate(tankPrefab);
		//TankView = go.GetComponent<TankView>();
		if(tankPrefab != null)
        {
			TankView = GameObject.Instantiate<TankView>(tankPrefab);
			TankView.setController(this);
			TankView.sethealth(TankModel.Health);
			TankView.setSpeed(TankModel.Speed);
			TankView.setTurn(TankModel.Turn);
        }
        else
        {
			throw new NullReferenceException("tankPrefab is geting null !! ");
        }
		

		Debug.Log("Tank View Created");
	}
	public TankModel TankModel { get;}
	public TankView TankView { get; }
}