#include "aruco_unity/cv/imgproc.hpp"
#include "aruco_unity/cv/exception.hpp"

extern "C" {
  // Static member functions
  void au_cv_imgproc_initUndistortRectifyMap(cv::Mat* cameraMatrix, cv::Mat* distCoeffs, cv::Mat* R, cv::Mat* newCameraMatrix,
    cv::Size* size, int m1type, cv::Mat** map1, cv::Mat** map2, cv::Exception* exception)
  {
    try {
      *map1 = new cv::Mat();
      *map2 = new cv::Mat();

      cv::initUndistortRectifyMap(*cameraMatrix, *distCoeffs, *R, *newCameraMatrix, *size, m1type, **map1, **map2);
    }
    catch (const cv::Exception& e) {
      ARUCO_UNITY_COPY_EXCEPTION(exception, e);
      return;
    }
  }

  void au_cv_imgproc_remap1(cv::Mat* src, cv::Mat* dst, cv::Mat* map1, cv::Mat* map2, int interpolation, int borderType,
    cv::Scalar* borderValue, cv::Exception* exception)
  {
    try {
      cv::remap(*src, *dst, *map1, *map2, interpolation, borderType, *borderValue);
    }
    catch (const cv::Exception& e) {
      ARUCO_UNITY_COPY_EXCEPTION(exception, e);
      return;
    }
  }

  void au_cv_imgproc_remap2(cv::Mat* src, cv::Mat* dst, cv::Mat* map1, cv::Mat* map2, int interpolation, int borderType,
    cv::Exception* exception)
  {
    try {
      cv::remap(*src, *dst, *map1, *map2, interpolation, borderType);
    }
    catch (const cv::Exception& e) {
      ARUCO_UNITY_COPY_EXCEPTION(exception, e);
      return;
    }
  }

  void au_cv_imgproc_remap3(cv::Mat* src, cv::Mat* dst, cv::Mat* map1, cv::Mat* map2, int interpolation, cv::Exception* exception)
  {
    try {
      cv::remap(*src, *dst, *map1, *map2, interpolation);
    }
    catch (const cv::Exception& e) {
      ARUCO_UNITY_COPY_EXCEPTION(exception, e);
      return;
    }
  }

  void au_cv_imgproc_undistort2(cv::Mat* src, cv::Mat** dst, cv::Mat* cameraMatrix, cv::Mat* distCoeffs, cv::Exception* exception) {
    try {
      *dst = new cv::Mat();

      cv::undistort(*src, **dst, *cameraMatrix, *distCoeffs);
    }
    catch (const cv::Exception& e) {
      ARUCO_UNITY_COPY_EXCEPTION(exception, e);
      return;
    }
  }
}