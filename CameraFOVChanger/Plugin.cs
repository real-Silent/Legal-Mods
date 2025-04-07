using BepInEx;
using TMPro;
using UnityEngine;

[BepInPlugin("com.silent.camera", "Camera FOV Changer", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    public float FOVDefault = 99.99999f;
    public string FOVNew = "99.99999"; 
    public Camera camMain;

    public void Start()
    {
        camMain = GameObject.Find("Main Camera").GetComponent<Camera>(); // Sets the camera
        if (camMain != null)
        {
            camMain.fieldOfView = FOVDefault; 
        }
    }

    public void OnGUI()
    {
        GUILayout.Label("Enter New FOV:");
        FOVNew = GUILayout.TextArea(FOVNew); 

        if (GUILayout.Button("Change FOV"))
        {
            if (float.TryParse(FOVNew, out float newFOV))  // help me >w<
            {
                FOVDefault = newFOV;
                if (camMain != null)
                {
                    camMain.fieldOfView = FOVDefault; 
                }
            }
        }
    }
}
