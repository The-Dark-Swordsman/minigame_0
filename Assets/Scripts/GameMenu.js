var isQuit=false;

function OnMouseEnter()
	{
		renderer.material.color=Color.gray;
	}

function OnMouseExit()
	{
		renderer.material.color=Color.black;
	}

function OnMouseUp()
	{
		if (isQuit==true)
		{
			Application.Quit();
		}
		else 
		{
			Application.LoadLevel(1);
		}
	}

function Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}