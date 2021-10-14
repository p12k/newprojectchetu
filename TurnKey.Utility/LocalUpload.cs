using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace TurnKey.Utility
{
    public class LocalUpload
    {
        //public static string UploadFileAsync(FileUpload control, byte[] image64)
        //{
        //    try
        //    {
        //        string path2 = System.Web.HttpContext.Current.Server.MapPath("~/UploadedImages/TemplateImages");
        //        // string FilePath = Application.StartupPath + "\\Images\\test2.jpg";
        //        string path = Server.MapPath(".") + "\\Images\\" + FileUpload1.FileName;
        //        FileUpload1.SaveAs(path);
        //        pictureBox3.Image.Save(FilePath, ImageFormat.Jpeg)
        //        if (!Directory.Exists(path2))
        //        {
        //            Directory.CreateDirectory(path2);
        //        }
        //        var ext = Path.GetExtension(control.FileName);
        //        var name = Path.GetFileNameWithoutExtension(control.FileName);
        //        string file = name.Trim().Replace(" ", "_") + "_" + DateTime.Now.Ticks;
        //        string fileName = file + ext;
        //        String filePath = System.Web.HttpContext.Current.Server.MapPath("~/UploadedImages/TemplateImages/" + fileName);
        //        control.SaveAs(filePath);
        //        return fileName;
        //    }
        //    catch (Exception e)
        //    {
        //        var message = e;
        //        return "False";
        //    }
        //}

        //public static string LocalUrl(FileUpload control)
        //{

        //    Uri newUri = new Uri(BaseSiteUrl + "UploadedImages/TemplateImages/" + fileName);
        //    //Uri imgUrl = new Uri(myUri, fileName);           
        //    return Convert.ToString(newUri);
        //}

        // public static string BaseSiteUrl
        //{
        //    get
        //    {
        //        HttpContext context = HttpContext.Current;
        //        string baseUrl = context.Request.Url.Scheme + "://" + context.Request.Url.Authority + context.Request.ApplicationPath.TrimEnd('/') + '/';
        //        return baseUrl;
        //    }
        //}
    }
}