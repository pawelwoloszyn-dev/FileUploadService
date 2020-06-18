using System;

namespace FUS.Contracts
{
    public class FusFile
    {
        public Guid Id {get; set;}

        public Guid UploaderId {get; set;}

        public string FileName {get; set;}
    }
}