using System.Runtime.InteropServices;

namespace ArucoUnity
{
  /// \addtogroup aruco_unity_package
  /// \{

  namespace Plugin
  {
    public static partial class Aruco
    {
      [DllImport("ArucoUnity")]
      static extern double au_calibrateCameraCharuco1(System.IntPtr charucoCorners, System.IntPtr charucoIds, System.IntPtr board,
        System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, out System.IntPtr tvecs, int flags,
        System.IntPtr criteria, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern double au_calibrateCameraCharuco2(System.IntPtr charucoCorners, System.IntPtr charucoIds, System.IntPtr board,
        System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, out System.IntPtr tvecs, int flags,
        System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern double au_calibrateCameraCharuco3(System.IntPtr charucoCorners, System.IntPtr charucoIds, System.IntPtr board,
        System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, out System.IntPtr tvecs,
        System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern double au_calibrateCameraCharuco4(System.IntPtr charucoCorners, System.IntPtr charucoIds, System.IntPtr board,
        System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvecs, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern double au_calibrateCameraCharuco5(System.IntPtr charucoCorners, System.IntPtr charucoIds, System.IntPtr board,
        System.IntPtr imageSize, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_detectCharucoDiamond1(System.IntPtr image, System.IntPtr markerCorners, System.IntPtr markerIds,
        float squareMarkerLengthRate, out System.IntPtr diamondCorners, out System.IntPtr diamondIds, System.IntPtr cameraMatrix,
        System.IntPtr distCoeffs, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_detectCharucoDiamond2(System.IntPtr image, System.IntPtr markerCorners, System.IntPtr markerIds,
        float squareMarkerLengthRate, out System.IntPtr diamondCorners, out System.IntPtr diamondIds, System.IntPtr cameraMatrix,
        System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_detectCharucoDiamond3(System.IntPtr image, System.IntPtr markerCorners, System.IntPtr markerIds,
        float squareMarkerLengthRate, out System.IntPtr diamondCorners, out System.IntPtr diamondIds, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawCharucoDiamond1(System.IntPtr dictionary, System.IntPtr ids, int squareLength, int markerLength,
        out System.IntPtr img, int marginSize, int borderBits, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawCharucoDiamond2(System.IntPtr dictionary, System.IntPtr ids, int squareLength, int markerLength,
        out System.IntPtr img, int marginSize, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawCharucoDiamond3(System.IntPtr dictionary, System.IntPtr ids, int squareLength, int markerLength,
        out System.IntPtr img, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawDetectedCornersCharuco1(System.IntPtr image, System.IntPtr charucoCorners, System.IntPtr charucoIds,
        System.IntPtr cornerColor, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawDetectedCornersCharuco2(System.IntPtr image, System.IntPtr charucoCorners, System.IntPtr charucoIds,
        System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawDetectedCornersCharuco3(System.IntPtr image, System.IntPtr charucoCorners, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawDetectedDiamonds1(System.IntPtr image, System.IntPtr diamondCorners, System.IntPtr diamondIds,
        System.IntPtr borderColor, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawDetectedDiamonds2(System.IntPtr image, System.IntPtr diamondCorners, System.IntPtr diamondIds, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_drawDetectedDiamonds3(System.IntPtr image, System.IntPtr diamondCorners, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern bool au_estimatePoseCharucoBoard(System.IntPtr charucoCorners, System.IntPtr charucoIds, System.IntPtr board,
        System.IntPtr cameraMatrix, System.IntPtr distCoeffs, out System.IntPtr rvec, out System.IntPtr tvec, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern void au_estimatePoseSingleMarkers(System.IntPtr corners, float markerLength, System.IntPtr cameraMatrix, System.IntPtr distCoeffs,
        out System.IntPtr rvecs, out System.IntPtr tvecs, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern int au_interpolateCornersCharuco1(System.IntPtr markerCorners, System.IntPtr markerIds, System.IntPtr image, System.IntPtr board,
        out System.IntPtr charucoCorners, out System.IntPtr charucoIds, System.IntPtr cameraMatrix, System.IntPtr distCoeffs, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern int au_interpolateCornersCharuco2(System.IntPtr markerCorners, System.IntPtr markerIds, System.IntPtr image, System.IntPtr board,
        out System.IntPtr charucoCorners, out System.IntPtr charucoIds, System.IntPtr cameraMatrix, System.IntPtr exception);

      [DllImport("ArucoUnity")]
      static extern int au_interpolateCornersCharuco3(System.IntPtr markerCorners, System.IntPtr markerIds, System.IntPtr image, System.IntPtr board,
        out System.IntPtr charucoCorners, out System.IntPtr charucoIds, System.IntPtr exception);

      public static double CalibrateCameraCharuco(Std.VectorVectorPoint2f charucoCorners, Std.VectorVectorInt charucoIds, CharucoBoard board, Cv.Core.Size imageSize,
        Cv.Core.Mat cameraMatrix, Cv.Core.Mat distCoeffs, out Std.VectorMat rvecs, out Std.VectorMat tvecs, Cv.Calib3d.Calib flags, Cv.Core.TermCriteria criteria)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr rvecsPtr, tvecsPtr;

        double reProjectionError = au_calibrateCameraCharuco1(charucoCorners.cppPtr, charucoIds.cppPtr, board.cppPtr, imageSize.cppPtr, cameraMatrix.cppPtr,
          distCoeffs.cppPtr, out rvecsPtr, out tvecsPtr, (int)flags, criteria.cppPtr, exception.cppPtr);
        rvecs = new Std.VectorMat(rvecsPtr);
        tvecs = new Std.VectorMat(tvecsPtr);

        exception.Check();
        return reProjectionError;
      }

      public static double CalibrateCameraCharuco(Std.VectorVectorPoint2f charucoCorners, Std.VectorVectorInt charucoIds, CharucoBoard board, Cv.Core.Size imageSize,
        Cv.Core.Mat cameraMatrix, Cv.Core.Mat distCoeffs, out Std.VectorMat rvecs, out Std.VectorMat tvecs, Cv.Calib3d.Calib flags)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr rvecsPtr, tvecsPtr;

        double reProjectionError = au_calibrateCameraCharuco2(charucoCorners.cppPtr, charucoIds.cppPtr, board.cppPtr, imageSize.cppPtr, cameraMatrix.cppPtr,
          distCoeffs.cppPtr, out rvecsPtr, out tvecsPtr, (int)flags, exception.cppPtr);
        rvecs = new Std.VectorMat(rvecsPtr);
        tvecs = new Std.VectorMat(tvecsPtr);

        exception.Check();
        return reProjectionError;
      }

      public static double CalibrateCameraCharuco(Std.VectorVectorPoint2f charucoCorners, Std.VectorVectorInt charucoIds, CharucoBoard board, Cv.Core.Size imageSize,
        Cv.Core.Mat cameraMatrix, Cv.Core.Mat distCoeffs, out Std.VectorMat rvecs, out Std.VectorMat tvecs)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr rvecsPtr, tvecsPtr;

        double reProjectionError = au_calibrateCameraCharuco3(charucoCorners.cppPtr, charucoIds.cppPtr, board.cppPtr, imageSize.cppPtr, cameraMatrix.cppPtr,
          distCoeffs.cppPtr, out rvecsPtr, out tvecsPtr, exception.cppPtr);
        rvecs = new Std.VectorMat(rvecsPtr);
        tvecs = new Std.VectorMat(tvecsPtr);

        exception.Check();
        return reProjectionError;
      }

      public static double CalibrateCameraCharuco(Std.VectorVectorPoint2f charucoCorners, Std.VectorVectorInt charucoIds, CharucoBoard board, Cv.Core.Size imageSize,
        Cv.Core.Mat cameraMatrix, Cv.Core.Mat distCoeffs, out Std.VectorMat rvecs)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr rvecsPtr;

        double reProjectionError = au_calibrateCameraCharuco4(charucoCorners.cppPtr, charucoIds.cppPtr, board.cppPtr, imageSize.cppPtr, cameraMatrix.cppPtr,
          distCoeffs.cppPtr, out rvecsPtr, exception.cppPtr);
        rvecs = new Std.VectorMat(rvecsPtr);

        exception.Check();
        return reProjectionError;
      }

      public static double CalibrateCameraCharuco(Std.VectorVectorPoint2f charucoCorners, Std.VectorVectorInt charucoIds, CharucoBoard board, Cv.Core.Size imageSize,
        Cv.Core.Mat cameraMatrix, Cv.Core.Mat distCoeffs)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();

        double reProjectionError = au_calibrateCameraCharuco5(charucoCorners.cppPtr, charucoIds.cppPtr, board.cppPtr, imageSize.cppPtr, cameraMatrix.cppPtr,
          distCoeffs.cppPtr, exception.cppPtr);

        exception.Check();
        return reProjectionError;
      }

      public static void DetectCharucoDiamond(Cv.Core.Mat image, Std.VectorVectorPoint2f markerCorners, Std.VectorInt markerIds, float squareMarkerLengthRate,
        out Std.VectorVectorPoint2f diamondCorners, out Std.VectorVec4i diamondIds, Cv.Core.Mat cameraMatrix, Cv.Core.Mat distCoeffs)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr diamondCornersPtr, diamondIdsPtr;

        au_detectCharucoDiamond1(image.cppPtr, markerCorners.cppPtr, markerIds.cppPtr, squareMarkerLengthRate, out diamondCornersPtr,
          out diamondIdsPtr, cameraMatrix.cppPtr, distCoeffs.cppPtr, exception.cppPtr);
        diamondCorners = new Std.VectorVectorPoint2f(diamondCornersPtr);
        diamondIds = new Std.VectorVec4i(diamondIdsPtr);

        exception.Check();
      }

      public static void DetectCharucoDiamond(Cv.Core.Mat image, Std.VectorVectorPoint2f markerCorners, Std.VectorInt markerIds, float squareMarkerLengthRate,
        out Std.VectorVectorPoint2f diamondCorners, out Std.VectorVec4i diamondIds, Cv.Core.Mat cameraMatrix)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr diamondCornersPtr, diamondIdsPtr;

        au_detectCharucoDiamond2(image.cppPtr, markerCorners.cppPtr, markerIds.cppPtr, squareMarkerLengthRate, out diamondCornersPtr,
          out diamondIdsPtr, cameraMatrix.cppPtr, exception.cppPtr);
        diamondCorners = new Std.VectorVectorPoint2f(diamondCornersPtr);
        diamondIds = new Std.VectorVec4i(diamondIdsPtr);

        exception.Check();
      }

      public static void DetectCharucoDiamond(Cv.Core.Mat image, Std.VectorVectorPoint2f markerCorners, Std.VectorInt markerIds, float squareMarkerLengthRate,
        out Std.VectorVectorPoint2f diamondCorners, out Std.VectorVec4i diamondIds)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr diamondCornersPtr, diamondIdsPtr;

        au_detectCharucoDiamond3(image.cppPtr, markerCorners.cppPtr, markerIds.cppPtr, squareMarkerLengthRate, out diamondCornersPtr,
          out diamondIdsPtr, exception.cppPtr);
        diamondCorners = new Std.VectorVectorPoint2f(diamondCornersPtr);
        diamondIds = new Std.VectorVec4i(diamondIdsPtr);

        exception.Check();
      }

      public static void DrawCharucoDiamond(Dictionary dictionary, Cv.Core.Vec4i ids, int squareLength, int markerLength, out Cv.Core.Mat image, int marginSize,
        int borderBits)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr imagePtr;

        au_drawCharucoDiamond1(dictionary.cppPtr, ids.cppPtr, squareLength, markerLength, out imagePtr, marginSize, borderBits, exception.cppPtr);
        image = new Cv.Core.Mat(imagePtr);

        exception.Check();
      }

      public static void DrawCharucoDiamond(Dictionary dictionary, Cv.Core.Vec4i ids, int squareLength, int markerLength, out Cv.Core.Mat image, int marginSize)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr imagePtr;

        au_drawCharucoDiamond2(dictionary.cppPtr, ids.cppPtr, squareLength, markerLength, out imagePtr, marginSize, exception.cppPtr);
        image = new Cv.Core.Mat(imagePtr);

        exception.Check();
      }

      public static void DrawCharucoDiamond(Dictionary dictionary, Cv.Core.Vec4i ids, int squareLength, int markerLength, out Cv.Core.Mat image)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr imagePtr;

        au_drawCharucoDiamond3(dictionary.cppPtr, ids.cppPtr, squareLength, markerLength, out imagePtr, exception.cppPtr);
        image = new Cv.Core.Mat(imagePtr);

        exception.Check();
      }

      public static void DrawDetectedCornersCharuco(Cv.Core.Mat image, Std.VectorPoint2f charucoCorners, Std.VectorInt charucoIds, Cv.Core.Scalar cornerColor)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        au_drawDetectedCornersCharuco1(image.cppPtr, charucoCorners.cppPtr, charucoIds.cppPtr, cornerColor.cppPtr, exception.cppPtr);
        exception.Check();
      }

      public static void DrawDetectedCornersCharuco(Cv.Core.Mat image, Std.VectorPoint2f charucoCorners, Std.VectorInt charucoIds)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        au_drawDetectedCornersCharuco2(image.cppPtr, charucoCorners.cppPtr, charucoIds.cppPtr, exception.cppPtr);
        exception.Check();
      }

      public static void DrawDetectedCornersCharuco(Cv.Core.Mat image, Std.VectorPoint2f charucoCorners)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        au_drawDetectedCornersCharuco3(image.cppPtr, charucoCorners.cppPtr, exception.cppPtr);
        exception.Check();
      }

      public static void DrawDetectedDiamonds(Cv.Core.Mat image, Std.VectorVectorPoint2f diamondCorners, Std.VectorVec4i diamondIds, Cv.Core.Scalar borderColor)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        au_drawDetectedDiamonds1(image.cppPtr, diamondCorners.cppPtr, diamondIds.cppPtr, borderColor.cppPtr, exception.cppPtr);
        exception.Check();
      }

      public static void DrawDetectedDiamonds(Cv.Core.Mat image, Std.VectorVectorPoint2f diamondCorners, Std.VectorVec4i diamondIds)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        au_drawDetectedDiamonds2(image.cppPtr, diamondCorners.cppPtr, diamondIds.cppPtr, exception.cppPtr);
        exception.Check();
      }

      public static void DrawDetectedDiamonds(Cv.Core.Mat image, Std.VectorVectorPoint2f diamondCorners)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        au_drawDetectedDiamonds3(image.cppPtr, diamondCorners.cppPtr, exception.cppPtr);
        exception.Check();
      }

      public static bool EstimatePoseCharucoBoard(Std.VectorPoint2f charucoCorners, Std.VectorInt charucoIds, CharucoBoard board, Cv.Core.Mat cameraMatrix,
        Cv.Core.Mat distCoeffs, out Cv.Core.Vec3d rvec, out Cv.Core.Vec3d tvec)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr rvecPtr, tvecPtr;

        bool valid = au_estimatePoseCharucoBoard(charucoCorners.cppPtr, charucoIds.cppPtr, board.cppPtr, cameraMatrix.cppPtr, distCoeffs.cppPtr,
          out rvecPtr, out tvecPtr, exception.cppPtr);
        rvec = new Cv.Core.Vec3d(rvecPtr);
        tvec = new Cv.Core.Vec3d(tvecPtr);

        exception.Check();
        return valid;
      }

      public static int InterpolateCornersCharuco(Std.VectorVectorPoint2f markerCorners, Std.VectorInt markerIds, Cv.Core.Mat image, CharucoBoard board,
        out Std.VectorPoint2f charucoCorners, out Std.VectorInt charucoIds, Cv.Core.Mat cameraMatrix, Cv.Core.Mat distCoeffs)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr charucoCornersPtr, charucoIdsPtr;

        int interpolateCorners = au_interpolateCornersCharuco1(markerCorners.cppPtr, markerIds.cppPtr, image.cppPtr, board.cppPtr,
          out charucoCornersPtr, out charucoIdsPtr, cameraMatrix.cppPtr, distCoeffs.cppPtr, exception.cppPtr);
        charucoCorners = new Std.VectorPoint2f(charucoCornersPtr);
        charucoIds = new Std.VectorInt(charucoIdsPtr);
        exception.Check();

        return interpolateCorners;
      }

      public static int InterpolateCornersCharuco(Std.VectorVectorPoint2f markerCorners, Std.VectorInt markerIds, Cv.Core.Mat image, CharucoBoard board,
        out Std.VectorPoint2f charucoCorners, out Std.VectorInt charucoIds, Cv.Core.Mat cameraMatrix)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr charucoCornersPtr, charucoIdsPtr;

        int interpolateCorners = au_interpolateCornersCharuco2(markerCorners.cppPtr, markerIds.cppPtr, image.cppPtr, board.cppPtr,
          out charucoCornersPtr, out charucoIdsPtr, cameraMatrix.cppPtr, exception.cppPtr);
        charucoCorners = new Std.VectorPoint2f(charucoCornersPtr);
        charucoIds = new Std.VectorInt(charucoIdsPtr);
        exception.Check();

        return interpolateCorners;
      }

