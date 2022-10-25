using System.Runtime.InteropServices;
using UnityEngine;
using static FBData;

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

        public override string ToString()
        {
            return "EyeData: " + eyeData.ToString() + " FaceData: " + faceData.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EyeData
    {
        public Eye leftEye;
        public Eye rightEye;

        public override string ToString()
        {
            return "LeftEye: " + leftEye.ToString() + " RightData: " + rightEye.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Eye
    {
        public float confidence;
        public Vec3 position;
        public Quat rotation;

        public override string ToString()
        {
            return "Confidence: " + confidence + ", Position: " + position.ToString() + ", Rotation: " + rotation.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Vec3
    {
        public float x;
        public float y;
        public float z;

        public override string ToString()
        {
            return $"Vector3: X: {x}, Y: {y}, Z: {z})";
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Quat
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public override string ToString()
        {
            return $"Quaternion: X: {x}, Y: {y}, Z: {z}, W: {w})";
        }
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

        public override string ToString()
        {
            return 
                 "FaceData: " + 
                 "\nFaceRegionConfidenceLower: " + FaceRegionConfidenceLower + 
                 "\nFaceRegionConfidenceUpper: " + FaceRegionConfidenceUpper + 
                 "\nBrow_Lowerer_L: " + Brow_Lowerer_L + 
                 "\nBrow_Lowerer_R: " + Brow_Lowerer_R + 
                 "\nCheek_Puff_L: " + Cheek_Puff_L + 
                 "\nCheek_Puff_R: " + Cheek_Puff_R + 
                 "\nCheek_Raiser_L: " + Cheek_Raiser_L + 
                 "\nCheek_Raiser_R: " + Cheek_Raiser_R + 
                 "\nCheek_Suck_L: " + Cheek_Suck_L + 
                 "\nCheek_Suck_R: " + Cheek_Suck_R + 
                 "\nChin_Raiser_B: " + Chin_Raiser_B + 
                 "\nChin_Raiser_T: " + Chin_Raiser_T + 
                 "\nDimpler_L: " + Dimpler_L + 
                 "\nDimpler_R: " + Dimpler_R + 
                 "\nEyes_Closed_L: " + Eyes_Closed_L + 
                 "\nEyes_Closed_R: " + Eyes_Closed_R + 
                 "\nEyes_Look_Down_L: " + Eyes_Look_Down_L + 
                 "\nEyes_Look_Down_R: " + Eyes_Look_Down_R + 
                 "\nEyes_Look_Left_L: " + Eyes_Look_Left_L + 
                 "\nEyes_Look_Left_R: " + Eyes_Look_Left_R + 
                 "\nEyes_Look_Right_L: " + Eyes_Look_Right_L + 
                 "\nEyes_Look_Right_R: " + Eyes_Look_Right_R + 
                 "\nEyes_Look_Up_L: " + Eyes_Look_Up_L + 
                 "\nEyes_Look_Up_R: " + Eyes_Look_Up_R + 
                 "\nInner_Brow_Raiser_L: " + Inner_Brow_Raiser_L + 
                 "\nInner_Brow_Raiser_R: " + Inner_Brow_Raiser_R + 
                 "\nJaw_Drop: " + Jaw_Drop + 
                 "\nJaw_Sideways_Left: " + Jaw_Sideways_Left + 
                 "\nJaw_Sideways_Right: " + Jaw_Sideways_Right + 
                 "\nJaw_Thrust: " + Jaw_Thrust + 
                 "\nLid_Tightener_L: " + Lid_Tightener_L + 
                 "\nLid_Tightener_R: " + Lid_Tightener_R + 
                 "\nLip_Corner_Depressor_L: " + Lip_Corner_Depressor_L + 
                 "\nLip_Corner_Depressor_R: " + Lip_Corner_Depressor_R +
                 "\nLip_Corner_Puller_L: " + Lip_Corner_Puller_L +
                 "\nLip_Corner_Puller_R: " + Lip_Corner_Puller_R +
                 "\nLip_Funneler_LB: " + Lip_Funneler_LB +
                 "\nLip_Funneler_LT: " + Lip_Funneler_LT +
                 "\nLip_Funneler_RB: " + Lip_Funneler_RB +
                 "\nLip_Funneler_RT: " + Lip_Funneler_RT +
                 "\nLip_Pressor_L: " + Lip_Pressor_L +
                 "\nLip_Pressor_R: " + Lip_Pressor_R +
                 "\nLip_Pucker_L: " + Lip_Pucker_L +
                 "\nLip_Pucker_R: " + Lip_Pucker_R +
                 "\nLip_Stretcher_L: " + Lip_Stretcher_L +
                 "\nLip_Stretcher_R: " + Lip_Stretcher_R +
                 "\nLip_Suck_LB: " + Lip_Suck_LB +
                 "\nLip_Suck_LT: " + Lip_Suck_LT +
                 "\nLip_Suck_RB: " + Lip_Suck_RB +
                 "\nLip_Suck_RT: " + Lip_Suck_RT +
                 "\nLip_Tightener_L: " + Lip_Tightener_L +
                 "\nLip_Tightener_R: " + Lip_Tightener_R +
                 "\nLips_Toward: " + Lips_Toward +
                 "\nLower_Lip_Depressor_L: " + Lower_Lip_Depressor_L +
                 "\nLower_Lip_Depressor_R: " + Lower_Lip_Depressor_R +
                 "\nMouth_Left: " + Mouth_Left +
                 "\nMouth_Right: " + Mouth_Right +
                 "\nNose_Wrinkler_L: " + Nose_Wrinkler_L +
                 "\nNose_Wrinkler_R: " + Nose_Wrinkler_R +
                 "\nOuter_Brow_Raiser_L: " + Outer_Brow_Raiser_L +
                 "\nOuter_Brow_Raiser_R: " + Outer_Brow_Raiser_R +
                 "\nUpper_Lid_Raiser_L: " + Upper_Lid_Raiser_L +
                 "\nUpper_Lid_Raiser_R: " + Upper_Lid_Raiser_R +
                 "\nUpper_Lip_Raiser_L: " + Upper_Lip_Raiser_L +
                 "\nUpper_Lip_Raiser_R: " + Upper_Lip_Raiser_R;
        }
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
