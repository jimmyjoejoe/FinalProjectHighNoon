﻿#pragma strict

function OnCollisionEnter (collision : Collision)
{
if(collision.gameObject.tag == "Enemy")
    {
    Application.LoadLevel(5); 
    }
}