      public static int InterpolateCornersCharuco(Std.VectorVectorPoint2f markerCorners, Std.VectorInt markerIds, Cv.Core.Mat image, CharucoBoard board,
        out Std.VectorPoint2f charucoCorners, out Std.VectorInt charucoIds)
      {
        Cv.Core.Exception exception = new Cv.Core.Exception();
        System.IntPtr charucoCornersPtr, charucoIdsPtr;

        int interpolateCorners = au_interpolateCornersCharuco3(markerCorners.cppPtr, markerIds.cppPtr, image.cppPtr, board.cppPtr,
          out charucoCornersPtr, out charucoIdsPtr, exception.cppPtr);
        charucoCorners = new Std.VectorPoint2f(charucoCornersPtr);
        charucoIds = new Std.VectorInt(charucoIdsPtr);
        exception.Check();

        return interpolateCorners;
      }

      public class CharucoBoard : Board
      {
        [DllImport("ArucoUnity")]
        static extern void au_CharucoBoard_delete(System.IntPtr charucoBoard);

        [DllImport("ArucoUnity")]
        static extern void au_CharucoBoard_draw1(System.IntPtr charucoBoard, System.IntPtr outSize, out System.IntPtr img, int marginSize,
          int borderBits, System.IntPtr exception);

        [DllImport("ArucoUnity")]
        static extern void au_CharucoBoard_draw2(System.IntPtr charucoBoard, System.IntPtr outSize, out System.IntPtr img, int marginSize,
          System.IntPtr exception);

