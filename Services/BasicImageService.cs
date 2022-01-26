using Microsoft.AspNetCore.Http;
using PatternColection.Services.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PatternColection.Services
{

    public class BasicImageService : IImageService
    {
   
      

        string IImageService.ConvertByteArrayToFile(byte[] fileData, string extension)
        {
            if (fileData is null) return string.Empty;
            string imageBase64Data = Convert.ToBase64String(fileData);
            return $"data:{extension};base64,{imageBase64Data}";
        }

       async Task<byte[]> IImageService.ConvertFileToByteArrayAsync(IFormFile file)
        {
            using MemoryStream memoryStream = new();
            await file.CopyToAsync(memoryStream);
            byte[] byteFile = memoryStream.ToArray();
            return byteFile;
        }
    }
}