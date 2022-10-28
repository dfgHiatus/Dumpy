using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using UnityEngine;

public class Dumper : MonoBehaviour
{
    public OVREyeGaze leftEyeGaze;
    public OVREyeGaze rightEyeGaze;
    public OVRFaceExpressions faceExpressions;

    private MemoryMappedFile memMapFile;
    private MemoryMappedViewAccessor accessor;
    private FBData dataFB;
    private bool Spam = false;

    void Start()
    {
        Application.runInBackground = true;

        bool eyesInit = true;
        if (!leftEyeGaze.EyeTrackingEnabled)
        {
            Debug.LogWarning("Left eye tracking is not allowed! Please enable it in the Oculus app.");
            eyesInit = false;
        }
        if (!rightEyeGaze.EyeTrackingEnabled)
        {
            Debug.LogWarning("Right eye tracking is not allowed! Please enable it in the Oculus app.");
            eyesInit = false;
        }
        if (eyesInit)
        {
            Debug.Log("Eye tracking session has started!"); 
        }

        bool faceInit = true;
        if (!faceExpressions.FaceTrackingEnabled)
        {
            Debug.LogWarning("Face tracking is not allowed! Please enable it in the Oculus app.");
            faceInit = false;
        }
        else
        {
            Debug.Log("Face tracking session has started!");
        }
        
        if (eyesInit && faceInit)
        {
            dataFB = new FBData(leftEyeGaze, rightEyeGaze, faceExpressions);
            memMapFile = MemoryMappedFile.CreateNew("QuestProEyeTracking", Marshal.SizeOf(dataFB.allData));
            accessor = memMapFile.CreateViewAccessor();
            Debug.Log("Created memory mapped IO!");  
        }
    }

    void Update()
    {
        if (dataFB != null && memMapFile != null)
        {
            dataFB.Update();
            accessor.Write(0, ref dataFB.allData);
        }

        if (Input.GetKeyDown(KeyCode.F1))
            Spam = !Spam;

        if (Spam)
        {
            Debug.Log(dataFB.allData.ToString());
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F2))
                Debug.Log(dataFB.allData.eyeData.ToString());
        
            if (Input.GetKeyDown(KeyCode.F3))
                Debug.Log(dataFB.allData.faceData.ToString());
        }
    }

    void OnApplicationQuit()
    {
        Debug.Log("Destroying memory mapped IO...");
        
        if (accessor != null)
        {
            accessor.Dispose();
        }

        if (memMapFile != null)
        {
            memMapFile.Dispose();  
        }
        
        Debug.Log("Destroyed memory mapped IO!");
    }
}