        [DllImport("ArucoUnity")]
        static extern void au_CharucoBoard_draw3(System.IntPtr charucoBoard, System.IntPtr outSize, out System.IntPtr img, System.IntPtr exception);

        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_CharucoBoard_getChessboardSize(System.IntPtr charucoBoard);

        [DllImport("ArucoUnity")]
        static extern float au_CharucoBoard_getMarkerLength(System.IntPtr charucoBoard);

        [DllImport("ArucoUnity")]
        static extern float au_CharucoBoard_getSquareLength(System.IntPtr charucoBoard);

        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_CharucoBoard_create(int squaresX, int squaresY, float squareLength, float markerLength, System.IntPtr dictionary,
        System.IntPtr exception);

        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_CharucoBoard_getChessboardCorners(System.IntPtr charucoBoard);

        [DllImport("ArucoUnity")]
        static extern void au_CharucoBoard_setChessboardCorners(System.IntPtr charucoBoard, System.IntPtr chessboardCorners);

        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_CharucoBoard_getNearestMarkerCorners(System.IntPtr charucoBoard);

        [DllImport("ArucoUnity")]
        static extern void au_CharucoBoard_setNearestMarkerCorners(System.IntPtr charucoBoard, System.IntPtr nearestMarkerCorners);

        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_CharucoBoard_getNearestMarkerIdx(System.IntPtr charucoBoard);

