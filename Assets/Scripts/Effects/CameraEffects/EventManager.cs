using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEventManager : MonoBehaviour {
	//在此处声明新的事件 
	public delegate void CameraShake ();
	public static event CameraShake shaking;

	public delegate void CameraBlur();
	public static event CameraBlur bluring;


	public delegate void CameraDisBlur();
	public static event CameraBlur disBluring;


	//在此处写静态函数
	public static void shakeCamera(){
		if (shaking != null) {
			shaking ();
		}
	}

	public static void blurCamera(){
		if (bluring != null) {
			bluring ();
		}
	}
		
	public static void disBlurCamera(){
		if (bluring != null) {
			disBluring ();
		}
	}

}
