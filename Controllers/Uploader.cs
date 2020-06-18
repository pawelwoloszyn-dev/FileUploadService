using System;
using System.IO;
using System.Threading.Tasks;
using FUS.Business.Interfaces;
using FUS.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FUS.Controllers
{
    [ApiController]
    [Route("[controller]/{uploaderId}")]
    public class UploaderController
    {
        private IFileUpload _fileUpload;
        public UploaderController(IFileUpload fileUpload)
        {
            _fileUpload = fileUpload;
        }
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(Guid uploaderId, [FromBody]FileToUpload fileToUpload)
        {
            var result = _fileUpload.UploadFile(uploaderId, fileToUpload);
            
            return await Task.FromResult(new OkObjectResult(result));
        }

        [HttpGet("{fileId}")]
        public async Task<IActionResult> GetUploadedFile(Guid uploaderId, Guid fileId)
        {
            return await Task.FromResult(
                new OkObjectResult(
                    new FusFile()
                    {
                        Id = fileId,
                        UploaderId = uploaderId
                    }
                )
            );
        }

        [HttpGet]
        public async Task<IActionResult> GetUploadedFiles(Guid uploaderId)
        { 
            return await Task.FromResult(new OkObjectResult(new FusFile[] { 
                new FusFile()
                {
                    Id = Guid.NewGuid(),
                    UploaderId = uploaderId
                },
                new FusFile()
                {
                    Id = Guid.NewGuid(),
                    UploaderId = uploaderId
                }
            }));
        }
    }
}