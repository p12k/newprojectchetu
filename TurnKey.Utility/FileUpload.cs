using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurnKey.Utility
{
  public class FileUpload
    {
        public async Task<string> uploadPdfFile(IFormFile file,string URL)
        {
            // create new file name
            var newFilename = "";
            try
            {
                //get file extension like .jpeg, .png etc
               var ext = Path.GetExtension(file.FileName);               
                var FileName = Path.GetFileNameWithoutExtension(file.FileName);
                //string filenm = FileName.Trim().Replace(" ", "_") + "_" + DateTime.Now.Ticks;
                //newFilename = filenm + ext;
                //add extension in newfile name

                newFilename = Regex.Replace(FileName, @"\s", "") + "_" + DateTime.Now.Ticks + ext;
                var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot//UploadedImages/TemplateImages",
                    newFilename.Trim());
                var path1 = URL + "/UploadedImages/TemplateImages/"+ newFilename.Trim();
                //String filePath = System.Web.HttpContext.Current.Server.MapPath("~/UploadedImages/TemplateImages/" + fileName);
              
                newFilename = path1;

                // delete if file exists in server folder
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // insert new file
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            catch (Exception ex)
            {
                newFilename = "";
            }
            return newFilename;
        }


        public async Task<string> uploadNotePadFileForSignature(string signatureData)
        {
            // create new file name
            string signatureContent = string.Empty;
            signatureContent = signatureData;
            var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot//EmailSignature2");
            //string path2 = Server.MapPath("~/EmailSignature2");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllText(Path.Combine(path, "EmailSignature.txt"), signatureContent);
            return "Success";
        }


        //read note pad file
        public async Task<string> ReadAllTextFromNotePad()
        {
            var path = Path.Combine(
                  Directory.GetCurrentDirectory(), "wwwroot//EmailSignature2/EmailSignature.txt");

            string emailSignatureTemplate = File.ReadAllText(path);
            return emailSignatureTemplate;
        }
      
    }
}
