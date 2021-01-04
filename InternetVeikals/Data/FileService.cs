using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public class FileService: IFileService
    {
        //private readonly Context _context;
        private IMapper _mapper;

        public FileService(Context context, IMapper mapper)
        {
            _mapper = mapper;
            //_context = context;
        }

        //public bool SaveChanges()
        //{
        //    return (_context.SaveChanges() >= 0);
        //}


        public void SaveFileToPhysicalStorage(IFormFile file, string fileName)
        {
            var pathToSave = @"C:\Users\Arvids\Desktop\ShopFileStorage";
            var fullPath = Path.Combine(pathToSave, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

        }

        //public byte[] GetFileFromServer(string fileName)
        //{
        //    //var data = net.DownloadData(@"C:\Users\ArvīdsKramiņš\Desktop\Backend\FileUploadStorage\file");
        //    var fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\ArvīdsKramiņš\Desktop\Backend\FileUploadStorage\file.ts");
        //    return fileBytes;
        //}

        public IDirectoryContents getAllPhysicalFiles()
        {
            var pathToFiles = @"C:\Users\Arvids\Desktop\ShopFileStorage";
            var provider = new PhysicalFileProvider(pathToFiles);
            var fileInfo = provider.GetDirectoryContents(@"\");
            return fileInfo;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public IEnumerable<FileModelGetDTO> getAllDbFiles()
        //{
        //    return _mapper.Map<IEnumerable<FileModelGetDTO>>(_context.Files.ToList());
        //}

        //public IEnumerable<FileModel> getFromDbById(int id)
        //{
        //    return _context.Files.Where(x => x.Id == id).ToList();
        //}
    }
}
