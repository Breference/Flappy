using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   public GameObject _pipe;
   public Transform _spawnPos;


   public float starDelay = 2;
   public float repeatRate = 0.5f;


   void Start()
   {
        _spawnPos = GetComponent<Transform>();
        InvokeRepeating("SpawnObstacle", starDelay, repeatRate);
   }

   private void SpawnObstacle()
   {
        
        _spawnPos.position = newVector3(_spawnPos.position.x,RandomRange(0f,2f));    
        Instantiate(_pipe,_spawnPos.position, _pipe.transform.rotation);
   }

}
