using UnityEngine;
public class Movement : MonoBehaviour{
    public LeftButton LB; 
    public DownButton DB;
    public RightButton RB;
    public RotateButton TB;
    public Music music; 
    public Vector3 rotationPoint; 
    public float fallTime =  0.8f; 
    public static int height = 20 ; 
    public static int width = 10 ;
    private static int LineClear = 0 ; 
    public float previousTime ; 
    public static Transform[,] grid = new Transform[width,height];
    private void Start() {
        LB = FindObjectOfType<LeftButton>();
        RB = FindObjectOfType<RightButton>();
        DB = FindObjectOfType<DownButton>();
        TB = FindObjectOfType<RotateButton>();}
    private void Update() {
        if(TB.isPressed && gameObject.name!="Group O(Clone)"){
            Rotate();
            TB.isPressed = false; }
        if(LB.isPressed){
            moveLeft();
            LB.isPressed = false; }
        if(RB.isPressed){
            moveRight();
            RB.isPressed = false; }
        MoveDown();   }
    private void Rotate(){
        transform.RotateAround(transform.TransformPoint(rotationPoint),new Vector3(0,0,1),90);
        if(!isValid()){
        transform.RotateAround(transform.TransformPoint(rotationPoint),new Vector3(0,0,1),-90);}}
    public void moveLeft(){
        transform.position += new Vector3(-1,0,0);
        if(!isValid()){
            transform.position += new Vector3(1,0,0);}}
    public void moveRight(){
         transform.position += new Vector3(1,0,0);
         if(!isValid()){
            transform.position += new Vector3(-1,0,0);} }
    public void MoveDown(){
        if(Time.time - previousTime > (DB.isPressed? fallTime/15 : fallTime)){
            transform.position+= new Vector3(0,-1,0);
                if(!isValid()){
                    transform.position += new Vector3(0,1,0);
                    addToGrid();
                    checkForLines();
                    enabled = false;
                    isTriggerGameOver();
                    FindObjectOfType<Spawner>().SpawnNext();}
            previousTime = Time.time; 
            DB.isPressed = false; }}
    public void isTriggerGameOver(){
        int y = 17; 
        for(int x = 0 ; x<width ; x++){
            if(grid[x,y]!=null){
               FindObjectOfType<GameOver>().EndScreen();
               FindObjectOfType<Music>().StopMusic();
               FindObjectOfType<Music>().PlayGameOver();
               LineClear = 0 ; }}}
    private void checkForLines(){
        for(int i = height-1 ; i>=0 ; i--){
            if(HasLine(i)){
                DeleteLine(i);
                RowDown(i);}}}
    public bool isValid(){
        foreach(Transform child in transform){
            int x = (int)child.transform.position.x;
            int y = (int)child.transform.position.y;
            if(child.transform.position.x < 0 || child.transform.position.x >= width ||
            child.transform.position.y < 0|| child.transform.position.y >= height || grid[x, y] != null){
                return false; }}
        return true;}
   public void addToGrid(){
        foreach(Transform child in transform){
            int x =(int)child.transform.position.x;
            int y = (int)child.transform.position.y;
                grid[x,y] = child;}}
   public bool HasLine(int i ){
    for(int j = 0 ; j<width ; j++){
        if(grid[j,i]==null){
            return false;}}
    return true; }
public void DeleteLine(int i ){
    LineClear++;
    FindObjectOfType<UpdateScore>().ScoreChange(LineClear);
    FindObjectOfType<Music>().Celebrate();
     for(int j = 0 ; j<width ; j++){
        if(grid[j,i]!=null){
            Destroy(grid[j,i].gameObject);
            grid[j,i] = null;}}}
    void RowDown(int i){
    for (int y = i; y < height; y++){
        for (int j = 0; j < width; j++){
            if(grid[j,y] != null){
                grid[j, y - 1] = grid[j,y];
                grid[j, y] = null;
                grid[j, y - 1].transform.position -= new Vector3(0, 1, 0);}}}}}