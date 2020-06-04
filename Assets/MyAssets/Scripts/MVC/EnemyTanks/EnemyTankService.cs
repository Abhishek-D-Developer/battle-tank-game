using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Enemy.View;
using Tank.Controller;
using Enemy.Model;
using Enemy.Controller;
using Scriptables;

namespace Enemy.Service
{
    public class EnemyService
    {
        public EnemyView enemyView;
        public EnemyScriptableObjectList enemies;

        void Start()
        {
            StartGame();
        }

        public void StartGame()
        {
            for (int i = 0; i < 3; i++)
            {
              //  CreateEnemies(i);
            }
        }

        /*private EnemyController CreateEnemies(int index)
        {
            EnemyScriptableObject enemyScriptableObject = enemies.enemyList;

            EnemyModel enemyModel = new EnemyModel(enemyScriptableObject);
            EnemyController enemyController = new EnemyController(enemyModel, enemyView);
            return enemyController;
        }*/
    }
}