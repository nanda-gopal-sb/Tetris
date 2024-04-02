using UnityEngine;
public class Spawner : MonoBehaviour{
    public GameOver GO;
    public GameObject[] groups; 
    void Start(){
        SpawnNext();
    }
    public void SpawnNext(){
        //
        if(GO.GameisAlive){
            Instantiate(groups[Random.Range(0,groups.Length)],transform.position,Quaternion.identity);}}}