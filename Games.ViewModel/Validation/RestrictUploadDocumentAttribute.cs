using Games.Common.Resources;
using Games.ViewModel.MVC;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;

namespace Games.ViewModel.Validation
{
    public class RestrictUploadDocumentAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext.ObjectInstance is RetailerEditViewModel)
            {
                return ValidationResult.Success; //ValidateRetailerGetViewModel((RetailerEditViewModel)validationContext.ObjectInstance);
            }
            else if (validationContext.ObjectInstance is CreateAlertViewModel)
            {
                return ValidationResult.Success; //ValidateCreateAlertViewModel((CreateAlertViewModel)validationContext.ObjectInstance);
            }
            else if (validationContext.ObjectInstance is CreateConfigureHeroBannerViewModel)
            {
                return ValidationResult.Success;//ValidateCreateConfigureHeroBannerViewModel((CreateConfigureHeroBannerViewModel)validationContext.ObjectInstance);
            }
            else if (validationContext.ObjectInstance is CreateReportIssueViewModel)
            {
                return ValidationResult.Success; //ValidateCreateReportIssueViewModel((CreateReportIssueViewModel)validationContext.ObjectInstance);
            }
            else if (validationContext.ObjectInstance is CreateEmailBlastViewModel)
            {
                return ValidationResult.Success; //ValidateCreateEmailBlastViewModel((CreateEmailBlastViewModel)validationContext.ObjectInstance);
            }

            var error = string.Empty;
            var upload = (UploadDocumentViewModel)validationContext.ObjectInstance;
            if (upload.Document != null)
            {
                var ext = GetUploadDocumentType(upload.Document);
                switch (upload.Name)
                {
                    case "pad_form":
                        break;
                    case "insurance_document":
                        break;
                    case "rsa_certificate":
                    case "crol_license":
                    case "store_logo":
                        if (ext != null && ext.ToLower() != upload.FileType)
                        {
                            error = string.Format(CommonResources.UploadDocumentTypeShouldBe, upload.FileType);
                        }
                        if (upload.Name == "store_logo")
                        {
                            var valerr = ValidateImage(upload);
                            if (!string.IsNullOrEmpty(valerr))
                            {
                                error = string.Format("{0}~{1}", error, valerr);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                error = CommonResources.DocumentRequired;
            }
            if (string.IsNullOrEmpty(error))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(error.Trim('~').Replace("~", "<br/>"));
            }
        }

        private string GetUploadDocumentType(IFormFile file)
        {
            return Path.GetExtension(file.FileName);
        }

        private string ValidateImage(UploadDocumentViewModel upload)
        {
            var stream = upload.Document.OpenReadStream();
            var img = new Bitmap(stream);
            var width = img.Width;
            var resolutionx = img.HorizontalResolution;
            var resolutiony = img.VerticalResolution;

            var error = string.Empty;
            if (width > upload.ImageSize)
            {
                error = string.Format(CommonResources.ImageWidthShouldNotBeGreaterThan, upload.ImageSize);
            }
            if (resolutionx < upload.ImageResolution)
            {
                if (string.IsNullOrEmpty(error))
                {
                    error = string.Format(CommonResources.ImageResolutionShouldNotBeLessThan, upload.ImageResolution);
                }
                else
                {
                    error = string.Format("{0}~{1}", error, string.Format(CommonResources.ImageResolutionShouldNotBeLessThan, upload.ImageResolution));
                }
            }
            if (resolutiony < upload.ImageResolution)
            {
                if (string.IsNullOrEmpty(error))
                {
                    error = string.Format(CommonResources.ImageResolutionShouldNotBeLessThan, upload.ImageResolution);
                }
                else
                {
                    error = string.Format("{0}~{1}", error, string.Format(CommonResources.ImageResolutionShouldNotBeLessThan, upload.ImageResolution));
                }
            }
            return error;
        }

        private ValidationResult ValidateRetailerGetViewModel(RetailerEditViewModel retailerVm)
        {
            var error = string.Empty;

            if (retailerVm.LogoUpload != null)
            {
                if (!retailerVm.LogoUpload.ContentType.EndsWith("/png"))
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image not of type png.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image not of type png.");
                    }
                }

                var stream = retailerVm.LogoUpload.OpenReadStream();
                var img = new Bitmap(stream);
                var width = img.Width;
                var height = img.Height;
                var mb = stream.Length / 1000000;

                if (width < retailerVm.LogoImageMinSize || width > retailerVm.LogoImageMaxSize)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image width not within scope.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image width not within scope.");
                    }
                }
                if (height < retailerVm.LogoImageMinSize || height > retailerVm.LogoImageMaxSize)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image height not within scope.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image height not within scope.");
                    }
                }
                if (mb > retailerVm.LogoImageFileMaxSize)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image file too big.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image file too big.");
                    }
                }
            }

            if (string.IsNullOrEmpty(error))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(error.Trim('~').Replace("~", "<br/>"));
            }
        }

        private ValidationResult ValidateCreateAlertViewModel(CreateAlertViewModel bannerVm)
        {
            var error = string.Empty;
            if (bannerVm.IconFile != null)
            {
                var stream = bannerVm.IconFile.OpenReadStream();
                var img = new Bitmap(stream);
                var width = img.Width;
                var height = img.Height;
                var mb = stream.Length / 1000000;

                if (width < 40 || width > 160)
                {
                    error = "Image width not with scope.";
                }
                if (height < 40 || height > 160)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image height not with scope.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image height not with scope.");
                    }
                }
                if (mb > 25)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image file too big.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image file too big.");
                    }
                }
            }

            if (string.IsNullOrEmpty(error))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(error.Trim('~').Replace("~", "<br/>"));
            }
        }

        private ValidationResult ValidateCreateConfigureHeroBannerViewModel(CreateConfigureHeroBannerViewModel bannerVm)
        {
            var error = string.Empty;
            if (bannerVm.IconFile != null)
            {
                var stream = bannerVm.IconFile.OpenReadStream();
                var img = new Bitmap(stream);
                var width = img.Width;
                var height = img.Height;
                var mb = stream.Length / 1000000;

                if (width < 150 || width > 600)
                {
                    error = "Image width not with scope.";
                }
                if (height < 150 || height > 600)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image height not with scope.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image height not with scope.");
                    }
                }
                if (mb > 25)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image file too big.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image file too big.");
                    }
                }
            }
            //else
            //{
            //    error = "Image file is required.";
            //}

            if (string.IsNullOrEmpty(error))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(error.Trim('~').Replace("~", "<br/>"));
            }
        }

        private ValidationResult ValidateCreateReportIssueViewModel(CreateReportIssueViewModel bannerVm)
        {
            var error = string.Empty;
            if (bannerVm.IconFile != null)
            {
                var stream = bannerVm.IconFile.OpenReadStream();
                var img = new Bitmap(stream);
                var width = img.Width;
                var height = img.Height;
                var mb = stream.Length / 1000000;

                if (width < 150 || width > 600)
                {
                    error = "Image width not with scope.";
                }
                if (height < 150 || height > 600)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image height not with scope.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image height not with scope.");
                    }
                }
                if (mb > 25)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image file too big.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image file too big.");
                    }
                }
            }
            //else
            //{
            //    error = "Image file is required.";
            //}

            if (string.IsNullOrEmpty(error))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(error.Trim('~').Replace("~", "<br/>"));
            }
        }

        private ValidationResult ValidateCreateEmailBlastViewModel(CreateEmailBlastViewModel bannerVm)
        {
            var error = string.Empty;
            if (bannerVm.IconFile != null)
            {
                var stream = bannerVm.IconFile.OpenReadStream();
                var img = new Bitmap(stream);
                var width = img.Width;
                var height = img.Height;
                var mb = stream.Length / 1000000;

                //if (width < 150 || width > 600)
                //{
                //    error = "Image width not with scope.";
                //}
                //if (height < 150 || height > 600)
                //{
                //    if (string.IsNullOrEmpty(error))
                //    {
                //        error = "Image height not with scope.";
                //    }
                //    else
                //    {
                //        error = string.Format("{0}~{1}", error, "Image height not with scope.");
                //    }
                //}
                if (mb > 20)
                {
                    if (string.IsNullOrEmpty(error))
                    {
                        error = "Image file too big.";
                    }
                    else
                    {
                        error = string.Format("{0}~{1}", error, "Image file too big.");
                    }
                }
            }

            if (string.IsNullOrEmpty(error))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(error.Trim('~').Replace("~", "<br/>"));
            }
        }
    }
}
