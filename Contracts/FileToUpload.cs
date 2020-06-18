namespace FUS.Contracts
{
    public class FileToUpload
    {
        public string FileName {get; set;}
        public string FileContentBase64JS {get; set;}

        public string FileContentBase64 { 
            get {
                var fileContentSplitted = FileContentBase64JS.Split(',');
                if(fileContentSplitted.Length == 2)
                {
                    return fileContentSplitted[1];
                }
                return "";
            }
        }
    }
}