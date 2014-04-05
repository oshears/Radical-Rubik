using UnityEngine;
using System.Collections;

public class CubeActions : MonoBehaviour {

	public GameObject perCube;

	public Material mat_orange;
	public Material mat_red;
	public Material mat_blue;
	public Material mat_green;
	public Material mat_yellow;
	public Material mat_white;

	public GameObject faces000;
	public GameObject faces001;
	public GameObject faces002;
	public GameObject faces010;
	public GameObject faces012;
	public GameObject faces020;
	public GameObject faces021;
	public GameObject faces022;

	public GameObject faces100;
	public GameObject faces101;
	public GameObject faces102;
	public GameObject faces110;
	public GameObject faces112;
	public GameObject faces120;
	public GameObject faces121;
	public GameObject faces122;

	public GameObject faces200;
	public GameObject faces201;
	public GameObject faces202;
	public GameObject faces210;
	public GameObject faces212;
	public GameObject faces220;
	public GameObject faces221;
	public GameObject faces222;

	public GameObject faces300;
	public GameObject faces301;
	public GameObject faces302;
	public GameObject faces310;
	public GameObject faces312;
	public GameObject faces320;
	public GameObject faces321;
	public GameObject faces322;

	public GameObject faces400;
	public GameObject faces401;
	public GameObject faces402;
	public GameObject faces410;
	public GameObject faces412;
	public GameObject faces420;
	public GameObject faces421;
	public GameObject faces422;

	public GameObject faces500;
	public GameObject faces501;
	public GameObject faces502;
	public GameObject faces510;
	public GameObject faces512;
	public GameObject faces520;
	public GameObject faces521;
	public GameObject faces522;

	public GameObject perfaces000;
	public GameObject perfaces001;
	public GameObject perfaces002;
	public GameObject perfaces010;
	public GameObject perfaces012;
	public GameObject perfaces020;
	public GameObject perfaces021;
	public GameObject perfaces022;
	
	public GameObject perfaces100;
	public GameObject perfaces101;
	public GameObject perfaces102;
	public GameObject perfaces110;
	public GameObject perfaces112;
	public GameObject perfaces120;
	public GameObject perfaces121;
	public GameObject perfaces122;
	
	public GameObject perfaces200;
	public GameObject perfaces201;
	public GameObject perfaces202;
	public GameObject perfaces210;
	public GameObject perfaces212;
	public GameObject perfaces220;
	public GameObject perfaces221;
	public GameObject perfaces222;
	
	public GameObject perfaces300;
	public GameObject perfaces301;
	public GameObject perfaces302;
	public GameObject perfaces310;
	public GameObject perfaces312;
	public GameObject perfaces320;
	public GameObject perfaces321;
	public GameObject perfaces322;
	
	public GameObject perfaces400;
	public GameObject perfaces401;
	public GameObject perfaces402;
	public GameObject perfaces410;
	public GameObject perfaces412;
	public GameObject perfaces420;
	public GameObject perfaces421;
	public GameObject perfaces422;
	
	public GameObject perfaces500;
	public GameObject perfaces501;
	public GameObject perfaces502;
	public GameObject perfaces510;
	public GameObject perfaces512;
	public GameObject perfaces520;
	public GameObject perfaces521;
	public GameObject perfaces522;

	public GameObject[,,] actualfaces = new GameObject[6,3,3];
	public GameObject[,,] perfaces = new GameObject[6, 3, 3];
	public Material[,,] dynamic_materials = new Material[6, 3, 3];

	// Use this for initialization
	void Start () {
	
		for(int a = 0; a < 6; a++){
			for(int b = 0; b < 3; b++){
				for(int c = 0; c < 3; c++){
					if (a==0)dynamic_materials[a,b,c] = mat_orange;
					if (a==1)dynamic_materials[a,b,c] = mat_red;
					if (a==2)dynamic_materials[a,b,c] = mat_blue;
					if (a==3)dynamic_materials[a,b,c] = mat_yellow;
					if (a==4)dynamic_materials[a,b,c] = mat_white;
					if (a==5)dynamic_materials[a,b,c] = mat_green;
				}
			}
		}


		actualfaces[0,0,0]=faces000;
		actualfaces[0,0,1]=faces001;
		actualfaces[0,0,2]=faces002;
		actualfaces[0,1,0]=faces010;
		actualfaces[0,1,2]=faces012;
		actualfaces[0,2,0]=faces020;
		actualfaces[0,2,1]=faces021;
		actualfaces[0,2,2]=faces022;
		
		actualfaces[1,0,0]=faces100;
		actualfaces[1,0,1]=faces101;
		actualfaces[1,0,2]=faces102;
		actualfaces[1,1,0]=faces110;
		actualfaces[1,1,2]=faces112;
		actualfaces[1,2,0]=faces120;
		actualfaces[1,2,1]=faces121;
		actualfaces[1,2,2]=faces122;

		actualfaces[2,0,0]=faces200;
		actualfaces[2,0,1]=faces201;
		actualfaces[2,0,2]=faces202;
		actualfaces[2,1,0]=faces210;
		actualfaces[2,1,2]=faces212;
		actualfaces[2,2,0]=faces220;
		actualfaces[2,2,1]=faces221;
		actualfaces[2,2,2]=faces222;

		actualfaces[3,0,0]=faces300;
		actualfaces[3,0,1]=faces301;
		actualfaces[3,0,2]=faces302;
		actualfaces[3,1,0]=faces310;
		actualfaces[3,1,2]=faces312;
		actualfaces[3,2,0]=faces320;
		actualfaces[3,2,1]=faces321;
		actualfaces[3,2,2]=faces322;

		actualfaces[4,0,0]=faces400;
		actualfaces[4,0,1]=faces401;
		actualfaces[4,0,2]=faces402;
		actualfaces[4,1,0]=faces410;
		actualfaces[4,1,2]=faces412;
		actualfaces[4,2,0]=faces420;
		actualfaces[4,2,1]=faces421;
		actualfaces[4,2,2]=faces422;

		actualfaces[5,0,0]=faces500;
		actualfaces[5,0,1]=faces501;
		actualfaces[5,0,2]=faces502;
		actualfaces[5,1,0]=faces510;
		actualfaces[5,1,2]=faces512;
		actualfaces[5,2,0]=faces520;
		actualfaces[5,2,1]=faces521;
		actualfaces[5,2,2]=faces522;


		perfaces[0,0,0]=perfaces000;
		perfaces[0,0,1]=perfaces001;
		perfaces[0,0,2]=perfaces002;
		perfaces[0,1,0]=perfaces010;
		perfaces[0,1,2]=perfaces012;
		perfaces[0,2,0]=perfaces020;
		perfaces[0,2,1]=perfaces021;
		perfaces[0,2,2]=perfaces022;
		
		perfaces[1,0,0]=perfaces100;
		perfaces[1,0,1]=perfaces101;
		perfaces[1,0,2]=perfaces102;
		perfaces[1,1,0]=perfaces110;
		perfaces[1,1,2]=perfaces112;
		perfaces[1,2,0]=perfaces120;
		perfaces[1,2,1]=perfaces121;
		perfaces[1,2,2]=perfaces122;
		
		perfaces[2,0,0]=perfaces200;
		perfaces[2,0,1]=perfaces201;
		perfaces[2,0,2]=perfaces202;
		perfaces[2,1,0]=perfaces210;
		perfaces[2,1,2]=perfaces212;
		perfaces[2,2,0]=perfaces220;
		perfaces[2,2,1]=perfaces221;
		perfaces[2,2,2]=perfaces222;
		
		perfaces[3,0,0]=perfaces300;
		perfaces[3,0,1]=perfaces301;
		perfaces[3,0,2]=perfaces302;
		perfaces[3,1,0]=perfaces310;
		perfaces[3,1,2]=perfaces312;
		perfaces[3,2,0]=perfaces320;
		perfaces[3,2,1]=perfaces321;
		perfaces[3,2,2]=perfaces322;
		
		perfaces[4,0,0]=perfaces400;
		perfaces[4,0,1]=perfaces401;
		perfaces[4,0,2]=perfaces402;
		perfaces[4,1,0]=perfaces410;
		perfaces[4,1,2]=perfaces412;
		perfaces[4,2,0]=perfaces420;
		perfaces[4,2,1]=perfaces421;
		perfaces[4,2,2]=perfaces422;
		
		perfaces[5,0,0]=perfaces500;
		perfaces[5,0,1]=perfaces501;
		perfaces[5,0,2]=perfaces502;
		perfaces[5,1,0]=perfaces510;
		perfaces[5,1,2]=perfaces512;
		perfaces[5,2,0]=perfaces520;
		perfaces[5,2,1]=perfaces521;
		perfaces[5,2,2]=perfaces522;

	}
	