        [DllImport("ArucoUnity")]
        static extern void au_CharucoBoard_setNearestMarkerIdx(System.IntPtr charucoBoard, System.IntPtr nearestMarkerIdx);

        protected override void DeleteCvPtr()
        {
          au_CharucoBoard_delete(cppPtr);
        }

        internal CharucoBoard(System.IntPtr charucoBoardPtr, DeleteResponsibility deleteResponsibility = DeleteResponsibility.True)
            : base(charucoBoardPtr, deleteResponsibility)
        {
        }

        public void Draw(Cv.Core.Size outSize, out Cv.Core.Mat img, int marginSize, int borderBits)
        {
          Cv.Core.Exception exception = new Cv.Core.Exception();
          System.IntPtr imgPtr;

          au_CharucoBoard_draw1(cppPtr, outSize.cppPtr, out imgPtr, marginSize, borderBits, exception.cppPtr);
          img = new Cv.Core.Mat(imgPtr);

          exception.Check();
        }

        public void Draw(Cv.Core.Size outSize, out Cv.Core.Mat img, int marginSize)
        {
          Cv.Core.Exception exception = new Cv.Core.Exception();
          System.IntPtr imgPtr;

          au_CharucoBoard_draw2(cppPtr, outSize.cppPtr, out imgPtr, marginSize, exception.cppPtr);
          img = new Cv.Core.Mat(imgPtr);

          exception.Check();
        }

