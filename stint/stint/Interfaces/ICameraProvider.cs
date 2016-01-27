using stint.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace stint.Interfaces
{
    public interface ICameraProvider
    {
        Task<CameraResult> TakePictureAsync();
    }
}
