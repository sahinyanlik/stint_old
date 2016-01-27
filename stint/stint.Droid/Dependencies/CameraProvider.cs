using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using stint.Droid.Dependencies;
using System.Runtime.CompilerServices;

[assembly: Dependency(typeof(CameraProvider))]
namespace stint.Droid.Dependencies
{
    using System;
    using System.Threading.Tasks;

    using Android.App;
    using Android.Content;
    using Android.Provider;


    using Java.IO;

    using Environment = Android.OS.Environment;
    using Uri = Android.Net.Uri;
    using Interfaces;
    using Models;
    using Xamarin.Forms;
    public class CameraProvider : ICameraProvider
    {
        private static File file;
        private static File pictureDirectory;

        private static TaskCompletionSource<CameraResult> tcs;

        public Task<CameraResult> TakePictureAsync()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);

            pictureDirectory = new File(Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures), "CameraAppDemo");

            if (!pictureDirectory.Exists())
            {
                pictureDirectory.Mkdirs();
            }

            file = new File(pictureDirectory, String.Format("photo_{0}.jpg", Guid.NewGuid()));

            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(file));

            var activity = (Activity)Forms.Context;
            activity.StartActivityForResult(intent, 0);

            tcs = new TaskCompletionSource<CameraResult>();

            return tcs.Task;
        }

        public static void OnResult(Result resultCode)
        {
            if (resultCode == Result.Canceled)
            {
                tcs.TrySetResult(null);
                return;
            }

            if (resultCode != Result.Ok)
            {
                tcs.TrySetException(new Exception("Unexpected error"));
                return;
            }

            CameraResult res = new CameraResult();
            res.Picture = ImageSource.FromFile(file.Path);
            res.FilePath = file.Path;

            tcs.TrySetResult(res);
        }
    }
}