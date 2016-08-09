#pragma strict

function Start () {

}

function Update () {
	var hit : RaycastHit;
	if(Physics.Raycast(this.transform.position, Vector3(0,-1,0), hit, 1)){
	Debug.Log(hit.collider.gameObject);
	}
	
}