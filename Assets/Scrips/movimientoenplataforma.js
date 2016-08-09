#pragma strict

function Start () {

}

function Update () {

}

function OnCollisionEnter(coll : Collider){
	if(coll.tag == "moviente"){
	this.transform.parent = coll.gameObject.transform;
	}
}

function OnCollisionExit(coll : Collider){
	if(coll.tag == "moviente"){
	this.transform.parent = null;
	}
}