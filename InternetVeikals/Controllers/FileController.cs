using InternetVeikals.Data;
using InternetVeikals.Data.ProductService;
using InternetVeikals.Models.Product;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace InternetVeikals.Controllers
{
    [Route("/api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly IFileService _fileService;
        private readonly IProductImageService _productImageService;

        public FileController(IFileService fileService, IProductImageService productImageService)
        {
            _fileService = fileService;
            _productImageService = productImageService;
        }

      

        [HttpGet("/{fileName}")]
        public async Task<IActionResult> Get(string fileName)
        {
            var image = System.IO.File.OpenRead(@"C:\Users\ArvīdsKramiņš\Desktop\Backend\FileUploadStorage\");
            return File(image, image.con );
        }

        //[HttpGet("download/{filename}")]
        //public IActionResult DownloadFile(string filename)
        //{
        //    var file = _fileService.GetFileFromServer(filename); // gets bite[] from service by filename
        //    return File(file, "application/force-download", filename);
        //}

        //[HttpGet("downloaddb/{id}")]
        //public IActionResult DownloadFileDb(int id)
        //{
        //    var x = _fileService.getFromDbById(id).ToList()[0];
        //    var file = x.Content;
        //    return File(file, "application/force-download", x.Name);
        //}

        [HttpGet("physicalfiles")]
        public IActionResult PhisicalFiles()
        {
            return Ok(_fileService.getAllPhysicalFiles());
        }

        //[HttpGet("dbfiles")]
        //public IActionResult DbFiles()
        //{
        //    return Ok(_fileService.getAllDbFiles());
        //}

        [HttpPost("upload/{id}")]
        public IActionResult UploadFileToRepo(long id)
        {
            try
            {
                var files = Request.Form.Files;
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        _fileService.SaveFileToPhysicalStorage(file, fileName);
                        var productImage = new ProductImage();
                        productImage.ProductId = id;
                        productImage.ImgUrl = fileName;
                        _productImageService.CreateProductImage(productImage);
                    }
                    else
                    {
                        return BadRequest("File Was Empty?");
                    }

                }
                _productImageService.SaveChanges();
                return Ok();                    
              
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        //[HttpPost("uploadtodb")]
        //public async Task<IActionResult> Uploadtodb()
        //{
        //    try
        //    {
        //        using (var memoryStream = new MemoryStream())
        //        {
        //            await Request.Form.Files[0].CopyToAsync(memoryStream);
        //            var file = new FileModel()
        //            {
        //                Content = memoryStream.ToArray(),
        //                Name = Request.Form.Files[0].FileName,
        //                Size = memoryStream.Length
        //            };
        //            if (file.Content.Length == 0)
        //            {
        //                return BadRequest("File was empty");
        //            }
        //            else if (file.Content.Length > 2000000)
        //            {
        //                return BadRequest("File Was too large");
        //            }
        //            _fileService.SaveFileToDataBase(file);
        //            _fileService.SaveChanges();
        //        }
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
