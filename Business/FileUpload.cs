using System;
using System.IO;
using FUS.Business.Interfaces;
using FUS.Contracts;

namespace FUS.Business
{
    public class FileUpload : IFileUpload
    {
        public FusFile UploadFile(Guid uploaderId, FileToUpload fileToUpload)
        {
            //TODO: Need to implement abstraction to get specyfic uploader for uploaderId - now there is no db
            var file = new FileInfo(fileToUpload.FileName);
            File.WriteAllBytes(@"d:\UploadTest\" + file.Name, Convert.FromBase64String(fileToUpload.FileContentBase64));
            return new FusFile()
                     {
                         Id = Guid.NewGuid(),
                         UploaderId = uploaderId,
                         FileName = file.Name
                     };
        }
    }
}