	// Update is called once per frame
	void Update () {
	
		Debug.Log("X: "+Camera.main.transform.position.x+" Y: "+Camera.main.transform.position.y+" Z: "+Camera.main.transform.position.z);

		int camera_at = 0;

		if ((Camera.main.transform.position.x >= -50 && Camera.main.transform.position.x <= 90)&&(Camera.main.transform.position.z>=-111&&Camera.main.transform.position.z<=-28)&&Camera.main.transform.position.y>=-5) {
			camera_at = 1;
		}
		else if ((Camera.main.transform.position.x >= -78 && Camera.main.transform.position.x <= 4)&&(Camera.main.transform.position.z>=-78&&Camera.main.transform.position.z<=50)&&Camera.main.transform.position.y>=-5) {
			camera_at = 2;	
		}
		else if ((Camera.main.transform.position.x >= -50 && Camera.main.transform.position.x <= 78)&&(Camera.main.transform.position.z>=-4&&Camera.main.transform.position.z<=78)&&Camera.main.transform.position.y>=-5) {
			camera_at = 3;	
		}
		else if ((Camera.main.transform.position.x >= 28 && Camera.main.transform.position.x <= 111)&&(Camera.main.transform.position.z>=-78&&Camera.main.transform.position.z<=50)&&Camera.main.transform.position.y>=-5) {
			camera_at = 4;	
		}
		else if ((Camera.main.transform.position.x >= -50 && Camera.main.transform.position.x <= 90)&&(Camera.main.transform.position.z>=-111&&Camera.main.transform.position.z<=-28)&&Camera.main.transform.position.y<-5) {
			camera_at = 5;	
		}
		else if ((Camera.main.transform.position.x >= -78 && Camera.main.transform.position.x <= 4)&&(Camera.main.transform.position.z>=-78&&Camera.main.transform.position.z<=50)&&Camera.main.transform.position.y<-5) {
			camera_at = 6;	
		}
		else if ((Camera.main.transform.position.x >= -50 && Camera.main.transform.position.x <= 78)&&(Camera.main.transform.position.z>=-4&&Camera.main.transform.position.z<=78)&&Camera.main.transform.position.y<-5) {
			camera_at = 7;	
		}
		else if ((Camera.main.transform.position.x >= 28 && Camera.main.transform.position.x <= 111)&&(Camera.main.transform.position.z>=-78&&Camera.main.transform.position.z<=50)&&Camera.main.transform.position.y<-5) {
			camera_at = 8;	
		}

		if (camera_at == 1) {
			Debug.Log("The camera is in the top front area of the cube...");		
		}
		else if (camera_at == 2) {
			Debug.Log("The camera is in the top left area of the cube...");		
		}
		else if (camera_at == 3) {
			Debug.Log("The camera is in the top back area of the cube...");		
		}
		else if (camera_at == 4) {
			Debug.Log("The camera is in the top right area of the cube...");		
		}
		else if (camera_at == 5) {
			Debug.Log("The camera is in the bottom front area of the cube...");		
		}
		else if (camera_at == 6) {
			Debug.Log("The camera is in the bottom left area of the cube...");		
		}
		else if (camera_at == 7) {
			Debug.Log("The camera is in the bottom back area of the cube...");		
		}
		else if (camera_at == 8) {
			Debug.Log("The camera is in the bottom right area of the cube...");		
		}
		else{
			Debug.Log("The camera's position is between the top and bottom of the cube...");		
		}
						
		if ( Input.GetMouseButtonDown(0)){

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100.0f)){
				if (hit.collider.gameObject.tag != "Unselectable"){
					GameObject selectedFace = hit.collider.gameObject;
					if ((/*selectedFace==actualfaces[0,0,0]||
					     selectedFace==actualfaces[0,2,0]||*/
					     selectedFace==actualfaces[1,0,0]||
					     selectedFace==actualfaces[1,2,0]/*||
					     selectedFace==actualfaces[2,0,0]||
					     selectedFace==actualfaces[2,2,0]*/) && Input.GetKey (KeyCode.W)){
						action("l^");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[3,2,0]||
					   		  selectedFace==actualfaces[3,0,0]) && Input.GetKey (KeyCode.W)){
						action("l");
						Camera.main.audio.Play();
					}
					else if ((/*selectedFace==actualfaces[0,0,0]||
					          selectedFace==actualfaces[0,2,0]||*/
					          selectedFace==actualfaces[1,0,0]||
					          selectedFace==actualfaces[1,2,0]/*||
					          selectedFace==actualfaces[2,0,0]||
					          selectedFace==actualfaces[2,2,0]*/) && Input.GetKey (KeyCode.S)){
						action("l");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[3,2,0]||
					         selectedFace==actualfaces[3,0,0]) && Input.GetKey (KeyCode.S)){
						action("l^");
						Camera.main.audio.Play();
					}
					else if (/*((selectedFace==actualfaces[0,2,0]||
					          selectedFace==actualfaces[0,2,2]) && Input.GetKey (KeyCode.A))||*/
							((selectedFace==actualfaces[5,0,0]||
					  		  selectedFace==actualfaces[5,2,0])&& Input.GetKey (KeyCode.W))||
					        ((selectedFace==actualfaces[4,0,2]||
					  		  selectedFace==actualfaces[4,2,2])&& Input.GetKey (KeyCode.S))/*||
					        ((selectedFace==actualfaces[2,0,2]||
					  		  selectedFace==actualfaces[2,0,0])&& Input.GetKey (KeyCode.D))*/)
					         {
						action("f^");
						Camera.main.audio.Play();
					}
					else if (/*((selectedFace==actualfaces[0,2,0]||
					           selectedFace==actualfaces[0,2,2]) && Input.GetKey (KeyCode.D))||*/
					         ((selectedFace==actualfaces[5,0,0]||
					  		   selectedFace==actualfaces[5,2,0])&& Input.GetKey (KeyCode.S))||
					         ((selectedFace==actualfaces[4,0,2]||
					  		   selectedFace==actualfaces[4,2,2])&& Input.GetKey (KeyCode.W))/*||
					         ((selectedFace==actualfaces[2,0,2]||
					 		   selectedFace==actualfaces[2,0,0])&& Input.GetKey (KeyCode.A))*/)
					{
						action("f");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[1,0,0]||
					         selectedFace==actualfaces[1,0,2]||
					         selectedFace==actualfaces[3,2,0]||
					         selectedFace==actualfaces[3,2,2]||
					         selectedFace==actualfaces[4,0,0]||
					         selectedFace==actualfaces[4,0,2]||
					         selectedFace==actualfaces[5,0,0]||
					         selectedFace==actualfaces[5,0,2]) && Input.GetKey (KeyCode.D)){
						action ("t");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[1,0,0]||
					          selectedFace==actualfaces[1,0,2]||
					          selectedFace==actualfaces[3,2,0]||
					          selectedFace==actualfaces[3,2,2]||
					          selectedFace==actualfaces[4,0,0]||
					          selectedFace==actualfaces[4,0,2]||
					          selectedFace==actualfaces[5,0,0]||
					          selectedFace==actualfaces[5,0,2]) && Input.GetKey (KeyCode.A)){
						action ("t^");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[1,2,0]||
					          selectedFace==actualfaces[1,2,2]||
					          selectedFace==actualfaces[3,0,0]||
					          selectedFace==actualfaces[3,0,2]||
					          selectedFace==actualfaces[4,2,0]||
					          selectedFace==actualfaces[4,2,2]||
					          selectedFace==actualfaces[5,2,0]||
					          selectedFace==actualfaces[5,2,2]) && Input.GetKey (KeyCode.D)){
						action ("d");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[1,2,0]||
					          selectedFace==actualfaces[1,2,2]||
					          selectedFace==actualfaces[3,0,0]||
					          selectedFace==actualfaces[3,0,2]||
					          selectedFace==actualfaces[4,2,0]||
					          selectedFace==actualfaces[4,2,2]||
					          selectedFace==actualfaces[5,2,0]||
					          selectedFace==actualfaces[5,2,2]) && Input.GetKey (KeyCode.A)){
						action ("d^");
						Camera.main.audio.Play();
					}
					if ((/*selectedFace==actualfaces[0,0,2]||
					     selectedFace==actualfaces[0,2,2]||*/
					     selectedFace==actualfaces[1,0,2]||
					     selectedFace==actualfaces[1,2,2]/*||
					     selectedFace==actualfaces[2,0,2]||
					     selectedFace==actualfaces[2,2,2]*/) && Input.GetKey (KeyCode.W)){
						action("r^");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[3,2,2]||
					          selectedFace==actualfaces[3,0,2]) && Input.GetKey (KeyCode.W)){
						action("r");
						Camera.main.audio.Play();
					}
					else if ((/*selectedFace==actualfaces[0,0,2]||
					          selectedFace==actualfaces[0,2,2]||*/
					          selectedFace==actualfaces[1,0,2]||
					          selectedFace==actualfaces[1,2,2]/*||
					          selectedFace==actualfaces[2,0,2]||
					          selectedFace==actualfaces[2,2,2]*/) && Input.GetKey (KeyCode.S)){
						action("r");
						Camera.main.audio.Play();
					}
					else if ((selectedFace==actualfaces[3,2,2]||
					          selectedFace==actualfaces[3,0,2]) && Input.GetKey (KeyCode.S)){
						action("r^");
						Camera.main.audio.Play();
					}
					else if (/*((selectedFace==actualfaces[0,0,0]||
					           selectedFace==actualfaces[0,0,2]) && Input.GetKey (KeyCode.A))||*/
					         ((selectedFace==actualfaces[5,0,2]||
					  selectedFace==actualfaces[5,2,2])&& Input.GetKey (KeyCode.W))||
					         ((selectedFace==actualfaces[4,0,0]||
					  selectedFace==actualfaces[4,2,0])&& Input.GetKey (KeyCode.S))/*||
					         ((selectedFace==actualfaces[2,2,2]||
					  selectedFace==actualfaces[2,2,0])&& Input.GetKey (KeyCode.D))*/)
					{
						action("b^");
						Camera.main.audio.Play();
					}
					else if (/*((selectedFace==actualfaces[0,0,0]||
					           selectedFace==actualfaces[0,0,2]) && Input.GetKey (KeyCode.D))||*/
					         ((selectedFace==actualfaces[5,0,2]||
					  selectedFace==actualfaces[5,2,2])&& Input.GetKey (KeyCode.S))||
					         ((selectedFace==actualfaces[4,0,0]||
					  selectedFace==actualfaces[4,2,0])&& Input.GetKey (KeyCode.W))/*||
					         ((selectedFace==actualfaces[2,2,2]||
					  selectedFace==actualfaces[2,2,0])&& Input.GetKey (KeyCode.A))*/)
					{
						action("b");
						Camera.main.audio.Play();
					}
