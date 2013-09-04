using System.Collections.Generic;
using System.Linq;
using BlogEngine.Core.KuyamExtensions.KalturaClient;
using BlogEngine.GettyImagesClient.Domain;
using BlogEngine.GettyImagesClient.Services;
using System.IO;
using System.Net;
using System;
using Kaltura;
using BlogEngine.Core.Providers;

namespace BlogEngine.Core.KuyamExtensions.Json
{
    /// <summary>
    /// Getty images API
    /// </summary>
    public class GettyImages
    {

        #region Getty Imges API

        /// <summary>
        /// Get image detail by api
        /// </summary>
        /// <param name="token">string: token</param>
        /// <param name="imageIds">List image id as string.</param>
        /// <returns>GetImageDetails</returns>
        public GetImageDetailsResult GetImageDetails(string token, List<string> imageIds){
            var imageDetail = new ImageDetail();
            var getImageDetailsResponse = imageDetail.GetImageDetails(token, imageIds);

            return getImageDetailsResponse != null ? getImageDetailsResponse.GetImageDetailsResult : null;
        }

        /// <summary>
        /// Create session for getty images api
        /// </summary>
        /// <returns>CreateSessionResult</returns>
        private static CreateSessionResult CreateSession(){
            var session = new CreateSession();
            var createSessionTokenResponse = session.GetCreateSessionResponse();
            return createSessionTokenResponse != null ? createSessionTokenResponse.CreateSessionResult : null;
        }

        /// <summary>
        /// Get images detail by key
        /// </summary>
        /// <param name="key">string: key</param>
        /// <returns>GetImageDetailsResult</returns>
        public GetImageDetailsResult GetImageDetails(string key){
            var createSessionResult = CreateSession();
            var searchForCreativeImage = new SearchForCreativeImages();
            var imageIds = new List<string>();

            if (createSessionResult != null)
            {
                var token = createSessionResult.Token;
                var searchForImagesResult = searchForCreativeImage.Search(token, key).SearchForImagesResult;
                if (searchForImagesResult != null)
                {
                    imageIds = searchForImagesResult.Images.Select(m => m.ImageId).ToList();
                }

                return GetImageDetails(token, imageIds);
            }
            return null;
        }

        /// <summary>
        /// Create download request by image list
        /// </summary>
        /// <param name="images">image list</param>
        /// <returns>CreateDownloadRequestResult</returns>
        public CreateDownloadRequestResult CreateDownload(List<Image> images){
            var session = CreateSession();
            if (session != null)
            {
                var token = session.Token;

                var secureToken = session.SecureToken;

                var createDownload = new CreateDownloadRequests();

                var downImageList = new GetLargestImageDownloadAuthorizations();
                var imageAuth = downImageList.GetLargestDownloadForImages(token, images).GetLargestImageDownloadAuthorizationsResult.Images;

                var downloadItems = imageAuth.Select(item =>
                {
                    var firstOrDefault = item.Authorizations.FirstOrDefault();
                    return firstOrDefault != null ? new DownloadItem
                    {
                        DownloadToken = firstOrDefault.DownloadToken
                    } : null;
                }).ToList();

                var createDownloadResponse = createDownload.CreateRequest(secureToken, downloadItems);
                return createDownloadResponse != null ? createDownloadResponse.CreateDownloadRequestResult : null;
            }
            return null;
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Delete file from the server
        /// </summary>
        /// <param name="fullPath"></param>
        public void DeleteFile(string fullPath){
            var filePath = fullPath;
            if (File.Exists(filePath)){
                File.Delete(filePath);
            }
        }

        /// <summary>
        /// Download image from sever
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="imageName"></param>
        /// <returns></returns>
        public string DownloadImage(string uri, string imageName){
            var fullPath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UploadMedia/"), imageName);
            try{

                var client = new WebClient();
                client.DownloadFile(uri, fullPath);
                return fullPath;
            }
            catch (Exception){
                //log error here
                return string.Empty;
            }
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// Get all Getty Images by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<GettyImage> GetGettyImages(string key){
            var imageResults = GetImageDetails(key);

            return imageResults==null ? null : imageResults.Images.Select(CreateJsonGettyImage).ToList();

            // convert each blog into smaller Json friendly object 
        }

        /// <summary>
        /// Converts the Getty images data into a JSON-serializable object.
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static GettyImage CreateJsonGettyImage(Image img){
            var ji = new GettyImage{
                Id = img.ImageId,
                Title = img.Title,
                Tags = img.ImageFamily,
                UrlThumb = img.UrlThumb,
                UrlPreview = img.UrlPreview
            };

            return ji;
        }

        /// <summary>
        /// Converts the Getty images data into a JSON-serializable object.
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static GettyImage CreateJsonGettyImageClient(GettyImage img)
        {
            var ji = new GettyImage
            {
                Id = img.Id,
                GettyImageId = img.GettyImageId,
                Title = img.Title,
                Tags = img.Tags,
                UrlThumb = img.UrlThumb,
                UrlPreview = img.UrlPreview
            };

            return ji;
        }

        /// <summary>
        /// Upload image to Kaltural
        /// </summary>
        /// <param name="gettyImage"></param>
        /// <returns></returns>
        public string UploadToKaltural(GettyImage gettyImage){
            try{

                //Upload to kaltural
                var fullPath = DownloadImage(gettyImage.UrlPreview, string.Format("{0}{1}.jpg", gettyImage.UserId, gettyImage.Id));
                var fileName = string.Format("{0}{1}_{2}", gettyImage.UserId, gettyImage.Id, DateTime.UtcNow.ToString("ddMMyyyyhmmss"));
                var fileStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                var kalturaMediaEntry= KalturaService.StartSessionAndUploadMedia(fileStream, KalturaMediaType.IMAGE, fileName);

                fileStream.Flush();
                fileStream.Close();
                DeleteFile(fullPath);

                return kalturaMediaEntry.Id;
            }
            catch (Exception){
                //Write log here
                //LogHelper.Error("Save image is fail: ", ex);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<GettyImage> LoadGetttyImagesClient(int userId)
        {
            var imageResults = BlogService.GetAllGettyImagesByCustId(userId);

            // convert each blog into smaller Json friendly object 
            return imageResults.Select(CreateJsonGettyImageClient).ToList();
        }

        /// <summary>
        /// Insert Gettty Images Client
        /// </summary>
        /// <param name="gettyImage"></param>
        /// <returns></returns>
        public int InsertGetttyImagesClient(GettyImage gettyImage)
        {
            var imageResults = BlogService.InsertGettyImages(gettyImage);
            return imageResults;
        }

        /// <summary>
        /// GetUserIdByEmail
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public int GetUserIdByEmail(string email)
        {
            return BlogService.GetUserIdByEmail(email);
        }

        #endregion

    }
}
