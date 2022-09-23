using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    [SerializeField]GameObject prefab;
   bool _GameOver=false ;
   public int score;
       public void SpawnObject()
        {
            Instantiate(prefab,new Vector3(Random.Range(-8f,8f),6f,0f),Quaternion.identity);//for not rotaion and random spawn along X axis
        }
    
private void OnCollisionEnter2D(Collision2D collision)
{
    
    if(collision.gameObject.tag == "player" && !_GameOver)//Respawning object once you got point
    {
        score=score+10;
    SpawnObject();    
    Destroy(gameObject);
    
    }
    else if (collision.gameObject.tag == "ground")
        {
        _GameOver=true;
        
        Debug.Log(" Game Over! \nScore  "+score);
       
    }
}
}