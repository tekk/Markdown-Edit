﻿using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Infrastructure
{
    public interface IImageService
    {
        Task<string> UploadToImgur(Stream stream, UploadProgressChangedEventHandler progress, UploadValuesCompletedEventHandler completed);
        Task<string> ImageFileToDataUri(Stream stream, string imageType, string name);
        Task<string> SaveAs(Stream stream);
        string CreateImageTag(string link, string title);
        string ClipboardDibToDataUri();
        BitmapSource ClipboardDibToBitmapSource();
        byte[] ToPngArray(BitmapSource bitmapsource);
        bool HasImageExtension(string url);
        bool IsImageUrl(string url);
    }
}