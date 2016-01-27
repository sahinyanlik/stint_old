using stint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stint.Models;
using Microsoft.Phone.Tasks;
using stint.WinPhone.Dependencies;
using Xamarin.Forms;

[assembly: Dependency(typeof(CameraProvider))]
namespace stint.WinPhone.Dependencies
{
    using System.Threading.Tasks;
    using Microsoft.Phone.Tasks;
    using Xamarin.Forms;
    public class CameraProvider : ICameraProvider
    {
        private TaskCompletionSource<CameraResult> tcs;

        public Task<CameraResult> TakePictureAsync()
        {
            CameraCaptureTask cameraCaptureTask = new CameraCaptureTask();
            cameraCaptureTask.Completed += CameraCaptureTaskOnCompleted;

            cameraCaptureTask.Show();

            tcs = new TaskCompletionSource<CameraResult>();

            return tcs.Task;
        }

        private void CameraCaptureTaskOnCompleted(object sender, PhotoResult photoResult)
        {
            if (photoResult.TaskResult == TaskResult.None)
            {
                tcs.TrySetException(photoResult.Error);
                return;
            }

            if (photoResult.TaskResult == TaskResult.Cancel)
            {
                tcs.TrySetResult(null);
                return;
            }

            CameraResult result = new CameraResult();
            result.Picture = ImageSource.FromStream(() => photoResult.ChosenPhoto);
            result.FilePath = photoResult.OriginalFileName;

            tcs.TrySetResult(result);
        }
    }
}
