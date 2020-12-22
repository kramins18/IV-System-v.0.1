using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public interface IFileService
    {
        //bool SaveChanges();
        //void SaveFileToDataBase(FileModel file);
        void SaveFileToPhysicalStorage(IFormFile file, string fileName);
        IDirectoryContents getAllPhysicalFiles();
        //IEnumerable<FileModelGetDTO> getAllDbFiles();
        //IEnumerable<FileModel> getFromDbById(int id);
        //byte[] GetFileFromServer(string fileName);
    }
}