/*-------------------------------------------------------------------------------------------------------------------------*/
					else if(selectedFace==actualfaces[0,0,0]&&Input.GetKey(KeyCode.W)){
						if (camera_at==1){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("b^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,0,0]&&Input.GetKey(KeyCode.A)){
						if (camera_at==1){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("l");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,0,0]&&Input.GetKey(KeyCode.S)){
						if (camera_at==1){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("b");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,0,0]&&Input.GetKey(KeyCode.D)){
						if (camera_at==1){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("l^");
							Camera.main.audio.Play();
						}
					}
/*&&&&&&&&&&&&*&*&*&777777777777777777777777738329325283519*/
					else if(selectedFace==actualfaces[0,2,0]&&Input.GetKey(KeyCode.W)){
						if (camera_at==1){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("f^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,2,0]&&Input.GetKey(KeyCode.A)){
						if (camera_at==1){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("l");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,2,0]&&Input.GetKey(KeyCode.S)){
						if (camera_at==1){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("f");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,2,0]&&Input.GetKey(KeyCode.D)){
						if (camera_at==1){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("l^");
							Camera.main.audio.Play();
						}
					}
/*&&&&&&&&&&&&*&*&*&777777777777777777777777738329325283519*/
					else if(selectedFace==actualfaces[0,0,2]&&Input.GetKey(KeyCode.W)){
						if (camera_at==1){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("b^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,0,2]&&Input.GetKey(KeyCode.A)){
						if (camera_at==1){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("r");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,0,2]&&Input.GetKey(KeyCode.S)){
						if (camera_at==1){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("b");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,0,2]&&Input.GetKey(KeyCode.D)){
						if (camera_at==1){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("r^");
							Camera.main.audio.Play();
						}
					}
/*&&&&&&&&&&&&*&*&*&777777777777777777777777738329325283519*/
					else if(selectedFace==actualfaces[0,2,2]&&Input.GetKey(KeyCode.W)){
						if (camera_at==1){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("f^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,2,2]&&Input.GetKey(KeyCode.A)){
						if (camera_at==1){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("r");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,2,2]&&Input.GetKey(KeyCode.S)){
						if (camera_at==1){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("f");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[0,2,2]&&Input.GetKey(KeyCode.D)){
						if (camera_at==1){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==2){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==3){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==4){
							action("r^");
							Camera.main.audio.Play();
						}
					}
/*AQUICKBROWNFOXJUMPSOVERTHELAZYDOGTWOTIMESSOTHATHEMAYSAVEHISFAMILYFROMTHEEVILPIRATEWOLFOFDARKNESSWHORESIDESINTHEINFINITETOWER!*/
					else if(selectedFace==actualfaces[2,0,0]&&Input.GetKey(KeyCode.W)){
						if (camera_at==5){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("f^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,0,0]&&Input.GetKey(KeyCode.A)){
						if (camera_at==5){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("l^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,0,0]&&Input.GetKey(KeyCode.S)){
						if (camera_at==5){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("f");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,0,0]&&Input.GetKey(KeyCode.D)){
						if (camera_at==5){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("l");
							Camera.main.audio.Play();
						}
					}
/*&&&&&&&&&&&&*&*&*&777777777777777777777777738329325283519*/
					else if(selectedFace==actualfaces[2,2,0]&&Input.GetKey(KeyCode.W)){
						if (camera_at==5){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("b^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,2,0]&&Input.GetKey(KeyCode.A)){
						if (camera_at==5){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("l^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,2,0]&&Input.GetKey(KeyCode.S)){
						if (camera_at==5){
							action("l");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("b");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,2,0]&&Input.GetKey(KeyCode.D)){
						if (camera_at==5){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("l^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("l");
							Camera.main.audio.Play();
						}
					}
/*&&&&&&&&&&&&*&*&*&777777777777777777777777738329325283519*/
					else if(selectedFace==actualfaces[2,0,2]&&Input.GetKey(KeyCode.W)){
						if (camera_at==5){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("f^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,0,2]&&Input.GetKey(KeyCode.A)){
						if (camera_at==5){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("r^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,0,2]&&Input.GetKey(KeyCode.S)){
						if (camera_at==5){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("f");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,0,2]&&Input.GetKey(KeyCode.D)){
						if (camera_at==5){
							action("f^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("f");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("r");
							Camera.main.audio.Play();
						}
					}
/*&&&&&&&&&&&&*&*&*&777777777777777777777777738329325283519*/
					else if(selectedFace==actualfaces[2,2,2]&&Input.GetKey(KeyCode.W)){
						if (camera_at==5){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("b^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,2,2]&&Input.GetKey(KeyCode.A)){
						if (camera_at==5){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("r^");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,2,2]&&Input.GetKey(KeyCode.S)){
						if (camera_at==5){
							action("r");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("b");
							Camera.main.audio.Play();
						}
					}
					else if(selectedFace==actualfaces[2,2,2]&&Input.GetKey(KeyCode.D)){
						if (camera_at==5){
							action("b^");
							Camera.main.audio.Play();
						}
						else if (camera_at==6){
							action("r^");
							Camera.main.audio.Play();
						}
						else if (camera_at==7){
							action("b");
							Camera.main.audio.Play();
						}
						else if (camera_at==8){
							action("r");
							Camera.main.audio.Play();
						}
					}
/*-------------------------------------------------------------------------------------------------------------------------*/
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.K)){
			Shuffle();
			AudioSource[] shuffle_noise = Camera.main.GetComponents<AudioSource>();
			shuffle_noise[1].Play();
		}
	}

	void action (string action_code){
		//36 Possible Movements//

		//Create the new cube
		if (action_code=="f"){

			Material[,,] temp_mat = new Material[6,3,3];

			actualfaces[0,2,0].renderer.material=dynamic_materials[4,2,2];
			perfaces[0,2,0].renderer.material=dynamic_materials[4,2,2];
			temp_mat[0,2,0]=dynamic_materials[4,2,2];
			actualfaces[0,2,1].renderer.material=dynamic_materials[4,1,2];
			perfaces[0,2,1].renderer.material=dynamic_materials[4,1,2];
			temp_mat[0,2,1]=dynamic_materials[4,1,2];
			actualfaces[0,2,2].renderer.material=dynamic_materials[4,0,2];
			perfaces[0,2,2].renderer.material=dynamic_materials[4,0,2];
			temp_mat[0,2,2]=dynamic_materials[4,0,2];

			actualfaces[5,0,0].renderer.material=dynamic_materials[0,2,0];
			perfaces[5,0,0].renderer.material=dynamic_materials[0,2,0];
			temp_mat[5,0,0]=dynamic_materials[0,2,0];
			actualfaces[5,1,0].renderer.material=dynamic_materials[0,2,1];
			perfaces[5,1,0].renderer.material=dynamic_materials[0,2,1];
			temp_mat[5,1,0]=dynamic_materials[0,2,1];
			actualfaces[5,2,0].renderer.material=dynamic_materials[0,2,2];
			perfaces[5,2,0].renderer.material=dynamic_materials[0,2,2];
			temp_mat[5,2,0]=dynamic_materials[0,2,2];

			actualfaces[2,0,0].renderer.material=dynamic_materials[5,2,0];
			perfaces[2,0,0].renderer.material=dynamic_materials[5,2,0];

			temp_mat[2,0,0]=dynamic_materials[5,2,0];
			actualfaces[2,0,1].renderer.material=dynamic_materials[5,1,0];
			perfaces[2,0,1].renderer.material=dynamic_materials[5,1,0];

			temp_mat[2,0,1]=dynamic_materials[5,1,0];
			actualfaces[2,0,2].renderer.material=dynamic_materials[5,0,0];
			perfaces[2,0,2].renderer.material=dynamic_materials[5,0,0];

			temp_mat[2,0,2]=dynamic_materials[5,0,0];

			actualfaces[4,0,2].renderer.material=dynamic_materials[2,0,0];
			perfaces[4,0,2].renderer.material=dynamic_materials[2,0,0];

			temp_mat[4,0,2]=dynamic_materials[2,0,0];
			actualfaces[4,1,2].renderer.material=dynamic_materials[2,0,1];
			perfaces[4,1,2].renderer.material=dynamic_materials[2,0,1];

			temp_mat[4,1,2]=dynamic_materials[2,0,1];
			actualfaces[4,2,2].renderer.material=dynamic_materials[2,0,2];
			perfaces[4,2,2].renderer.material=dynamic_materials[2,0,2];

			temp_mat[4,2,2]=dynamic_materials[2,0,2];

			dynamic_materials[0,2,0]=temp_mat[0,2,0];
			dynamic_materials[0,2,1]=temp_mat[0,2,1];
			dynamic_materials[0,2,2]=temp_mat[0,2,2];

			dynamic_materials[5,0,0]=temp_mat[5,0,0];
			dynamic_materials[5,1,0]=temp_mat[5,1,0];
			dynamic_materials[5,2,0]=temp_mat[5,2,0];

			dynamic_materials[2,0,0]=temp_mat[2,0,0];
			dynamic_materials[2,0,1]=temp_mat[2,0,1];
			dynamic_materials[2,0,2]=temp_mat[2,0,2];

			dynamic_materials[4,0,2]=temp_mat[4,0,2];
			dynamic_materials[4,1,2]=temp_mat[4,1,2];
			dynamic_materials[4,2,2]=temp_mat[4,2,2];

			actualfaces[1,0,0].renderer.material=dynamic_materials[1,2,0];
			perfaces[1,0,0].renderer.material=dynamic_materials[1,2,0];

			temp_mat[1,0,0]=dynamic_materials[1,2,0];
			actualfaces[1,0,1].renderer.material=dynamic_materials[1,1,0];
			perfaces[1,0,1].renderer.material=dynamic_materials[1,1,0];

			temp_mat[1,0,1]=dynamic_materials[1,1,0];
			actualfaces[1,0,2].renderer.material=dynamic_materials[1,0,0];
			perfaces[1,0,2].renderer.material=dynamic_materials[1,0,0];

			temp_mat[1,0,2]=dynamic_materials[1,0,0];

			actualfaces[1,1,0].renderer.material=dynamic_materials[1,2,1];
			perfaces[1,1,0].renderer.material=dynamic_materials[1,2,1];

			temp_mat[1,1,0]=dynamic_materials[1,2,1];
			actualfaces[1,1,2].renderer.material=dynamic_materials[1,0,1];
			perfaces[1,1,2].renderer.material=dynamic_materials[1,0,1];

			temp_mat[1,1,2]=dynamic_materials[1,0,1];

			actualfaces[1,2,0].renderer.material=dynamic_materials[1,2,2];
			perfaces[1,2,0].renderer.material=dynamic_materials[1,2,2];

			temp_mat[1,2,0]=dynamic_materials[1,2,2];
			actualfaces[1,2,1].renderer.material=dynamic_materials[1,1,2];
			perfaces[1,2,1].renderer.material=dynamic_materials[1,1,2];

			temp_mat[1,2,1]=dynamic_materials[1,1,2];
			actualfaces[1,2,2].renderer.material=dynamic_materials[1,0,2];
			perfaces[1,2,2].renderer.material=dynamic_materials[1,0,2];

			temp_mat[1,2,2]=dynamic_materials[1,0,2];

			dynamic_materials[1,0,0]=temp_mat[1,0,0];
			dynamic_materials[1,0,1]=temp_mat[1,0,1];
			dynamic_materials[1,0,2]=temp_mat[1,0,2];
			
			dynamic_materials[1,1,0]=temp_mat[1,1,0];
			dynamic_materials[1,1,2]=temp_mat[1,1,2];
			
			dynamic_materials[1,2,0]=temp_mat[1,2,0];
			dynamic_materials[1,2,1]=temp_mat[1,2,1];
			dynamic_materials[1,2,2]=temp_mat[1,2,2];

		}
		else if (action_code=="f^"){
			for (int i=0;i<3;i++){
				Material[,,] temp_mat = new Material[6,3,3];
				
				actualfaces[0,2,0].renderer.material=dynamic_materials[4,2,2];
				perfaces[0,2,0].renderer.material=dynamic_materials[4,2,2];

				temp_mat[0,2,0]=dynamic_materials[4,2,2];
				actualfaces[0,2,1].renderer.material=dynamic_materials[4,1,2];
				perfaces[0,2,1].renderer.material=dynamic_materials[4,1,2];
				temp_mat[0,2,1]=dynamic_materials[4,1,2];
				actualfaces[0,2,2].renderer.material=dynamic_materials[4,0,2];
				perfaces[0,2,2].renderer.material=dynamic_materials[4,0,2];
				temp_mat[0,2,2]=dynamic_materials[4,0,2];
				
				actualfaces[5,0,0].renderer.material=dynamic_materials[0,2,0];
				perfaces[5,0,0].renderer.material=dynamic_materials[0,2,0];
				temp_mat[5,0,0]=dynamic_materials[0,2,0];
				actualfaces[5,1,0].renderer.material=dynamic_materials[0,2,1];
				perfaces[5,1,0].renderer.material=dynamic_materials[0,2,1];
				temp_mat[5,1,0]=dynamic_materials[0,2,1];
				actualfaces[5,2,0].renderer.material=dynamic_materials[0,2,2];
				perfaces[5,2,0].renderer.material=dynamic_materials[0,2,2];
				temp_mat[5,2,0]=dynamic_materials[0,2,2];
				
				actualfaces[2,0,0].renderer.material=dynamic_materials[5,2,0];
				perfaces[2,0,0].renderer.material=dynamic_materials[5,2,0];
				temp_mat[2,0,0]=dynamic_materials[5,2,0];
				actualfaces[2,0,1].renderer.material=dynamic_materials[5,1,0];
				perfaces[2,0,1].renderer.material=dynamic_materials[5,1,0];
				temp_mat[2,0,1]=dynamic_materials[5,1,0];
				actualfaces[2,0,2].renderer.material=dynamic_materials[5,0,0];
				perfaces[2,0,2].renderer.material=dynamic_materials[5,0,0];
				temp_mat[2,0,2]=dynamic_materials[5,0,0];
				
				actualfaces[4,0,2].renderer.material=dynamic_materials[2,0,0];
				perfaces[4,0,2].renderer.material=dynamic_materials[2,0,0];
				temp_mat[4,0,2]=dynamic_materials[2,0,0];
				actualfaces[4,1,2].renderer.material=dynamic_materials[2,0,1];
				perfaces[4,1,2].renderer.material=dynamic_materials[2,0,1];
				temp_mat[4,1,2]=dynamic_materials[2,0,1];
				actualfaces[4,2,2].renderer.material=dynamic_materials[2,0,2];
				perfaces[4,2,2].renderer.material=dynamic_materials[2,0,2];
				temp_mat[4,2,2]=dynamic_materials[2,0,2];
				
				dynamic_materials[0,2,0]=temp_mat[0,2,0];
				dynamic_materials[0,2,1]=temp_mat[0,2,1];
				dynamic_materials[0,2,2]=temp_mat[0,2,2];
				
				dynamic_materials[5,0,0]=temp_mat[5,0,0];
				dynamic_materials[5,1,0]=temp_mat[5,1,0];
				dynamic_materials[5,2,0]=temp_mat[5,2,0];
				
				dynamic_materials[2,0,0]=temp_mat[2,0,0];
				dynamic_materials[2,0,1]=temp_mat[2,0,1];
				dynamic_materials[2,0,2]=temp_mat[2,0,2];
				
				dynamic_materials[4,0,2]=temp_mat[4,0,2];
				dynamic_materials[4,1,2]=temp_mat[4,1,2];
				dynamic_materials[4,2,2]=temp_mat[4,2,2];
				
				actualfaces[1,0,0].renderer.material=dynamic_materials[1,2,0];
				perfaces[1,0,0].renderer.material=dynamic_materials[1,2,0];
				temp_mat[1,0,0]=dynamic_materials[1,2,0];
				actualfaces[1,0,1].renderer.material=dynamic_materials[1,1,0];
				perfaces[1,0,1].renderer.material=dynamic_materials[1,1,0];
				temp_mat[1,0,1]=dynamic_materials[1,1,0];
				actualfaces[1,0,2].renderer.material=dynamic_materials[1,0,0];
				perfaces[1,0,2].renderer.material=dynamic_materials[1,0,0];
				temp_mat[1,0,2]=dynamic_materials[1,0,0];
				
				actualfaces[1,1,0].renderer.material=dynamic_materials[1,2,1];
				perfaces[1,1,0].renderer.material=dynamic_materials[1,2,1];
				temp_mat[1,1,0]=dynamic_materials[1,2,1];
				actualfaces[1,1,2].renderer.material=dynamic_materials[1,0,1];
				perfaces[1,1,2].renderer.material=dynamic_materials[1,0,1];
				temp_mat[1,1,2]=dynamic_materials[1,0,1];
				
				actualfaces[1,2,0].renderer.material=dynamic_materials[1,2,2];
				perfaces[1,2,0].renderer.material=dynamic_materials[1,2,2];
				temp_mat[1,2,0]=dynamic_materials[1,2,2];
				actualfaces[1,2,1].renderer.material=dynamic_materials[1,1,2];
				perfaces[1,2,1].renderer.material=dynamic_materials[1,1,2];
				temp_mat[1,2,1]=dynamic_materials[1,1,2];
				actualfaces[1,2,2].renderer.material=dynamic_materials[1,0,2];
				perfaces[1,2,2].renderer.material=dynamic_materials[1,0,2];
				temp_mat[1,2,2]=dynamic_materials[1,0,2];
				
				dynamic_materials[1,0,0]=temp_mat[1,0,0];
				dynamic_materials[1,0,1]=temp_mat[1,0,1];
				dynamic_materials[1,0,2]=temp_mat[1,0,2];
				
				dynamic_materials[1,1,0]=temp_mat[1,1,0];
				dynamic_materials[1,1,2]=temp_mat[1,1,2];
				
				dynamic_materials[1,2,0]=temp_mat[1,2,0];
				dynamic_materials[1,2,1]=temp_mat[1,2,1];
				dynamic_materials[1,2,2]=temp_mat[1,2,2];

		
			}
		}
		else if (action_code=="b"){

			Material[,,] temp_mat = new Material[6,3,3];

			actualfaces[0,0,0].renderer.material=dynamic_materials[4,2,0];
			perfaces[0,0,0].renderer.material=dynamic_materials[4,2,0];
			temp_mat[0,0,0]=dynamic_materials[4,2,0];
			actualfaces[0,0,1].renderer.material=dynamic_materials[4,1,0];
			perfaces[0,0,1].renderer.material=dynamic_materials[4,1,0];
			temp_mat[0,0,1]=dynamic_materials[4,1,0];
			actualfaces[0,0,2].renderer.material=dynamic_materials[4,0,0];
			perfaces[0,0,2].renderer.material=dynamic_materials[4,0,0];
			temp_mat[0,0,2]=dynamic_materials[4,0,0];
			
			actualfaces[5,0,2].renderer.material=dynamic_materials[0,0,0];
			perfaces[5,0,2].renderer.material=dynamic_materials[0,0,0];
			temp_mat[5,0,2]=dynamic_materials[0,0,0];
			actualfaces[5,1,2].renderer.material=dynamic_materials[0,0,1];
			perfaces[5,1,2].renderer.material=dynamic_materials[0,0,1];
			temp_mat[5,1,2]=dynamic_materials[0,0,1];
			actualfaces[5,2,2].renderer.material=dynamic_materials[0,0,2];
			perfaces[5,2,2].renderer.material=dynamic_materials[0,0,2];
			temp_mat[5,2,2]=dynamic_materials[0,0,2];
			
			actualfaces[2,2,0].renderer.material=dynamic_materials[5,2,2];
			perfaces[2,2,0].renderer.material=dynamic_materials[5,2,2];
			temp_mat[2,2,0]=dynamic_materials[5,2,2];
			actualfaces[2,2,1].renderer.material=dynamic_materials[5,1,2];
			perfaces[2,2,1].renderer.material=dynamic_materials[5,1,2];
			temp_mat[2,2,1]=dynamic_materials[5,1,2];
			actualfaces[2,2,2].renderer.material=dynamic_materials[5,0,2];
			perfaces[2,2,2].renderer.material=dynamic_materials[5,0,2];
			temp_mat[2,2,2]=dynamic_materials[5,0,2];
			
			actualfaces[4,0,0].renderer.material=dynamic_materials[2,2,0];
			perfaces[4,0,0].renderer.material=dynamic_materials[2,2,0];
			temp_mat[4,0,0]=dynamic_materials[2,2,0];
			actualfaces[4,1,0].renderer.material=dynamic_materials[2,2,1];
			perfaces[4,1,0].renderer.material=dynamic_materials[2,2,1];
			temp_mat[4,1,0]=dynamic_materials[2,2,1];
			actualfaces[4,2,0].renderer.material=dynamic_materials[2,2,2];
			perfaces[4,2,0].renderer.material=dynamic_materials[2,2,2];
			temp_mat[4,2,0]=dynamic_materials[2,2,2];
			
			dynamic_materials[0,0,0]=temp_mat[0,0,0];
			dynamic_materials[0,0,1]=temp_mat[0,0,1];
			dynamic_materials[0,0,2]=temp_mat[0,0,2];
			
			dynamic_materials[5,0,2]=temp_mat[5,0,2];
			dynamic_materials[5,1,2]=temp_mat[5,1,2];
			dynamic_materials[5,2,2]=temp_mat[5,2,2];
			
			dynamic_materials[2,2,0]=temp_mat[2,2,0];
			dynamic_materials[2,2,1]=temp_mat[2,2,1];
			dynamic_materials[2,2,2]=temp_mat[2,2,2];
			
			dynamic_materials[4,0,0]=temp_mat[4,0,0];
			dynamic_materials[4,1,0]=temp_mat[4,1,0];
			dynamic_materials[4,2,0]=temp_mat[4,2,0];
			
			actualfaces[3,0,0].renderer.material=dynamic_materials[3,0,2];
			perfaces[3,0,0].renderer.material=dynamic_materials[3,0,2];
			temp_mat[3,0,0]=dynamic_materials[3,0,2];
			actualfaces[3,0,1].renderer.material=dynamic_materials[3,1,2];
			perfaces[3,0,1].renderer.material=dynamic_materials[3,1,2];
			temp_mat[3,0,1]=dynamic_materials[3,1,2];
			actualfaces[3,0,2].renderer.material=dynamic_materials[3,2,2];
			perfaces[3,0,2].renderer.material=dynamic_materials[3,2,2];
			temp_mat[3,0,2]=dynamic_materials[3,2,2];
			
			actualfaces[3,1,0].renderer.material=dynamic_materials[3,0,1];
			perfaces[3,1,0].renderer.material=dynamic_materials[3,0,1];
			temp_mat[3,1,0]=dynamic_materials[3,0,1];
			actualfaces[3,1,2].renderer.material=dynamic_materials[3,2,1];
			perfaces[3,1,2].renderer.material=dynamic_materials[3,2,1];
			temp_mat[3,1,2]=dynamic_materials[3,2,1];
			
			actualfaces[3,2,0].renderer.material=dynamic_materials[3,0,0];
			perfaces[3,2,0].renderer.material=dynamic_materials[3,0,0];
			temp_mat[3,2,0]=dynamic_materials[3,0,0];
			actualfaces[3,2,1].renderer.material=dynamic_materials[3,1,0];
			perfaces[3,2,1].renderer.material=dynamic_materials[3,1,0];
			temp_mat[3,2,1]=dynamic_materials[3,1,0];
			actualfaces[3,2,2].renderer.material=dynamic_materials[3,2,0];
			perfaces[3,2,2].renderer.material=dynamic_materials[3,2,0];
			temp_mat[3,2,2]=dynamic_materials[3,2,0];
			
			dynamic_materials[3,0,0]=temp_mat[3,0,0];
			dynamic_materials[3,0,1]=temp_mat[3,0,1];
			dynamic_materials[3,0,2]=temp_mat[3,0,2];
			
			dynamic_materials[3,1,0]=temp_mat[3,1,0];
			dynamic_materials[3,1,2]=temp_mat[3,1,2];
			
			dynamic_materials[3,2,0]=temp_mat[3,2,0];
			dynamic_materials[3,2,1]=temp_mat[3,2,1];
			dynamic_materials[3,2,2]=temp_mat[3,2,2];

		}
		else if (action_code=="b^"){
			for (int i=0;i<3;i++){

				Material[,,] temp_mat = new Material[6,3,3];

				actualfaces[0,0,0].renderer.material=dynamic_materials[4,2,0];
				perfaces[0,0,0].renderer.material=dynamic_materials[4,2,0];
				temp_mat[0,0,0]=dynamic_materials[4,2,0];
				actualfaces[0,0,1].renderer.material=dynamic_materials[4,1,0];
				perfaces[0,0,1].renderer.material=dynamic_materials[4,1,0];
				temp_mat[0,0,1]=dynamic_materials[4,1,0];
				actualfaces[0,0,2].renderer.material=dynamic_materials[4,0,0];
				perfaces[0,0,2].renderer.material=dynamic_materials[4,0,0];
				temp_mat[0,0,2]=dynamic_materials[4,0,0];
				
				actualfaces[5,0,2].renderer.material=dynamic_materials[0,0,0];
				perfaces[5,0,2].renderer.material=dynamic_materials[0,0,0];
				temp_mat[5,0,2]=dynamic_materials[0,0,0];
				actualfaces[5,1,2].renderer.material=dynamic_materials[0,0,1];
				perfaces[5,1,2].renderer.material=dynamic_materials[0,0,1];
				temp_mat[5,1,2]=dynamic_materials[0,0,1];
				actualfaces[5,2,2].renderer.material=dynamic_materials[0,0,2];
				perfaces[5,2,2].renderer.material=dynamic_materials[0,0,2];
				temp_mat[5,2,2]=dynamic_materials[0,0,2];
				
				actualfaces[2,2,0].renderer.material=dynamic_materials[5,2,2];
				perfaces[2,2,0].renderer.material=dynamic_materials[5,2,2];
				temp_mat[2,2,0]=dynamic_materials[5,2,2];
				actualfaces[2,2,1].renderer.material=dynamic_materials[5,1,2];
				perfaces[2,2,1].renderer.material=dynamic_materials[5,1,2];
				temp_mat[2,2,1]=dynamic_materials[5,1,2];
				actualfaces[2,2,2].renderer.material=dynamic_materials[5,0,2];
				perfaces[2,2,2].renderer.material=dynamic_materials[5,0,2];
				temp_mat[2,2,2]=dynamic_materials[5,0,2];
				
				actualfaces[4,0,0].renderer.material=dynamic_materials[2,2,0];
				perfaces[4,0,0].renderer.material=dynamic_materials[2,2,0];
				temp_mat[4,0,0]=dynamic_materials[2,2,0];
				actualfaces[4,1,0].renderer.material=dynamic_materials[2,2,1];
				perfaces[4,1,0].renderer.material=dynamic_materials[2,2,1];
				temp_mat[4,1,0]=dynamic_materials[2,2,1];
				actualfaces[4,2,0].renderer.material=dynamic_materials[2,2,2];
				perfaces[4,2,0].renderer.material=dynamic_materials[2,2,2];
				temp_mat[4,2,0]=dynamic_materials[2,2,2];
				
				dynamic_materials[0,0,0]=temp_mat[0,0,0];
				dynamic_materials[0,0,1]=temp_mat[0,0,1];
				dynamic_materials[0,0,2]=temp_mat[0,0,2];
				
				dynamic_materials[5,0,2]=temp_mat[5,0,2];
				dynamic_materials[5,1,2]=temp_mat[5,1,2];
				dynamic_materials[5,2,2]=temp_mat[5,2,2];
				
				dynamic_materials[2,2,0]=temp_mat[2,2,0];
				dynamic_materials[2,2,1]=temp_mat[2,2,1];
				dynamic_materials[2,2,2]=temp_mat[2,2,2];
				
				dynamic_materials[4,0,0]=temp_mat[4,0,0];
				dynamic_materials[4,1,0]=temp_mat[4,1,0];
				dynamic_materials[4,2,0]=temp_mat[4,2,0];
				
				actualfaces[3,0,0].renderer.material=dynamic_materials[3,0,2];
				perfaces[3,0,0].renderer.material=dynamic_materials[3,0,2];
				temp_mat[3,0,0]=dynamic_materials[3,0,2];
				perfaces[3,0,1].renderer.material=dynamic_materials[3,1,2];
				actualfaces[3,0,1].renderer.material=dynamic_materials[3,1,2];
				temp_mat[3,0,1]=dynamic_materials[3,1,2];
				actualfaces[3,0,2].renderer.material=dynamic_materials[3,2,2];
				perfaces[3,0,2].renderer.material=dynamic_materials[3,2,2];
				temp_mat[3,0,2]=dynamic_materials[3,2,2];
				
				actualfaces[3,1,0].renderer.material=dynamic_materials[3,0,1];
				perfaces[3,1,0].renderer.material=dynamic_materials[3,0,1];
				temp_mat[3,1,0]=dynamic_materials[3,0,1];
				actualfaces[3,1,2].renderer.material=dynamic_materials[3,2,1];
				perfaces[3,1,2].renderer.material=dynamic_materials[3,2,1];
				temp_mat[3,1,2]=dynamic_materials[3,2,1];
				
				actualfaces[3,2,0].renderer.material=dynamic_materials[3,0,0];
				perfaces[3,2,0].renderer.material=dynamic_materials[3,0,0];
				temp_mat[3,2,0]=dynamic_materials[3,0,0];
				actualfaces[3,2,1].renderer.material=dynamic_materials[3,1,0];
				perfaces[3,2,1].renderer.material=dynamic_materials[3,1,0];
				temp_mat[3,2,1]=dynamic_materials[3,1,0];
				actualfaces[3,2,2].renderer.material=dynamic_materials[3,2,0];
				perfaces[3,2,2].renderer.material=dynamic_materials[3,2,0];
				temp_mat[3,2,2]=dynamic_materials[3,2,0];
				
				dynamic_materials[3,0,0]=temp_mat[3,0,0];
				dynamic_materials[3,0,1]=temp_mat[3,0,1];
				dynamic_materials[3,0,2]=temp_mat[3,0,2];
				
				dynamic_materials[3,1,0]=temp_mat[3,1,0];
				dynamic_materials[3,1,2]=temp_mat[3,1,2];
				
				dynamic_materials[3,2,0]=temp_mat[3,2,0];
				dynamic_materials[3,2,1]=temp_mat[3,2,1];
				dynamic_materials[3,2,2]=temp_mat[3,2,2];
			}
		}
		else if (action_code=="l"){
			//Rotate the left side clockwise
			Material[,,] temp_mat = new Material[6,3,3];
			for (int a=0;a<4;a++){
				for (int b=0;b<3;b++){
					if (a==0){
						actualfaces[a,b,0].renderer.material=dynamic_materials[3,b,0];
						perfaces[a,b,0].renderer.material=dynamic_materials[3,b,0];
						temp_mat[a,b,0]=dynamic_materials[3,b,0];
					}
					else{
						actualfaces[a,b,0].renderer.material=dynamic_materials[a-1,b,0];
						perfaces[a,b,0].renderer.material=dynamic_materials[a-1,b,0];
						temp_mat[a,b,0]=dynamic_materials[a-1,b,0];
					}
				}
			}

			dynamic_materials[0,0,0]=temp_mat[0,0,0];
			dynamic_materials[0,1,0]=temp_mat[0,1,0];
			dynamic_materials[0,2,0]=temp_mat[0,2,0];
			
			dynamic_materials[1,0,0]=temp_mat[1,0,0];
			dynamic_materials[1,1,0]=temp_mat[1,1,0];
			dynamic_materials[1,2,0]=temp_mat[1,2,0];
			
			dynamic_materials[2,0,0]=temp_mat[2,0,0];
			dynamic_materials[2,1,0]=temp_mat[2,1,0];
			dynamic_materials[2,2,0]=temp_mat[2,2,0];
			
			dynamic_materials[3,0,0]=temp_mat[3,0,0];
			dynamic_materials[3,1,0]=temp_mat[3,1,0];
			dynamic_materials[3,2,0]=temp_mat[3,2,0];

			//Rotate the left face clockwise

			actualfaces[4,0,0].renderer.material=dynamic_materials[4,2,0];
			perfaces[4,0,0].renderer.material=dynamic_materials[4,2,0];
			temp_mat[4,0,0]=dynamic_materials[4,2,0];
			actualfaces[4,0,1].renderer.material=dynamic_materials[4,1,0];
			perfaces[4,0,1].renderer.material=dynamic_materials[4,1,0];
			temp_mat[4,0,1]=dynamic_materials[4,1,0];
			actualfaces[4,0,2].renderer.material=dynamic_materials[4,0,0];
			perfaces[4,0,2].renderer.material=dynamic_materials[4,0,0];
			temp_mat[4,0,2]=dynamic_materials[4,0,0];
			
			actualfaces[4,1,0].renderer.material=dynamic_materials[4,2,1];
			perfaces[4,1,0].renderer.material=dynamic_materials[4,2,1];
			temp_mat[4,1,0]=dynamic_materials[4,2,1];
			actualfaces[4,1,2].renderer.material=dynamic_materials[4,0,1];
			perfaces[4,1,2].renderer.material=dynamic_materials[4,0,1];
			temp_mat[4,1,2]=dynamic_materials[4,0,1];
			
			actualfaces[4,2,0].renderer.material=dynamic_materials[4,2,2];
			perfaces[4,2,0].renderer.material=dynamic_materials[4,2,2];
			temp_mat[4,2,0]=dynamic_materials[4,2,2];
			actualfaces[4,2,1].renderer.material=dynamic_materials[4,1,2];
			perfaces[4,2,1].renderer.material=dynamic_materials[4,1,2];
			temp_mat[4,2,1]=dynamic_materials[4,1,2];
			actualfaces[4,2,2].renderer.material=dynamic_materials[4,0,2];
			perfaces[4,2,2].renderer.material=dynamic_materials[4,0,2];
			temp_mat[4,2,2]=dynamic_materials[4,0,2];

			dynamic_materials[4,0,0]=temp_mat[4,0,0];
			dynamic_materials[4,0,1]=temp_mat[4,0,1];
			dynamic_materials[4,0,2]=temp_mat[4,0,2];
			
			dynamic_materials[4,1,0]=temp_mat[4,1,0];
			dynamic_materials[4,1,2]=temp_mat[4,1,2];
			
			dynamic_materials[4,2,0]=temp_mat[4,2,0];
			dynamic_materials[4,2,1]=temp_mat[4,2,1];
			dynamic_materials[4,2,2]=temp_mat[4,2,2];

		}
		else if (action_code=="l^"){
			for (int i=0;i<3;i++){
				Material[,,] temp_mat = new Material[6,3,3];
				for (int a=0;a<4;a++){
					for (int b=0;b<3;b++){
						if (a==0){
							actualfaces[a,b,0].renderer.material=dynamic_materials[3,b,0];
							perfaces[a,b,0].renderer.material=dynamic_materials[3,b,0];
							temp_mat[a,b,0]=dynamic_materials[3,b,0];
						}
						else{
							actualfaces[a,b,0].renderer.material=dynamic_materials[a-1,b,0];
							perfaces[a,b,0].renderer.material=dynamic_materials[a-1,b,0];
							temp_mat[a,b,0]=dynamic_materials[a-1,b,0];
						}
					}
				}
				
				dynamic_materials[0,0,0]=temp_mat[0,0,0];
				dynamic_materials[0,1,0]=temp_mat[0,1,0];
				dynamic_materials[0,2,0]=temp_mat[0,2,0];
				
				dynamic_materials[1,0,0]=temp_mat[1,0,0];
				dynamic_materials[1,1,0]=temp_mat[1,1,0];
				dynamic_materials[1,2,0]=temp_mat[1,2,0];
				
				dynamic_materials[2,0,0]=temp_mat[2,0,0];
				dynamic_materials[2,1,0]=temp_mat[2,1,0];
				dynamic_materials[2,2,0]=temp_mat[2,2,0];
				
				dynamic_materials[3,0,0]=temp_mat[3,0,0];
				dynamic_materials[3,1,0]=temp_mat[3,1,0];
				dynamic_materials[3,2,0]=temp_mat[3,2,0];
				
				//Rotate the left face clockwise
				
				actualfaces[4,0,0].renderer.material=dynamic_materials[4,2,0];
				perfaces[4,0,0].renderer.material=dynamic_materials[4,2,0];
				temp_mat[4,0,0]=dynamic_materials[4,2,0];
				actualfaces[4,0,1].renderer.material=dynamic_materials[4,1,0];
				perfaces[4,0,1].renderer.material=dynamic_materials[4,1,0];
				temp_mat[4,0,1]=dynamic_materials[4,1,0];
				actualfaces[4,0,2].renderer.material=dynamic_materials[4,0,0];
				perfaces[4,0,2].renderer.material=dynamic_materials[4,0,0];
				temp_mat[4,0,2]=dynamic_materials[4,0,0];
				
				actualfaces[4,1,0].renderer.material=dynamic_materials[4,2,1];
				perfaces[4,1,0].renderer.material=dynamic_materials[4,2,1];
				temp_mat[4,1,0]=dynamic_materials[4,2,1];
				actualfaces[4,1,2].renderer.material=dynamic_materials[4,0,1];
				perfaces[4,1,2].renderer.material=dynamic_materials[4,0,1];
				temp_mat[4,1,2]=dynamic_materials[4,0,1];
				
				actualfaces[4,2,0].renderer.material=dynamic_materials[4,2,2];
				perfaces[4,2,0].renderer.material=dynamic_materials[4,2,2];
				temp_mat[4,2,0]=dynamic_materials[4,2,2];
				actualfaces[4,2,1].renderer.material=dynamic_materials[4,1,2];
				perfaces[4,2,1].renderer.material=dynamic_materials[4,1,2];
				temp_mat[4,2,1]=dynamic_materials[4,1,2];
				actualfaces[4,2,2].renderer.material=dynamic_materials[4,0,2];
				perfaces[4,2,2].renderer.material=dynamic_materials[4,0,2];
				temp_mat[4,2,2]=dynamic_materials[4,0,2];
				
				dynamic_materials[4,0,0]=temp_mat[4,0,0];
				dynamic_materials[4,0,1]=temp_mat[4,0,1];
				dynamic_materials[4,0,2]=temp_mat[4,0,2];
				
				dynamic_materials[4,1,0]=temp_mat[4,1,0];
				dynamic_materials[4,1,2]=temp_mat[4,1,2];
				
				dynamic_materials[4,2,0]=temp_mat[4,2,0];
				dynamic_materials[4,2,1]=temp_mat[4,2,1];
				dynamic_materials[4,2,2]=temp_mat[4,2,2];
			}
		}
		else if (action_code=="r"){

			Material[,,] temp_mat = new Material[6,3,3];

			for (int a=0;a<4;a++){
				for (int b=0;b<3;b++){
					if (a==0){
						actualfaces[a,b,2].renderer.material=dynamic_materials[3,b,2];
						perfaces[a,b,2].renderer.material=dynamic_materials[3,b,2];
						temp_mat[a,b,2]=dynamic_materials[3,b,2];
					}
					else{
						actualfaces[a,b,2].renderer.material=dynamic_materials[a-1,b,2];
						perfaces[a,b,2].renderer.material=dynamic_materials[a-1,b,2];
						temp_mat[a,b,2]=dynamic_materials[a-1,b,2];
					}
				}
			}
			
			dynamic_materials[0,0,2]=temp_mat[0,0,2];
			dynamic_materials[0,1,2]=temp_mat[0,1,2];
			dynamic_materials[0,2,2]=temp_mat[0,2,2];
			
			dynamic_materials[1,0,2]=temp_mat[1,0,2];
			dynamic_materials[1,1,2]=temp_mat[1,1,2];
			dynamic_materials[1,2,2]=temp_mat[1,2,2];
			
			dynamic_materials[2,0,2]=temp_mat[2,0,2];
			dynamic_materials[2,1,2]=temp_mat[2,1,2];
			dynamic_materials[2,2,2]=temp_mat[2,2,2];
			
			dynamic_materials[3,0,2]=temp_mat[3,0,2];
			dynamic_materials[3,1,2]=temp_mat[3,1,2];
			dynamic_materials[3,2,2]=temp_mat[3,2,2];

			actualfaces[5,0,0].renderer.material=dynamic_materials[5,0,2];
			perfaces[5,0,0].renderer.material=dynamic_materials[5,0,2];
			temp_mat[5,0,0]=dynamic_materials[5,0,2];
			actualfaces[5,0,1].renderer.material=dynamic_materials[5,1,2];
			perfaces[5,0,1].renderer.material=dynamic_materials[5,1,2];
			temp_mat[5,0,1]=dynamic_materials[5,1,2];
			actualfaces[5,0,2].renderer.material=dynamic_materials[5,2,2];
			perfaces[5,0,2].renderer.material=dynamic_materials[5,2,2];
			temp_mat[5,0,2]=dynamic_materials[5,2,2];
		
			actualfaces[5,1,0].renderer.material=dynamic_materials[5,0,1];
			perfaces[5,1,0].renderer.material=dynamic_materials[5,0,1];
			temp_mat[5,1,0]=dynamic_materials[5,0,1];
			actualfaces[5,1,2].renderer.material=dynamic_materials[5,2,1];
			perfaces[5,1,2].renderer.material=dynamic_materials[5,2,1];
			temp_mat[5,1,2]=dynamic_materials[5,2,1];
			
			actualfaces[5,2,0].renderer.material=dynamic_materials[5,0,0];
			perfaces[5,2,0].renderer.material=dynamic_materials[5,0,0];
			temp_mat[5,2,0]=dynamic_materials[5,0,0];
			actualfaces[5,2,1].renderer.material=dynamic_materials[5,1,0];
			perfaces[5,2,1].renderer.material=dynamic_materials[5,1,0];
			temp_mat[5,2,1]=dynamic_materials[5,1,0];
			actualfaces[5,2,2].renderer.material=dynamic_materials[5,2,0];
			perfaces[5,2,2].renderer.material=dynamic_materials[5,2,0];
			temp_mat[5,2,2]=dynamic_materials[5,2,0];
			
			dynamic_materials[5,0,0]=temp_mat[5,0,0];
			dynamic_materials[5,0,1]=temp_mat[5,0,1];
			dynamic_materials[5,0,2]=temp_mat[5,0,2];
			
			dynamic_materials[5,1,0]=temp_mat[5,1,0];
			dynamic_materials[5,1,2]=temp_mat[5,1,2];
			
			dynamic_materials[5,2,0]=temp_mat[5,2,0];
			dynamic_materials[5,2,1]=temp_mat[5,2,1];
			dynamic_materials[5,2,2]=temp_mat[5,2,2];

		}
		else if (action_code=="r^"){
			for (int i=0;i<3;i++){
				
				Material[,,] temp_mat = new Material[6,3,3];
				
				for (int a=0;a<4;a++){
					for (int b=0;b<3;b++){
						if (a==0){
							actualfaces[a,b,2].renderer.material=dynamic_materials[3,b,2];
							perfaces[a,b,2].renderer.material=dynamic_materials[3,b,2];
							temp_mat[a,b,2]=dynamic_materials[3,b,2];
						}
						else{
							actualfaces[a,b,2].renderer.material=dynamic_materials[a-1,b,2];
							perfaces[a,b,2].renderer.material=dynamic_materials[a-1,b,2];
							temp_mat[a,b,2]=dynamic_materials[a-1,b,2];
						}
					}
				}
				
				dynamic_materials[0,0,2]=temp_mat[0,0,2];
				dynamic_materials[0,1,2]=temp_mat[0,1,2];
				dynamic_materials[0,2,2]=temp_mat[0,2,2];
				
				dynamic_materials[1,0,2]=temp_mat[1,0,2];
				dynamic_materials[1,1,2]=temp_mat[1,1,2];
				dynamic_materials[1,2,2]=temp_mat[1,2,2];
				
				dynamic_materials[2,0,2]=temp_mat[2,0,2];
				dynamic_materials[2,1,2]=temp_mat[2,1,2];
				dynamic_materials[2,2,2]=temp_mat[2,2,2];
				
				dynamic_materials[3,0,2]=temp_mat[3,0,2];
				dynamic_materials[3,1,2]=temp_mat[3,1,2];
				dynamic_materials[3,2,2]=temp_mat[3,2,2];
				
				actualfaces[5,0,0].renderer.material=dynamic_materials[5,0,2];
				perfaces[5,0,0].renderer.material=dynamic_materials[5,0,2];
				temp_mat[5,0,0]=dynamic_materials[5,0,2];
				actualfaces[5,0,1].renderer.material=dynamic_materials[5,1,2];
				perfaces[5,0,1].renderer.material=dynamic_materials[5,1,2];
				temp_mat[5,0,1]=dynamic_materials[5,1,2];
				actualfaces[5,0,2].renderer.material=dynamic_materials[5,2,2];
				perfaces[5,0,2].renderer.material=dynamic_materials[5,2,2];
				temp_mat[5,0,2]=dynamic_materials[5,2,2];
				
				actualfaces[5,1,0].renderer.material=dynamic_materials[5,0,1];
				perfaces[5,1,0].renderer.material=dynamic_materials[5,0,1];
				temp_mat[5,1,0]=dynamic_materials[5,0,1];
				actualfaces[5,1,2].renderer.material=dynamic_materials[5,2,1];
				perfaces[5,1,2].renderer.material=dynamic_materials[5,2,1];
				temp_mat[5,1,2]=dynamic_materials[5,2,1];
				
				actualfaces[5,2,0].renderer.material=dynamic_materials[5,0,0];
				perfaces[5,2,0].renderer.material=dynamic_materials[5,0,0];
				temp_mat[5,2,0]=dynamic_materials[5,0,0];
				actualfaces[5,2,1].renderer.material=dynamic_materials[5,1,0];
				perfaces[5,2,1].renderer.material=dynamic_materials[5,1,0];
				temp_mat[5,2,1]=dynamic_materials[5,1,0];
				actualfaces[5,2,2].renderer.material=dynamic_materials[5,2,0];
				perfaces[5,2,2].renderer.material=dynamic_materials[5,2,0];
				temp_mat[5,2,2]=dynamic_materials[5,2,0];
				
				dynamic_materials[5,0,0]=temp_mat[5,0,0];
				dynamic_materials[5,0,1]=temp_mat[5,0,1];
				dynamic_materials[5,0,2]=temp_mat[5,0,2];
				
				dynamic_materials[5,1,0]=temp_mat[5,1,0];
				dynamic_materials[5,1,2]=temp_mat[5,1,2];
				
				dynamic_materials[5,2,0]=temp_mat[5,2,0];
				dynamic_materials[5,2,1]=temp_mat[5,2,1];
				dynamic_materials[5,2,2]=temp_mat[5,2,2];
			}
		}
		else if (action_code=="t"){

			Material[,,] temp_mat = new Material[6,3,3];

			actualfaces[1,0,0].renderer.material=dynamic_materials[4,0,0];
			perfaces[1,0,0].renderer.material=dynamic_materials[4,0,0];
			temp_mat[1,0,0]=dynamic_materials[4,0,0];
			actualfaces[1,0,1].renderer.material=dynamic_materials[4,0,1];
			perfaces[1,0,1].renderer.material=dynamic_materials[4,0,1];
			temp_mat[1,0,1]=dynamic_materials[4,0,1];
			actualfaces[1,0,2].renderer.material=dynamic_materials[4,0,2];
			perfaces[1,0,2].renderer.material=dynamic_materials[4,0,2];
			temp_mat[1,0,2]=dynamic_materials[4,0,2];

			actualfaces[5,0,0].renderer.material=dynamic_materials[1,0,0];
			perfaces[5,0,0].renderer.material=dynamic_materials[1,0,0];
			temp_mat[5,0,0]=dynamic_materials[1,0,0];
			actualfaces[5,0,1].renderer.material=dynamic_materials[1,0,1];
			perfaces[5,0,1].renderer.material=dynamic_materials[1,0,1];
			temp_mat[5,0,1]=dynamic_materials[1,0,1];
			actualfaces[5,0,2].renderer.material=dynamic_materials[1,0,2];
			perfaces[5,0,2].renderer.material=dynamic_materials[1,0,2];
			temp_mat[5,0,2]=dynamic_materials[1,0,2];

			actualfaces[3,2,2].renderer.material=dynamic_materials[5,0,0];
			perfaces[3,2,2].renderer.material=dynamic_materials[5,0,0];
			temp_mat[3,2,2]=dynamic_materials[5,0,0];
			actualfaces[3,2,1].renderer.material=dynamic_materials[5,0,1];
			perfaces[3,2,1].renderer.material=dynamic_materials[5,0,1];
			temp_mat[3,2,1]=dynamic_materials[5,0,1];
			actualfaces[3,2,0].renderer.material=dynamic_materials[5,0,2];
			perfaces[3,2,0].renderer.material=dynamic_materials[5,0,2];
			temp_mat[3,2,0]=dynamic_materials[5,0,2];

			actualfaces[4,0,0].renderer.material=dynamic_materials[3,2,2];
			perfaces[4,0,0].renderer.material=dynamic_materials[3,2,2];
			temp_mat[4,0,0]=dynamic_materials[3,2,2];
			actualfaces[4,0,1].renderer.material=dynamic_materials[3,2,1];
			perfaces[4,0,1].renderer.material=dynamic_materials[3,2,1];
			temp_mat[4,0,1]=dynamic_materials[3,2,1];
			actualfaces[4,0,2].renderer.material=dynamic_materials[3,2,0];
			perfaces[4,0,2].renderer.material=dynamic_materials[3,2,0];
			temp_mat[4,0,2]=dynamic_materials[3,2,0];

			dynamic_materials[1,0,0]=temp_mat[1,0,0];
			dynamic_materials[1,0,1]=temp_mat[1,0,1];
			dynamic_materials[1,0,2]=temp_mat[1,0,2];
			
			dynamic_materials[5,0,0]=temp_mat[5,0,0];
			dynamic_materials[5,0,1]=temp_mat[5,0,1];
			dynamic_materials[5,0,2]=temp_mat[5,0,2];
			
			dynamic_materials[3,2,2]=temp_mat[3,2,2];
			dynamic_materials[3,2,1]=temp_mat[3,2,1];
			dynamic_materials[3,2,0]=temp_mat[3,2,0];
			
			dynamic_materials[4,0,0]=temp_mat[4,0,0];
			dynamic_materials[4,0,1]=temp_mat[4,0,1];
			dynamic_materials[4,0,2]=temp_mat[4,0,2];

			actualfaces[0,0,0].renderer.material=dynamic_materials[0,0,2];
			perfaces[0,0,0].renderer.material=dynamic_materials[0,0,2];
			temp_mat[0,0,0]=dynamic_materials[0,0,2];
			actualfaces[0,0,1].renderer.material=dynamic_materials[0,1,2];
			perfaces[0,0,1].renderer.material=dynamic_materials[0,1,2];
			temp_mat[0,0,1]=dynamic_materials[0,1,2];
			actualfaces[0,0,2].renderer.material=dynamic_materials[0,2,2];
			perfaces[0,0,2].renderer.material=dynamic_materials[0,2,2];
			temp_mat[0,0,2]=dynamic_materials[0,2,2];
			
			actualfaces[0,1,0].renderer.material=dynamic_materials[0,0,1];
			perfaces[0,1,0].renderer.material=dynamic_materials[0,0,1];
			temp_mat[0,1,0]=dynamic_materials[0,0,1];
			actualfaces[0,1,2].renderer.material=dynamic_materials[0,2,1];
			perfaces[0,1,2].renderer.material=dynamic_materials[0,2,1];
			temp_mat[0,1,2]=dynamic_materials[0,2,1];
			
			actualfaces[0,2,0].renderer.material=dynamic_materials[0,0,0];
			perfaces[0,2,0].renderer.material=dynamic_materials[0,0,0];
			temp_mat[0,2,0]=dynamic_materials[0,0,0];
			actualfaces[0,2,1].renderer.material=dynamic_materials[0,1,0];
			perfaces[0,2,1].renderer.material=dynamic_materials[0,1,0];
			temp_mat[0,2,1]=dynamic_materials[0,1,0];
			actualfaces[0,2,2].renderer.material=dynamic_materials[0,2,0];
			perfaces[0,2,2].renderer.material=dynamic_materials[0,2,0];
			temp_mat[0,2,2]=dynamic_materials[0,2,0];
			
			dynamic_materials[0,0,0]=temp_mat[0,0,0];
			dynamic_materials[0,0,1]=temp_mat[0,0,1];
			dynamic_materials[0,0,2]=temp_mat[0,0,2];
			
			dynamic_materials[0,1,0]=temp_mat[0,1,0];
			dynamic_materials[0,1,2]=temp_mat[0,1,2];
			
			dynamic_materials[0,2,0]=temp_mat[0,2,0];
			dynamic_materials[0,2,1]=temp_mat[0,2,1];
			dynamic_materials[0,2,2]=temp_mat[0,2,2];
		}
		else if (action_code=="t^"){
			for (int i=0;i<3;i++){
				Material[,,] temp_mat = new Material[6,3,3];
				
				actualfaces[1,0,0].renderer.material=dynamic_materials[4,0,0];
				perfaces[1,0,0].renderer.material=dynamic_materials[4,0,0];
				temp_mat[1,0,0]=dynamic_materials[4,0,0];
				actualfaces[1,0,1].renderer.material=dynamic_materials[4,0,1];
				perfaces[1,0,1].renderer.material=dynamic_materials[4,0,1];
				temp_mat[1,0,1]=dynamic_materials[4,0,1];
				actualfaces[1,0,2].renderer.material=dynamic_materials[4,0,2];
				perfaces[1,0,2].renderer.material=dynamic_materials[4,0,2];
				temp_mat[1,0,2]=dynamic_materials[4,0,2];
				
				actualfaces[5,0,0].renderer.material=dynamic_materials[1,0,0];
				perfaces[5,0,0].renderer.material=dynamic_materials[1,0,0];
				temp_mat[5,0,0]=dynamic_materials[1,0,0];
				actualfaces[5,0,1].renderer.material=dynamic_materials[1,0,1];
				perfaces[5,0,1].renderer.material=dynamic_materials[1,0,1];
				temp_mat[5,0,1]=dynamic_materials[1,0,1];
				actualfaces[5,0,2].renderer.material=dynamic_materials[1,0,2];
				perfaces[5,0,2].renderer.material=dynamic_materials[1,0,2];
				temp_mat[5,0,2]=dynamic_materials[1,0,2];
				
				actualfaces[3,2,2].renderer.material=dynamic_materials[5,0,0];
				perfaces[3,2,2].renderer.material=dynamic_materials[5,0,0];
				temp_mat[3,2,2]=dynamic_materials[5,0,0];
				actualfaces[3,2,1].renderer.material=dynamic_materials[5,0,1];
				perfaces[3,2,1].renderer.material=dynamic_materials[5,0,1];
				temp_mat[3,2,1]=dynamic_materials[5,0,1];
				actualfaces[3,2,0].renderer.material=dynamic_materials[5,0,2];
				perfaces[3,2,0].renderer.material=dynamic_materials[5,0,2];
				temp_mat[3,2,0]=dynamic_materials[5,0,2];
				
				actualfaces[4,0,0].renderer.material=dynamic_materials[3,2,2];
				perfaces[4,0,0].renderer.material=dynamic_materials[3,2,2];
				temp_mat[4,0,0]=dynamic_materials[3,2,2];
				actualfaces[4,0,1].renderer.material=dynamic_materials[3,2,1];
				perfaces[4,0,1].renderer.material=dynamic_materials[3,2,1];
				temp_mat[4,0,1]=dynamic_materials[3,2,1];
				actualfaces[4,0,2].renderer.material=dynamic_materials[3,2,0];
				perfaces[4,0,2].renderer.material=dynamic_materials[3,2,0];
				temp_mat[4,0,2]=dynamic_materials[3,2,0];
				
				dynamic_materials[1,0,0]=temp_mat[1,0,0];
				dynamic_materials[1,0,1]=temp_mat[1,0,1];
				dynamic_materials[1,0,2]=temp_mat[1,0,2];
				
				dynamic_materials[5,0,0]=temp_mat[5,0,0];
				dynamic_materials[5,0,1]=temp_mat[5,0,1];
				dynamic_materials[5,0,2]=temp_mat[5,0,2];
				
				dynamic_materials[3,2,2]=temp_mat[3,2,2];
				dynamic_materials[3,2,1]=temp_mat[3,2,1];
				dynamic_materials[3,2,0]=temp_mat[3,2,0];
				
				dynamic_materials[4,0,0]=temp_mat[4,0,0];
				dynamic_materials[4,0,1]=temp_mat[4,0,1];
				dynamic_materials[4,0,2]=temp_mat[4,0,2];
				
				actualfaces[0,0,0].renderer.material=dynamic_materials[0,0,2];
				perfaces[0,0,0].renderer.material=dynamic_materials[0,0,2];
				temp_mat[0,0,0]=dynamic_materials[0,0,2];
				actualfaces[0,0,1].renderer.material=dynamic_materials[0,1,2];
				perfaces[0,0,1].renderer.material=dynamic_materials[0,1,2];
				temp_mat[0,0,1]=dynamic_materials[0,1,2];
				actualfaces[0,0,2].renderer.material=dynamic_materials[0,2,2];
				perfaces[0,0,2].renderer.material=dynamic_materials[0,2,2];
				temp_mat[0,0,2]=dynamic_materials[0,2,2];
				
				actualfaces[0,1,0].renderer.material=dynamic_materials[0,0,1];
				perfaces[0,1,0].renderer.material=dynamic_materials[0,0,1];
				temp_mat[0,1,0]=dynamic_materials[0,0,1];
				actualfaces[0,1,2].renderer.material=dynamic_materials[0,2,1];
				perfaces[0,1,2].renderer.material=dynamic_materials[0,2,1];
				temp_mat[0,1,2]=dynamic_materials[0,2,1];
				
				actualfaces[0,2,0].renderer.material=dynamic_materials[0,0,0];
				perfaces[0,2,0].renderer.material=dynamic_materials[0,0,0];
				temp_mat[0,2,0]=dynamic_materials[0,0,0];
				actualfaces[0,2,1].renderer.material=dynamic_materials[0,1,0];
				perfaces[0,2,1].renderer.material=dynamic_materials[0,1,0];
				temp_mat[0,2,1]=dynamic_materials[0,1,0];
				actualfaces[0,2,2].renderer.material=dynamic_materials[0,2,0];
				perfaces[0,2,2].renderer.material=dynamic_materials[0,2,0];
				temp_mat[0,2,2]=dynamic_materials[0,2,0];
				
				dynamic_materials[0,0,0]=temp_mat[0,0,0];
				dynamic_materials[0,0,1]=temp_mat[0,0,1];
				dynamic_materials[0,0,2]=temp_mat[0,0,2];
				
				dynamic_materials[0,1,0]=temp_mat[0,1,0];
				dynamic_materials[0,1,2]=temp_mat[0,1,2];
				
				dynamic_materials[0,2,0]=temp_mat[0,2,0];
				dynamic_materials[0,2,1]=temp_mat[0,2,1];
				dynamic_materials[0,2,2]=temp_mat[0,2,2];
			}
		}
		else if (action_code=="d"){
			
			Material[,,] temp_mat = new Material[6,3,3];
			
			actualfaces[1,2,0].renderer.material=dynamic_materials[4,2,0];
			perfaces[1,2,0].renderer.material=dynamic_materials[4,2,0];
			temp_mat[1,2,0]=dynamic_materials[4,2,0];
			actualfaces[1,2,1].renderer.material=dynamic_materials[4,2,1];
			perfaces[1,2,1].renderer.material=dynamic_materials[4,2,1];
			temp_mat[1,2,1]=dynamic_materials[4,2,1];
			actualfaces[1,2,2].renderer.material=dynamic_materials[4,2,2];
			perfaces[1,2,2].renderer.material=dynamic_materials[4,2,2];
			temp_mat[1,2,2]=dynamic_materials[4,2,2];
			
			actualfaces[5,2,0].renderer.material=dynamic_materials[1,2,0];
			perfaces[5,2,0].renderer.material=dynamic_materials[1,2,0];
			temp_mat[5,2,0]=dynamic_materials[1,2,0];
			actualfaces[5,2,1].renderer.material=dynamic_materials[1,2,1];
			perfaces[5,2,1].renderer.material=dynamic_materials[1,2,1];
			temp_mat[5,2,1]=dynamic_materials[1,2,1];
			actualfaces[5,2,2].renderer.material=dynamic_materials[1,2,2];
			perfaces[5,2,2].renderer.material=dynamic_materials[1,2,2];
			temp_mat[5,2,2]=dynamic_materials[1,2,2];
			
			actualfaces[3,0,2].renderer.material=dynamic_materials[5,2,0];
			perfaces[3,0,2].renderer.material=dynamic_materials[5,2,0];
			temp_mat[3,0,2]=dynamic_materials[5,2,0];
			actualfaces[3,0,1].renderer.material=dynamic_materials[5,2,1];
			perfaces[3,0,1].renderer.material=dynamic_materials[5,2,1];
			temp_mat[3,0,1]=dynamic_materials[5,2,1];
			actualfaces[3,0,0].renderer.material=dynamic_materials[5,2,2];
			perfaces[3,0,0].renderer.material=dynamic_materials[5,2,2];
			temp_mat[3,0,0]=dynamic_materials[5,2,2];
			
			actualfaces[4,2,0].renderer.material=dynamic_materials[3,0,2];
			perfaces[4,2,0].renderer.material=dynamic_materials[3,0,2];
			temp_mat[4,2,0]=dynamic_materials[3,0,2];
			actualfaces[4,2,1].renderer.material=dynamic_materials[3,0,1];
			perfaces[4,2,1].renderer.material=dynamic_materials[3,0,1];
			temp_mat[4,2,1]=dynamic_materials[3,0,1];
			actualfaces[4,2,2].renderer.material=dynamic_materials[3,0,0];
			perfaces[4,2,2].renderer.material=dynamic_materials[3,0,0];
			temp_mat[4,2,2]=dynamic_materials[3,0,0];
			
			dynamic_materials[1,2,0]=temp_mat[1,2,0];
			dynamic_materials[1,2,1]=temp_mat[1,2,1];
			dynamic_materials[1,2,2]=temp_mat[1,2,2];
			
			dynamic_materials[5,2,0]=temp_mat[5,2,0];
			dynamic_materials[5,2,1]=temp_mat[5,2,1];
			dynamic_materials[5,2,2]=temp_mat[5,2,2];
			
			dynamic_materials[3,0,2]=temp_mat[3,0,2];
			dynamic_materials[3,0,1]=temp_mat[3,0,1];
			dynamic_materials[3,0,0]=temp_mat[3,0,0];
			
			dynamic_materials[4,2,0]=temp_mat[4,2,0];
			dynamic_materials[4,2,1]=temp_mat[4,2,1];
			dynamic_materials[4,2,2]=temp_mat[4,2,2];
			
			actualfaces[2,0,0].renderer.material=dynamic_materials[2,2,0];
			perfaces[2,0,0].renderer.material=dynamic_materials[2,2,0];
			temp_mat[2,0,0]=dynamic_materials[2,2,0];
			actualfaces[2,0,1].renderer.material=dynamic_materials[2,1,0];
			perfaces[2,0,1].renderer.material=dynamic_materials[2,1,0];
			temp_mat[2,0,1]=dynamic_materials[2,1,0];
			actualfaces[2,0,2].renderer.material=dynamic_materials[2,0,0];
			perfaces[2,0,2].renderer.material=dynamic_materials[2,0,0];
			temp_mat[2,0,2]=dynamic_materials[2,0,0];
			
			actualfaces[2,1,0].renderer.material=dynamic_materials[2,2,1];
			perfaces[2,1,0].renderer.material=dynamic_materials[2,2,1];
			temp_mat[2,1,0]=dynamic_materials[2,2,1];
			actualfaces[2,1,2].renderer.material=dynamic_materials[2,0,1];
			perfaces[2,1,2].renderer.material=dynamic_materials[2,0,1];
			temp_mat[2,1,2]=dynamic_materials[2,0,1];
			
			actualfaces[2,2,0].renderer.material=dynamic_materials[2,2,2];
			perfaces[2,2,0].renderer.material=dynamic_materials[2,2,2];
			temp_mat[2,2,0]=dynamic_materials[2,2,2];
			actualfaces[2,2,1].renderer.material=dynamic_materials[2,1,2];
			perfaces[2,2,1].renderer.material=dynamic_materials[2,1,2];
			temp_mat[2,2,1]=dynamic_materials[2,1,2];
			actualfaces[2,2,2].renderer.material=dynamic_materials[2,0,2];
			perfaces[2,2,2].renderer.material=dynamic_materials[2,0,2];
			temp_mat[2,2,2]=dynamic_materials[2,0,2];
			
			dynamic_materials[2,0,0]=temp_mat[2,0,0];
			dynamic_materials[2,0,1]=temp_mat[2,0,1];
			dynamic_materials[2,0,2]=temp_mat[2,0,2];
			
			dynamic_materials[2,1,0]=temp_mat[2,1,0];
			dynamic_materials[2,1,2]=temp_mat[2,1,2];
			
			dynamic_materials[2,2,0]=temp_mat[2,2,0];
			dynamic_materials[2,2,1]=temp_mat[2,2,1];
			dynamic_materials[2,2,2]=temp_mat[2,2,2];
		}
		else if (action_code=="d^"){
			for (int i=0;i<3;i++){
				
				Material[,,] temp_mat = new Material[6,3,3];
				
				actualfaces[1,2,0].renderer.material=dynamic_materials[4,2,0];
				perfaces[1,2,0].renderer.material=dynamic_materials[4,2,0];
				temp_mat[1,2,0]=dynamic_materials[4,2,0];
				actualfaces[1,2,1].renderer.material=dynamic_materials[4,2,1];
				perfaces[1,2,1].renderer.material=dynamic_materials[4,2,1];
				temp_mat[1,2,1]=dynamic_materials[4,2,1];
				actualfaces[1,2,2].renderer.material=dynamic_materials[4,2,2];
				perfaces[1,2,2].renderer.material=dynamic_materials[4,2,2];
				temp_mat[1,2,2]=dynamic_materials[4,2,2];
				
				actualfaces[5,2,0].renderer.material=dynamic_materials[1,2,0];
				perfaces[5,2,0].renderer.material=dynamic_materials[1,2,0];
				temp_mat[5,2,0]=dynamic_materials[1,2,0];
				actualfaces[5,2,1].renderer.material=dynamic_materials[1,2,1];
				perfaces[5,2,1].renderer.material=dynamic_materials[1,2,1];
				temp_mat[5,2,1]=dynamic_materials[1,2,1];
				actualfaces[5,2,2].renderer.material=dynamic_materials[1,2,2];
				perfaces[5,2,2].renderer.material=dynamic_materials[1,2,2];
				temp_mat[5,2,2]=dynamic_materials[1,2,2];
				
				actualfaces[3,0,2].renderer.material=dynamic_materials[5,2,0];
				perfaces[3,0,2].renderer.material=dynamic_materials[5,2,0];
				temp_mat[3,0,2]=dynamic_materials[5,2,0];
				actualfaces[3,0,1].renderer.material=dynamic_materials[5,2,1];
				perfaces[3,0,1].renderer.material=dynamic_materials[5,2,1];
				temp_mat[3,0,1]=dynamic_materials[5,2,1];
				actualfaces[3,0,0].renderer.material=dynamic_materials[5,2,2];
				perfaces[3,0,0].renderer.material=dynamic_materials[5,2,2];
				temp_mat[3,0,0]=dynamic_materials[5,2,2];
				
				actualfaces[4,2,0].renderer.material=dynamic_materials[3,0,2];
				perfaces[4,2,0].renderer.material=dynamic_materials[3,0,2];
				temp_mat[4,2,0]=dynamic_materials[3,0,2];
				actualfaces[4,2,1].renderer.material=dynamic_materials[3,0,1];
				perfaces[4,2,1].renderer.material=dynamic_materials[3,0,1];
				temp_mat[4,2,1]=dynamic_materials[3,0,1];
				actualfaces[4,2,2].renderer.material=dynamic_materials[3,0,0];
				perfaces[4,2,2].renderer.material=dynamic_materials[3,0,0];
				temp_mat[4,2,2]=dynamic_materials[3,0,0];
				
				dynamic_materials[1,2,0]=temp_mat[1,2,0];
				dynamic_materials[1,2,1]=temp_mat[1,2,1];
				dynamic_materials[1,2,2]=temp_mat[1,2,2];
				
				dynamic_materials[5,2,0]=temp_mat[5,2,0];
				dynamic_materials[5,2,1]=temp_mat[5,2,1];
				dynamic_materials[5,2,2]=temp_mat[5,2,2];
				
				dynamic_materials[3,0,2]=temp_mat[3,0,2];
				dynamic_materials[3,0,1]=temp_mat[3,0,1];
				dynamic_materials[3,0,0]=temp_mat[3,0,0];
				
				dynamic_materials[4,2,0]=temp_mat[4,2,0];
				dynamic_materials[4,2,1]=temp_mat[4,2,1];
				dynamic_materials[4,2,2]=temp_mat[4,2,2];
				
				actualfaces[2,0,0].renderer.material=dynamic_materials[2,2,0];
				perfaces[2,0,0].renderer.material=dynamic_materials[2,2,0];
				temp_mat[2,0,0]=dynamic_materials[2,2,0];
				actualfaces[2,0,1].renderer.material=dynamic_materials[2,1,0];
				perfaces[2,0,1].renderer.material=dynamic_materials[2,1,0];
				temp_mat[2,0,1]=dynamic_materials[2,1,0];
				actualfaces[2,0,2].renderer.material=dynamic_materials[2,0,0];
				perfaces[2,0,2].renderer.material=dynamic_materials[2,0,0];
				temp_mat[2,0,2]=dynamic_materials[2,0,0];
				
				actualfaces[2,1,0].renderer.material=dynamic_materials[2,2,1];
				perfaces[2,1,0].renderer.material=dynamic_materials[2,2,1];
				temp_mat[2,1,0]=dynamic_materials[2,2,1];
				actualfaces[2,1,2].renderer.material=dynamic_materials[2,0,1];
				perfaces[2,1,2].renderer.material=dynamic_materials[2,0,1];
				temp_mat[2,1,2]=dynamic_materials[2,0,1];
				
				actualfaces[2,2,0].renderer.material=dynamic_materials[2,2,2];
				perfaces[2,2,0].renderer.material=dynamic_materials[2,2,2];
				temp_mat[2,2,0]=dynamic_materials[2,2,2];
				actualfaces[2,2,1].renderer.material=dynamic_materials[2,1,2];
				perfaces[2,2,1].renderer.material=dynamic_materials[2,1,2];
				temp_mat[2,2,1]=dynamic_materials[2,1,2];
				actualfaces[2,2,2].renderer.material=dynamic_materials[2,0,2];
				perfaces[2,2,2].renderer.material=dynamic_materials[2,0,2];
				temp_mat[2,2,2]=dynamic_materials[2,0,2];
				
				dynamic_materials[2,0,0]=temp_mat[2,0,0];
				dynamic_materials[2,0,1]=temp_mat[2,0,1];
				dynamic_materials[2,0,2]=temp_mat[2,0,2];
				
				dynamic_materials[2,1,0]=temp_mat[2,1,0];
				dynamic_materials[2,1,2]=temp_mat[2,1,2];
				
				dynamic_materials[2,2,0]=temp_mat[2,2,0];
				dynamic_materials[2,2,1]=temp_mat[2,2,1];
				dynamic_materials[2,2,2]=temp_mat[2,2,2];
			}
		}
	}
	void Shuffle (){

		for (int a=0;a<5;a++){

			int roll = Random.Range(1,6);
			
			if (roll==1){
				action("f");
				Debug.Log("f");
			}
			else if (roll==2){
				action("b");
				Debug.Log("b");
			}
			else if (roll==3){
				action("r");
				Debug.Log("r");
			}
			else if (roll==4){
				action("l");
				Debug.Log("l");
			}
			else if (roll==5){
				action("t");
				Debug.Log("t");
			}
			else if (roll==6){
				action("d");
				Debug.Log("d");
			}	
		}
	}
}
