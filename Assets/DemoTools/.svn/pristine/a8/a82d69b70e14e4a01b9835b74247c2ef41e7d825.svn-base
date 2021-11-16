using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class Screenshots {

    public static void SaveCameraShot(Camera camera, RenderTexture renderTexture, Material material, string fileName) {


        camera.targetTexture = renderTexture;
        //RenderTexture currentRT = RenderTexture.active;
        GL.Clear(true, true, Color.black);
        camera.Render();

        RenderTexture renderTextureDivideByAlpha = RenderTexture.GetTemporary(renderTexture.descriptor);
        Graphics.Blit(renderTexture, renderTextureDivideByAlpha, material);
        RenderTexture.active = renderTextureDivideByAlpha;

        if (!camera) {
            Debug.Log("!camera");
            return;
        }
        if (camera.targetTexture) {
            Debug.Log("camera.targetTexture   "  + camera.targetTexture);
        }
        else {
            Debug.Log("NO");
        }

        Texture2D Image = new Texture2D(camera.targetTexture.width, camera.targetTexture.height);
        Image.ReadPixels(new Rect(0, 0, camera.targetTexture.width, camera.targetTexture.height), 0, 0);
        
        Image.Apply();

        RenderTexture.ReleaseTemporary(renderTextureDivideByAlpha);
        
        //RenderTexture.active = currentRT;

        var Bytes = Image.EncodeToPNG();
        
        File.WriteAllBytes("E:/Screenshots/" + fileName + ".png", Bytes);

        // To show image in Game View
        camera.targetTexture = null;

        Graphics.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), renderTexture);


        UnityEngine.Object.DestroyImmediate(Image);
        //UnityEngine.Object.DestroyImmediate(currentRT);
        //GC.Collect();
    }
    
}
