﻿using System.Runtime.InteropServices;

namespace ArucoUnity
{
  /// \addtogroup aruco_unity_package
  /// \{

  namespace Plugin
  {
    public static partial class Aruco
    {
      public class DetectorParameters : Utility.HandleCppPtr
      {
        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_DetectorParameters_create();

        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_delete(System.IntPtr parameters);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getAdaptiveThreshWinSizeMin(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setAdaptiveThreshWinSizeMin(System.IntPtr parameters, int adaptiveThreshWinSizeMin);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getAdaptiveThreshWinSizeMax(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setAdaptiveThreshWinSizeMax(System.IntPtr parameters, int adaptiveThreshWinSizeMax);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getAdaptiveThreshWinSizeStep(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setAdaptiveThreshWinSizeStep(System.IntPtr parameters, int adaptiveThreshWinSizeStep);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getAdaptiveThreshConstant(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setAdaptiveThreshConstant(System.IntPtr parameters, double adaptiveThreshConstant);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getMinMarkerPerimeterRate(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMinMarkerPerimeterRate(System.IntPtr parameters, double minMarkerPerimeterRate);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getMaxMarkerPerimeterRate(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMaxMarkerPerimeterRate(System.IntPtr parameters, double maxMarkerPerimeterRate);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getPolygonalApproxAccuracyRate(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setPolygonalApproxAccuracyRate(System.IntPtr parameters, double polygonalApproxAccuracyRate);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getMinCornerDistanceRate(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMinCornerDistanceRate(System.IntPtr parameters, double minCornerDistanceRate);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getMinDistanceToBorder(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMinDistanceToBorder(System.IntPtr parameters, int minDistanceToBorder);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getMinMarkerDistanceRate(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMinMarkerDistanceRate(System.IntPtr parameters, double minMarkerDistanceRate);

        [DllImport("ArucoUnity")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool au_DetectorParameters_getDoCornerRefinement(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setDoCornerRefinement(System.IntPtr parameters, [MarshalAs(UnmanagedType.Bool)] bool doCornerRefinement);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getCornerRefinementWinSize(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setCornerRefinementWinSize(System.IntPtr parameters, int cornerRefinementWinSize);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getCornerRefinementMaxIterations(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setCornerRefinementMaxIterations(System.IntPtr parameters, int cornerRefinementMaxIterations);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getCornerRefinementMinAccuracy(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setCornerRefinementMinAccuracy(System.IntPtr parameters, double cornerRefinementMinAccuracy);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getMarkerBorderBits(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMarkerBorderBits(System.IntPtr parameters, int markerBorderBits);

        [DllImport("ArucoUnity")]
        static extern int au_DetectorParameters_getPerspectiveRemovePixelPerCell(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setPerspectiveRemovePixelPerCell(System.IntPtr parameters, int perspectiveRemovePixelPerCell);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getPerspectiveRemoveIgnoredMarginPerCell(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setPerspectiveRemoveIgnoredMarginPerCell(System.IntPtr parameters, double perspectiveRemoveIgnoredMarginPerCell);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getMaxErroneousBitsInBorderRate(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMaxErroneousBitsInBorderRate(System.IntPtr parameters, double maxErroneousBitsInBorderRate);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getMinOtsuStdDev(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setMinOtsuStdDev(System.IntPtr parameters, double minOtsuStdDev);

        [DllImport("ArucoUnity")]
        static extern double au_DetectorParameters_getErrorCorrectionRate(System.IntPtr parameters);
        [DllImport("ArucoUnity")]
        static extern void au_DetectorParameters_setErrorCorrectionRate(System.IntPtr parameters, double errorCorrectionRate);

        public DetectorParameters() : base(au_DetectorParameters_create())
        {
        }

        protected override void DeleteCvPtr()
        {
          au_DetectorParameters_delete(cppPtr);
        }

        public int AdaptiveThreshWinSizeMin
        {
          get { return au_DetectorParameters_getAdaptiveThreshWinSizeMin(cppPtr); }
          set { au_DetectorParameters_setAdaptiveThreshWinSizeMin(cppPtr, value); }
        }

        public int AdaptiveThreshWinSizeMax
        {
          get { return au_DetectorParameters_getAdaptiveThreshWinSizeMax(cppPtr); }
          set { au_DetectorParameters_setAdaptiveThreshWinSizeMax(cppPtr, value); }
        }

        public int AdaptiveThreshWinSizeStep
        {
          get { return au_DetectorParameters_getAdaptiveThreshWinSizeStep(cppPtr); }
          set { au_DetectorParameters_setAdaptiveThreshWinSizeStep(cppPtr, value); }
        }

        public double AdaptiveThreshConstant
        {
          get { return au_DetectorParameters_getAdaptiveThreshConstant(cppPtr); }
          set { au_DetectorParameters_setAdaptiveThreshConstant(cppPtr, value); }
        }

        public double MinMarkerPerimeterRate
        {
          get { return au_DetectorParameters_getMinMarkerPerimeterRate(cppPtr); }
          set { au_DetectorParameters_setMinMarkerPerimeterRate(cppPtr, value); }
        }

        public double MaxMarkerPerimeterRate
        {
          get { return au_DetectorParameters_getMaxMarkerPerimeterRate(cppPtr); }
          set { au_DetectorParameters_setMaxMarkerPerimeterRate(cppPtr, value); }
        }

        public double PolygonalApproxAccuracyRate
        {
          get { return au_DetectorParameters_getPolygonalApproxAccuracyRate(cppPtr); }
          set { au_DetectorParameters_setPolygonalApproxAccuracyRate(cppPtr, value); }
        }

        public double MinCornerDistanceRate
        {
          get { return au_DetectorParameters_getMinCornerDistanceRate(cppPtr); }
          set { au_DetectorParameters_setMinCornerDistanceRate(cppPtr, value); }
        }

        public int MinDistanceToBorder
        {
          get { return au_DetectorParameters_getMinDistanceToBorder(cppPtr); }
          set { au_DetectorParameters_setMinDistanceToBorder(cppPtr, value); }
        }

        public double MinMarkerDistanceRate
        {
          get { return au_DetectorParameters_getMinMarkerDistanceRate(cppPtr); }
          set { au_DetectorParameters_setMinMarkerDistanceRate(cppPtr, value); }
        }

        public bool DoCornerRefinement
        {
          get { return au_DetectorParameters_getDoCornerRefinement(cppPtr); }
          set { au_DetectorParameters_setDoCornerRefinement(cppPtr, value); }
        }

        public int CornerRefinementWinSize
        {
          get { return au_DetectorParameters_getCornerRefinementWinSize(cppPtr); }
          set { au_DetectorParameters_setCornerRefinementWinSize(cppPtr, value); }
        }

        public int CornerRefinementMaxIterations
        {
          get { return au_DetectorParameters_getCornerRefinementMaxIterations(cppPtr); }
          set { au_DetectorParameters_setCornerRefinementMaxIterations(cppPtr, value); }
        }

        public double CornerRefinementMinAccuracy
        {
          get { return au_DetectorParameters_getCornerRefinementMinAccuracy(cppPtr); }
          set { au_DetectorParameters_setCornerRefinementMinAccuracy(cppPtr, value); }
        }

        public int MarkerBorderBits
        {
          get { return au_DetectorParameters_getMarkerBorderBits(cppPtr); }
          set { au_DetectorParameters_setMarkerBorderBits(cppPtr, value); }
        }

        public int PerspectiveRemovePixelPerCell
        {
          get { return au_DetectorParameters_getPerspectiveRemovePixelPerCell(cppPtr); }
          set { au_DetectorParameters_setPerspectiveRemovePixelPerCell(cppPtr, value); }
        }

        public double PerspectiveRemoveIgnoredMarginPerCell
        {
          get { return au_DetectorParameters_getPerspectiveRemoveIgnoredMarginPerCell(cppPtr); }
          set { au_DetectorParameters_setPerspectiveRemoveIgnoredMarginPerCell(cppPtr, value); }
        }

        public double MaxErroneousBitsInBorderRate
        {
          get { return au_DetectorParameters_getMaxErroneousBitsInBorderRate(cppPtr); }
          set { au_DetectorParameters_setMaxErroneousBitsInBorderRate(cppPtr, value); }
        }

        public double MinOtsuStdDev
        {
          get { return au_DetectorParameters_getMinOtsuStdDev(cppPtr); }
          set { au_DetectorParameters_setMinOtsuStdDev(cppPtr, value); }
        }

        public double ErrorCorrectionRate
        {
          get { return au_DetectorParameters_getErrorCorrectionRate(cppPtr); }
          set { au_DetectorParameters_setErrorCorrectionRate(cppPtr, value); }
        }
      }
    }
  }

  /// \} aruco_unity_package
}