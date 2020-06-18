using System;
using FUS.Contracts;

namespace FUS.Business.Interfaces
{
    public interface IFileUpload
    {
         FusFile UploadFile(Guid uploaderId, FileToUpload fileToUpload);
    }
}