        public void Draw(Cv.Core.Size outSize, out Cv.Core.Mat img)
        {
          Cv.Core.Exception exception = new Cv.Core.Exception();
          System.IntPtr imgPtr;

          au_CharucoBoard_draw3(cppPtr, outSize.cppPtr, out imgPtr, exception.cppPtr);
          img = new Cv.Core.Mat(imgPtr);

          exception.Check();
        }

        static public CharucoBoard Create(int squaresX, int squaresY, float squareLength, float markerLength, Dictionary dictionary)
        {
          Cv.Core.Exception exception = new Cv.Core.Exception();
          System.IntPtr charucoBoardPtr = au_CharucoBoard_create(squaresX, squaresY, squareLength, markerLength, dictionary.cppPtr,
            exception.cppPtr);
          exception.Check();
          return new CharucoBoard(charucoBoardPtr);
        }

        public Cv.Core.Size GetChessboardSize()
        {
          return new Cv.Core.Size(au_CharucoBoard_getChessboardSize(cppPtr));
        }

        public float GetMarkerLength()
        {
          return au_CharucoBoard_getMarkerLength(cppPtr);
        }

        public float GetSquareLength()
        {
          return au_CharucoBoard_getSquareLength(cppPtr);
        }

        public Std.VectorPoint3f chessboardCorners
        {
          get { return new Std.VectorPoint3f(au_CharucoBoard_getChessboardCorners(cppPtr), DeleteResponsibility.False); }
          set { au_CharucoBoard_setChessboardCorners(cppPtr, value.cppPtr); }
        }

        public Std.VectorVectorInt markerCorners
        {
          get { return new Std.VectorVectorInt(au_CharucoBoard_getNearestMarkerCorners(cppPtr), DeleteResponsibility.False); }
          set { au_CharucoBoard_setNearestMarkerCorners(cppPtr, value.cppPtr); }
        }

        public Std.VectorVectorInt markerIdx
        {
          get { return new Std.VectorVectorInt(au_CharucoBoard_getNearestMarkerIdx(cppPtr), DeleteResponsibility.False); }
          set { au_CharucoBoard_setNearestMarkerIdx(cppPtr, value.cppPtr); }
        }
      }
    }
  }
  
  /// \} aruco_unity_package
}