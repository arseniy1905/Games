using Games.Common.Configuration;
using Games.Common.Models;
using Games.Common.State;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.File;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Games.Common.Utils
{
    public class AzureUtil
    {
        public static async Task<bool> SendEmailAsync(IConfiguration configuration, User recipient, string subject, string plainTextContent, string htmlContent, List<Attachment> attachments)
        {
            var apiKey = configuration.GetSection("SendGridMailSettings:ApiKey").Value;
            var senderEmail = configuration.GetSection("SendGridMailSettings:From").Value;
            var senderName = configuration.GetSection("SendGridMailSettings:Sender").Value;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(senderEmail, senderName);
            var to = new EmailAddress(recipient.Email, recipient.UserName);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            if (attachments != null && attachments.Count > 0)
            {
                foreach (var attachment in attachments)
                {
                    msg.AddAttachment(attachment);
                }
            }
            var response = await client.SendEmailAsync(msg);
            return (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted);
        }
        public static async Task<bool> SendEmailAsync(IConfiguration configuration, List<string> toAddress, List<string> ccAddress, List<string> bccAddress, string subject, string htmlContent, List<UploadedFile> attachments)
        {
            var apiKey = configuration.GetSection("SendGridMailSettings:ApiKey").Value;
            var senderEmail = configuration.GetSection("SendGridMailSettings:From").Value;
            var senderName = configuration.GetSection("SendGridMailSettings:Sender").Value;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(senderEmail, senderName);

            //var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, to, subject, plainTextContent, htmlContent);
            //var msg = new SendGridMessage();
            var msg = MailHelper.CreateSingleEmail(from, new EmailAddress(toAddress[0]), subject, "", htmlContent);
            if (toAddress != null && toAddress.Count > 0)
            {
                int i = 0;
                foreach (string email in toAddress)
                {
                    if (i != 0)
                    {
                        msg.AddTo(new EmailAddress(email));
                    }
                    i++;
                }
            }
            if (ccAddress != null && ccAddress.Count > 0)
            {
                foreach (string email in ccAddress)
                {
                    msg.AddCc(new EmailAddress(email));
                }
            }
            if (bccAddress != null && bccAddress.Count > 0)
            {
                foreach (string email in bccAddress)
                {
                    msg.AddBcc(new EmailAddress(email));
                }
            }

            if (attachments != null && attachments.Count > 0)
            {
                foreach (var attachment in attachments)
                {
                    msg.AddAttachment(attachment.FileName, Convert.ToBase64String(attachment.FileContent));
                }
            }
            var response = await client.SendEmailAsync(msg);
            return (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted);
        }
        //public static bool SendEmail(IConfiguration configuration, List<string> toAddress, List<string> ccAddress, List<string> bccAddress, string subject, string htmlContent, List<UploadedFile> attachments)
        //{
        //    var apiKey = configuration.GetSection("SendGridMailSettings:ApiKey").Value;
        //    var senderEmail = configuration.GetSection("SendGridMailSettings:From").Value;
        //    var senderName = configuration.GetSection("SendGridMailSettings:Sender").Value;
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress(senderEmail, senderName);

        //    //var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, to, subject, plainTextContent, htmlContent);
        //    //var msg = new SendGridMessage();
        //    var msg = MailHelper.CreateSingleEmail(from, new EmailAddress(toAddress[0]), subject, "", htmlContent);
        //    if (toAddress != null && toAddress.Count > 0)
        //    {
        //        int i = 0;
        //        foreach (string email in toAddress)
        //        {
        //            if (i != 0)
        //            {
        //                msg.AddTo(new EmailAddress(email));
        //            }
        //            i++;
        //        }
        //    }
        //    if (ccAddress != null && ccAddress.Count > 0)
        //    {
        //        foreach (string email in ccAddress)
        //        {
        //            msg.AddCc(new EmailAddress(email));
        //        }
        //    }
        //    if (bccAddress != null && bccAddress.Count > 0)
        //    {
        //        foreach (string email in bccAddress)
        //        {
        //            msg.AddBcc(new EmailAddress(email));
        //        }
        //    }

        //    if (attachments != null && attachments.Count > 0)
        //    {
        //        foreach (var attachment in attachments)
        //        {
        //            msg.AddAttachment(attachment.FileName, Convert.ToBase64String(attachment.FileContent));
        //        }
        //    }
        //    var response = client.SendEmailAsync(msg).Result;
        //    return (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted);
        //}

        public static async Task<bool> SendEmailAsync(IConfiguration configuration, string recipientEmail, string subject, string plainTextContent, string htmlContent, List<Attachment> attachments)
        {
            var recipient = new User()
            {
                Email = recipientEmail,
                UserName = ""
            };
            return await SendEmailAsync(configuration, recipient, subject, plainTextContent, htmlContent, attachments);
        }

        public static string SaveFileToAzureBlob(string containerName, IFormFile formFile, IConfiguration configuration, bool saveToPrivateStorage = false)
        {
            if (formFile == null)
            {
                return string.Empty;
            }

            var connStringHotBlob = saveToPrivateStorage ?
                AppSettingsConfiguration.GetB2BPrivateWebUploadsCloudStorageConnstr() :
                AppSettingsConfiguration.GetB2BWebUploadsCloudStorageConnstr();

            if (string.IsNullOrEmpty(connStringHotBlob))
            {
                return string.Empty;
            }

            var storageAccount = CloudStorageAccount.Parse(connStringHotBlob);
            var fileClient = storageAccount.CreateCloudFileClient();
            var share = fileClient.GetShareReference(containerName.ToLower());

            share.CreateIfNotExists();
            var azBlobFileName = string.Empty;
            if (share.Exists())
            {
                var rootDir = share.GetRootDirectoryReference();
                string folderName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month) + "_" + DateTime.Now.Year;

                var downloadDir = rootDir.GetDirectoryReference(folderName.ToLower());
                downloadDir.CreateIfNotExists();

                if (downloadDir.Exists())
                {
                    var ms = new MemoryStream();
                    formFile.CopyToAsync(ms).Wait();
                    ms.Position = 0;
                    var uniqueFileName = GetUniqueFileName(Path.GetFileName(formFile.FileName));
                    var cloudFile = downloadDir.GetFileReference(uniqueFileName);


                    azBlobFileName = cloudFile.Uri.AbsolutePath;
                    cloudFile.UploadFromStreamAsync(ms).Wait();
                }
            }
            return azBlobFileName;
        }

        //public static async Task<string> SaveFileToAzureBlobAsync(string containerName, IFormFile formFile, IConfiguration configuration)
        //{
        //    var azBlobFileName = string.Empty;
        //    if (formFile == null)
        //    {
        //        return string.Empty;
        //    }

        //    var connStringHotBlob = configuration.GetSection("Services").Get<List<ServiceConfig>>()
        //                                         .FirstOrDefault(x => x.Active && x.CloudStorageConnStr != null)?
        //                                         .CloudStorageConnStr;

        //    if (string.IsNullOrEmpty(connStringHotBlob))
        //    {
        //        return string.Empty;
        //    }

        //    BlobContainerClient container = new BlobContainerClient(connStringHotBlob, "");
        //    container.CreateIfNotExists(PublicAccessType.Blob);
        //    var uniqueFileName = GetUniqueFileName(Path.GetFileName(formFile.FileName));
        //    //lines modified
        //    var blockBlob = container.GetBlobClient(uniqueFileName);

        //    var ms = new MemoryStream();
        //    await formFile.CopyToAsync(ms);
        //    blockBlob.Upload(ms);
        //    azBlobFileName = blockBlob.Uri.AbsolutePath;
        //    //var storageAccount = CloudStorageAccount.Parse(connStringHotBlob);
        //    //var fileClient = storageAccount.CreateCloudFileClient();
        //    //var share = fileClient.GetShareReference("downloads");

        //    //share.CreateIfNotExists();
        //    //var azBlobFileName = string.Empty;
        //    //if (share.Exists())
        //    //{
        //    //    var rootDir = share.GetRootDirectoryReference();
        //    //    string folderName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month) + "_" + DateTime.Now.Year;

        //    //    var downloadDir = rootDir.GetDirectoryReference(folderName);
        //    //    downloadDir.CreateIfNotExists();

        //    //    if (downloadDir.Exists())
        //    //    {
        //    //        var ms = new MemoryStream();
        //    //        await formFile.CopyToAsync(ms);

        //    //        var uniqueFileName = GetUniqueFileName(Path.GetFileName(formFile.FileName));
        //    //        var cloudFile = downloadDir.GetFileReference(uniqueFileName);

        //    //        azBlobFileName = cloudFile.Uri.AbsolutePath;
        //    //        await cloudFile.UploadFromStreamAsync(ms);
        //    //    }
        //    //}
        //    return azBlobFileName;
        //}

        //public static async Task<byte[]> ReadFileFromBlob(string path, IConfiguration configuration)
        //{
        //    var connStringHotBlob = configuration.GetSection("Services").Get<List<ServiceConfig>>()
        //                                         .FirstOrDefault(x => x.Active && x.CloudStorageConnStr != null)?
        //                                         .CloudStorageConnStr;

        //    if (string.IsNullOrEmpty(connStringHotBlob))
        //    {
        //        return null;
        //    }
        //    var storageAccount = CloudStorageAccount.Parse(connStringHotBlob);

        //    // Create a CloudFileClient object for credentialed access to Azure Files.
        //    CloudFileClient fileClient = storageAccount.CreateCloudFileClient();
        //    // Get a reference to the file share we created previously.
        //    CloudFileShare share = fileClient.GetShareReference("invitationattachments");
        //    byte[] fileArray = null;
        //    // Ensure that the share exists.
        //    if (share.Exists())
        //    {
        //        // Get a reference to the root directory for the share.
        //        CloudFileDirectory rootDir = share.GetRootDirectoryReference();

        //        // Get a reference to the directory we created previously.
        //        CloudFileDirectory sampleDir = rootDir.GetDirectoryReference("June_2020");
        //        var x = Path.GetFileName(WebUtility.UrlDecode("/invitationattachments/June_2020/Pixel4%20White-%20small_d2f609ee-27ea-456d-860c-500fa64b43d9.png"));
        //        var y = Path.GetDirectoryName(WebUtility.UrlDecode("/invitationattachments/June_2020/Pixel4%20White-%20small_d2f609ee-27ea-456d-860c-500fa64b43d9.png"));
        //        CloudFileDirectory sampleDir2 = rootDir.GetDirectoryReference(y);
        //        // Ensure that the directory exists.
        //        if (sampleDir.Exists())
        //        {
        //            // Get a reference to the file we created previously.
        //            CloudFile file = sampleDir2.GetFileReference(WebUtility.UrlDecode("Pixel4%20White-%20small_d2f609ee-27ea-456d-860c-500fa64b43d9.png"));

        //            // Ensure that the file exists.
        //            if (file.Exists())
        //            {

        //                // Write the contents of the file to the console window.
        //                file.DownloadToByteArray(fileArray,0);
        //            }
        //        }
        //    }
        //    return fileArray;
        //}

        public static Stream ReadFileToStreamFromBlob(string path, bool fromPrivateStorage = false)
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }
            var connStringHotBlob = fromPrivateStorage ?
                                    AppSettingsConfiguration.GetB2BPrivateWebUploadsCloudStorageConnstr() :
                                    AppSettingsConfiguration.GetB2BWebUploadsCloudStorageConnstr();
            var ms = new MemoryStream();

            if (string.IsNullOrEmpty(connStringHotBlob))
            {
                return null;
            }
            var storageAccount = CloudStorageAccount.Parse(connStringHotBlob);

            // Create a CloudFileClient object for credentialed access to Azure Files.
            CloudFileClient fileClient = storageAccount.CreateCloudFileClient();
            // Get a reference to the file share we created previously.
            string[] pathComponents = path.Split('/');
            if (pathComponents.Length < 4)
            {
                return ms;
            }
            CloudFileShare share = fileClient.GetShareReference(pathComponents[1].ToLower());
            // Ensure that the share exists.
            if (share.Exists())
            {
                // Get a reference to the root directory for the share.
                CloudFileDirectory rootDir = share.GetRootDirectoryReference();

                // Get a reference to the directory we created previously.
                CloudFileDirectory sampleDir = rootDir.GetDirectoryReference(pathComponents[2]);
                // Ensure that the directory exists.
                if (sampleDir.Exists())
                {
                    // Get a reference to the file we created previously.
                    CloudFile file = sampleDir.GetFileReference(WebUtility.UrlDecode(pathComponents[3]));

                    // Ensure that the file exists.
                    if (file.Exists())
                    {
                        // Write the contents of the file to the console window.
                        file.DownloadToStream(ms);
                        ms.Position = 0;
                    }
                }
            }
            return ms;
        }

        public static byte[] ReadFileToByteArrayFromBlob(string path, IConfiguration configuration)
        {
            //var connStringHotBlob = configuration.GetSection("Services").Get<List<ServiceConfig>>()
            //                                     .FirstOrDefault(x => x.Active && x.CloudStorageConnStr != null)?
            //                                     .CloudStorageConnStr;
            var connStringHotBlob = AppSettingsConfiguration.GetB2BWebUploadsCloudStorageConnstr();
            if (string.IsNullOrEmpty(connStringHotBlob))
            {
                return null;
            }
            var storageAccount = CloudStorageAccount.Parse(connStringHotBlob);

            // Create a CloudFileClient object for credentialed access to Azure Files.
            CloudFileClient fileClient = storageAccount.CreateCloudFileClient();
            // Get a reference to the file share we created previously.
            string[] pathComponents = path.Split('/');
            if (pathComponents.Length < 4)
            {
                return null;
            }
            CloudFileShare share = fileClient.GetShareReference(pathComponents[1].ToLower());
            // Ensure that the share exists.
            Byte[] fileArray = null;
            if (share.Exists())
            {
                // Get a reference to the root directory for the share.
                CloudFileDirectory rootDir = share.GetRootDirectoryReference();

                // Get a reference to the directory we created previously.
                CloudFileDirectory sampleDir = rootDir.GetDirectoryReference(pathComponents[2]);
                // Ensure that the directory exists.
                if (sampleDir.Exists())
                {
                    // Get a reference to the file we created previously.
                    CloudFile file = sampleDir.GetFileReference(WebUtility.UrlDecode(pathComponents[3]));

                    // Ensure that the file exists.
                    if (file.Exists())
                    {
                        long fileByteLength = file.Properties.Length;
                        fileArray = new Byte[fileByteLength];
                        // Write the contents of the file to the console window.
                        file.DownloadToByteArray(fileArray, 0);
                    }
                }
            }
            return fileArray;
        }

        public static int RemoveFileFromBlob(string path, bool fromPrivateStorage = false)
        {
            var connStringHotBlob = fromPrivateStorage ?
                                    AppSettingsConfiguration.GetB2BPrivateWebUploadsCloudStorageConnstr() :
                                    AppSettingsConfiguration.GetB2BWebUploadsCloudStorageConnstr();
            if (string.IsNullOrEmpty(connStringHotBlob))
            {
                return 0;
            }
            var storageAccount = CloudStorageAccount.Parse(connStringHotBlob);

            // Create a CloudFileClient object for credentialed access to Azure Files.
            CloudFileClient fileClient = storageAccount.CreateCloudFileClient();
            // Get a reference to the file share we created previously.
            string[] pathComponents = path.Split('/');
            if (pathComponents.Length < 4)
            {
                return 0;
            }
            CloudFileShare share = fileClient.GetShareReference(pathComponents[1].ToLower());
            var fileDeleted = 0;
            // Ensure that the share exists.
            if (share.Exists())
            {
                // Get a reference to the root directory for the share.
                CloudFileDirectory rootDir = share.GetRootDirectoryReference();

                // Get a reference to the directory we created previously.
                CloudFileDirectory sampleDir = rootDir.GetDirectoryReference(pathComponents[2]);
                // Ensure that the directory exists.
                if (sampleDir.Exists())
                {
                    // Get a reference to the file we created previously.
                    CloudFile file = sampleDir.GetFileReference(WebUtility.UrlDecode(pathComponents[3]));

                    // Ensure that the file exists.
                    if (file.Exists())
                    {
                        try
                        {
                            file.Delete();
                            fileDeleted++;
                        }
                        catch (Exception)
                        {
                            fileDeleted = 0;
                        }
                    }
                }
            }
            return fileDeleted;
        }

        [ExcludeFromCodeCoverage]
        private static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString()
                      + Path.GetExtension(fileName).ToLower();
        }

        public static string GetFileNameFrom(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            fileName = fileName.Substring(0, fileName.LastIndexOf("_")) + Path.GetExtension(fileName).ToLower();
            return fileName;
        }
    }
}
