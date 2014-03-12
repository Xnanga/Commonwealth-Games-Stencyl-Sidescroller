    var boxbg : Texture2D;
    var SceneOne : String;
    var SceneOneName : String = "Tutorial";
    var SceneTwo : String;
    var SceneTwoName : String = "Level One";
    var SceneThree : String;
    var SceneThreeName : String = "Level Two";
     
     
    function OnGUI()
    {
            GUI.BeginGroup (Rect (Screen.width/2-70, Screen.height/2-60, Screen.width, Screen.height));
            GUI.Box (Rect (0,0,145,170), boxbg);
            if (GUI.Button(Rect(10,10,125,30),SceneOneName))
            {
                    Application.LoadLevel(SceneOne);
            }
            if (GUI.Button(Rect(10,50,125,30),SceneTwoName))
            {
                    Application.LoadLevel(SceneTwo);
            }
            if (GUI.Button(Rect(10,90,125,30),SceneThreeName))
            {
                    Application.LoadLevel(SceneThree);     
            }
            if (GUI.Button(Rect(10,130,125,30),"Quit"))
            {
                    Application.Quit();
            }
            GUI.EndGroup();
    }

