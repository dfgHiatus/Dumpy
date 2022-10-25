using System.Runtime.InteropServices;
using UnityEngine;

public class FBData
{
    private OVREyeGaze ovrLeftEye;
    private OVREyeGaze ovrRightEye;
    private OVRFaceExpressions ovrFace;

    public AllData allData;

    public FBData(OVREyeGaze leftEye, OVREyeGaze rightEye, OVRFaceExpressions face)
    {
        ovrLeftEye = leftEye;
        ovrRightEye = rightEye;
        ovrFace = face;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AllData
    {
        public EyeData eyeData;
        public FaceData faceData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EyeData
    {
        public Eye leftEye;
        public Eye rightEye;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Eye
    {
        public float confidence;
        public Vec3 position;
        public Quat rotation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Vec3
    {
        public float x;
        public float y;
        public float z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Quat
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FaceData
    {
        public float FaceRegionConfidenceLower;
        public float FaceRegionConfidenceUpper;
        public float Brow_Lowerer_L;
        public float Brow_Lowerer_R;
        public float Cheek_Puff_L;
        public float Cheek_Puff_R;
        public float Cheek_Raiser_L;
        public float Cheek_Raiser_R;
        public float Cheek_Suck_L;
        public float Cheek_Suck_R;
        public float Chin_Raiser_B;
        public float Chin_Raiser_T;
        public float Dimpler_L;
        public float Dimpler_R;
        public float Eyes_Closed_L;
        public float Eyes_Closed_R;
        public float Eyes_Look_Down_L;
        public float Eyes_Look_Down_R;
        public float Eyes_Look_Left_L;
        public float Eyes_Look_Left_R;
        public float Eyes_Look_Right_L;
        public float Eyes_Look_Right_R;
        public float Eyes_Look_Up_L;
        public float Eyes_Look_Up_R;
        public float Inner_Brow_Raiser_L;
        public float Inner_Brow_Raiser_R;
        public float Jaw_Drop;
        public float Jaw_Sideways_Left;
        public float Jaw_Sideways_Right;
        public float Jaw_Thrust;
        public float Lid_Tightener_L;
        public float Lid_Tightener_R;
        public float Lip_Corner_Depressor_L;
        public float Lip_Corner_Depressor_R;
        public float Lip_Corner_Puller_L;
        public float Lip_Corner_Puller_R;
        public float Lip_Funneler_LB;
        public float Lip_Funneler_LT;
        public float Lip_Funneler_RB;
        public float Lip_Funneler_RT;
        public float Lip_Pressor_L;
        public float Lip_Pressor_R;
        public float Lip_Pucker_L;
        public float Lip_Pucker_R;
        public float Lip_Stretcher_L;
        public float Lip_Stretcher_R;
        public float Lip_Suck_LB;
        public float Lip_Suck_LT;
        public float Lip_Suck_RB;
        public float Lip_Suck_RT;
        public float Lip_Tightener_L;
        public float Lip_Tightener_R;
        public float Lips_Toward;
        public float Lower_Lip_Depressor_L;
        public float Lower_Lip_Depressor_R;
        public float Mouth_Left;
        public float Mouth_Right;
        public float Nose_Wrinkler_L;
        public float Nose_Wrinkler_R;
        public float Outer_Brow_Raiser_L;
        public float Outer_Brow_Raiser_R;
        public float Upper_Lid_Raiser_L;
        public float Upper_Lid_Raiser_R;
        public float Upper_Lip_Raiser_L;
        public float Upper_Lip_Raiser_R;
    }

    // Auto-generated
    public void Update()
    {
        #region Left Eye
        allData.eyeData.leftEye.confidence = ovrLeftEye.Confidence;
        allData.eyeData.leftEye.rotation.x = ovrLeftEye.gameObject.transform.localRotation.x;
        allData.eyeData.leftEye.rotation.x = ovrLeftEye.gameObject.transform.localRotation.y;
        allData.eyeData.leftEye.rotation.x = ovrLeftEye.gameObject.transform.localRotation.z;
        allData.eyeData.leftEye.rotation.x = ovrLeftEye.gameObject.transform.localRotation.w;
        #endregion Left Eye

        #region Right Eye
        allData.eyeData.rightEye.confidence = ovrRightEye.Confidence;
        allData.eyeData.rightEye.rotation.x = ovrRightEye.gameObject.transform.localRotation.x;
        allData.eyeData.rightEye.rotation.x = ovrRightEye.gameObject.transform.localRotation.y;
        allData.eyeData.rightEye.rotation.x = ovrRightEye.gameObject.transform.localRotation.z;
        allData.eyeData.rightEye.rotation.x = ovrRightEye.gameObject.transform.localRotation.w;
        #endregion Right Eye

        float val;

        #region Face
        allData.faceData.FaceRegionConfidenceLower = ovrFace.TryGetWeightConfidence(OVRFaceExpressions.FaceRegionConfidence.Lower, out val) ? val : 0;
        allData.faceData.FaceRegionConfidenceUpper = ovrFace.TryGetWeightConfidence(OVRFaceExpressions.FaceRegionConfidence.Upper, out val) ? val : 0;
        
        allData.faceData.Brow_Lowerer_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Brow_Lowerer_L, out val) ? val : 0;
        allData.faceData.Brow_Lowerer_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Brow_Lowerer_R, out val) ? val : 0;
        allData.faceData.Cheek_Puff_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Cheek_Puff_L, out val) ? val : 0;
        allData.faceData.Cheek_Puff_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Cheek_Puff_R, out val) ? val : 0;
        allData.faceData.Cheek_Raiser_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Cheek_Raiser_L, out val) ? val : 0;
        allData.faceData.Cheek_Raiser_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Cheek_Raiser_R, out val) ? val : 0;
        allData.faceData.Cheek_Suck_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Cheek_Suck_L, out val) ? val : 0;
        allData.faceData.Cheek_Suck_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Cheek_Suck_R, out val) ? val : 0;
        allData.faceData.Chin_Raiser_B = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Chin_Raiser_B, out val) ? val : 0;
        allData.faceData.Chin_Raiser_T = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Chin_Raiser_T, out val) ? val : 0;
        allData.faceData.Dimpler_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Dimpler_L, out val) ? val : 0;
        allData.faceData.Dimpler_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Dimpler_R, out val) ? val : 0;
        allData.faceData.Eyes_Closed_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Closed_L, out val) ? val : 0;
        allData.faceData.Eyes_Closed_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Closed_R, out val) ? val : 0;
        allData.faceData.Eyes_Look_Down_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Down_L, out val) ? val : 0;
        allData.faceData.Eyes_Look_Down_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Down_R, out val) ? val : 0;
        allData.faceData.Eyes_Look_Left_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Left_L, out val) ? val : 0;
        allData.faceData.Eyes_Look_Left_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Left_R, out val) ? val : 0;
        allData.faceData.Eyes_Look_Right_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Right_L, out val) ? val : 0;
        allData.faceData.Eyes_Look_Right_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Right_R, out val) ? val : 0;
        allData.faceData.Eyes_Look_Up_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Up_L, out val) ? val : 0;
        allData.faceData.Eyes_Look_Up_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Eyes_Look_Up_R, out val) ? val : 0;
        allData.faceData.Inner_Brow_Raiser_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Inner_Brow_Raiser_L, out val) ? val : 0;
        allData.faceData.Inner_Brow_Raiser_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Inner_Brow_Raiser_R, out val) ? val : 0;
        allData.faceData.Jaw_Drop = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Jaw_Drop, out val) ? val : 0;
        allData.faceData.Jaw_Sideways_Left = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Jaw_Sideways_Left, out val) ? val : 0;
        allData.faceData.Jaw_Sideways_Right = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Jaw_Sideways_Right, out val) ? val : 0;
        allData.faceData.Jaw_Thrust = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Jaw_Thrust, out val) ? val : 0;
        allData.faceData.Lid_Tightener_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lid_Tightener_L, out val) ? val : 0;
        allData.faceData.Lid_Tightener_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lid_Tightener_R, out val) ? val : 0;
        allData.faceData.Lip_Corner_Depressor_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Corner_Depressor_L, out val) ? val : 0;
        allData.faceData.Lip_Corner_Depressor_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Corner_Depressor_R, out val) ? val : 0;
        allData.faceData.Lip_Corner_Puller_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Corner_Puller_L, out val) ? val : 0;
        allData.faceData.Lip_Corner_Puller_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Corner_Puller_R, out val) ? val : 0;
        allData.faceData.Lip_Funneler_LB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Funneler_LB, out val) ? val : 0;
        allData.faceData.Lip_Funneler_LT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Funneler_LT, out val) ? val : 0;
        allData.faceData.Lip_Funneler_RB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Funneler_RB, out val) ? val : 0;
        allData.faceData.Lip_Funneler_RT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Funneler_RT, out val) ? val : 0;
        allData.faceData.Lip_Pressor_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Pressor_L, out val) ? val : 0;
        allData.faceData.Lip_Pressor_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Pressor_R, out val) ? val : 0;
        allData.faceData.Lip_Pucker_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Pucker_L, out val) ? val : 0;
        allData.faceData.Lip_Pucker_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Pucker_R, out val) ? val : 0;
        allData.faceData.Lip_Stretcher_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Stretcher_L, out val) ? val : 0;
        allData.faceData.Lip_Stretcher_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Stretcher_R, out val) ? val : 0;
        allData.faceData.Lip_Suck_LB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Suck_LB, out val) ? val : 0;
        allData.faceData.Lip_Suck_LT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Suck_LT, out val) ? val : 0;
        allData.faceData.Lip_Suck_RB = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Suck_RB, out val) ? val : 0;
        allData.faceData.Lip_Suck_RT = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Suck_RT, out val) ? val : 0;
        allData.faceData.Lip_Tightener_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Tightener_L, out val) ? val : 0;
        allData.faceData.Lip_Tightener_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lip_Tightener_R, out val) ? val : 0;
        allData.faceData.Lips_Toward = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lips_Toward, out val) ? val : 0;
        allData.faceData.Lower_Lip_Depressor_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lower_Lip_Depressor_L, out val) ? val : 0;
        allData.faceData.Lower_Lip_Depressor_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Lower_Lip_Depressor_R, out val) ? val : 0;
        allData.faceData.Mouth_Left = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Mouth_Left, out val) ? val : 0;
        allData.faceData.Mouth_Right = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Mouth_Right, out val) ? val : 0;
        allData.faceData.Nose_Wrinkler_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Nose_Wrinkler_L, out val) ? val : 0;
        allData.faceData.Nose_Wrinkler_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Nose_Wrinkler_R, out val) ? val : 0;
        allData.faceData.Outer_Brow_Raiser_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Outer_Brow_Raiser_L, out val) ? val : 0;
        allData.faceData.Outer_Brow_Raiser_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Outer_Brow_Raiser_R, out val) ? val : 0;
        allData.faceData.Upper_Lid_Raiser_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Upper_Lid_Raiser_L, out val) ? val : 0;
        allData.faceData.Upper_Lid_Raiser_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Upper_Lid_Raiser_R, out val) ? val : 0;
        allData.faceData.Upper_Lip_Raiser_L = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Upper_Lip_Raiser_L, out val) ? val : 0;
        allData.faceData.Upper_Lip_Raiser_R = ovrFace.TryGetFaceExpressionWeight(OVRFaceExpressions.FaceExpression.Upper_Lip_Raiser_R, out val) ? val : 0;


        #endregion Face

    }
}
