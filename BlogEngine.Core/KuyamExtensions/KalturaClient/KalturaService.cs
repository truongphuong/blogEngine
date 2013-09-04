using System;
using System.IO;
using Kaltura;

namespace BlogEngine.Core.KuyamExtensions.KalturaClient
{
    /// <summary>
    /// Kaltura Service
    /// </summary>
    public static class KalturaService
    {
        /// <summary>
        /// 
        /// </summary>
        public static void SampleMetadataOperations()
        {
           
            var client = new Kaltura.KalturaClient(GetConfig());

            // start new session (client session is enough when we do operations in a users scope)
            string ks = client.SessionService.Start(KalturaConfigManager.Kulturaadminsecret, KalturaConfigManager.Kulturauserid, KalturaSessionType.ADMIN, KalturaConfigManager.Kulturapartnerid, 86400, "");
            client.KS = ks;

            // Setup a pager and search to use
            var  pager = new KalturaFilterPager();
            var search = new KalturaMediaEntryFilter
                {
                    OrderBy = KalturaMediaEntryOrderBy.CREATED_AT_ASC,
                    MediaTypeEqual = KalturaMediaType.VIDEO
                };
            pager.PageSize = 10;
            pager.PageIndex = 1;

            Console.WriteLine("List videos, get the first one...");

            // Get 10 video entries, but we'll just use the first one returned
            var entries = client.MediaService.List(search, pager).Objects;
            // Check if there are any custom fields defined in the KMC (Settings -> Custom Data)
            // for the first item returned by the previous listaction
            var filter = new KalturaMetadataProfileFilter();
            var metadata = client.MetadataProfileService.List(filter, pager).Objects;
            var profileId = metadata[0].Id;
            var name = entries[0].Name;
            var id = entries[0].Id;
            if (metadata[0].Xsd != null)
            {
                Console.WriteLine("1. There are custom fields for video: " + name + ", entryid: " + id);
            }
            else
            {
                Console.WriteLine("1. There are no custom fields for video: " + name + ", entryid: " + id);
            }
            // Add a custom data entry in the KMC  (Settings -> Custom Data)
            var profile = new KalturaMetadataProfile {MetadataObjectType = KalturaMetadataObjectType.ENTRY};
            const string viewsData = "";

            var fileStream = File.OpenText(KalturaConfigManager.XsdFile);
            var xsd = fileStream.ReadToEnd();
            var metadataResult = client.MetadataProfileService.Update(profileId, profile, xsd, viewsData);

            if (metadataResult.Xsd != null)
            {
                Console.WriteLine("2. Successfully created the custom data field " + KalturaConfigManager.MetaDataFieldName + ".");
            }
            else
            {
                Console.WriteLine("2. Failed to create the custom data field.");
            }

            // Add the custom metadata value to the first video
            var filter2 = new KalturaMetadataFilter();
            filter2.ObjectIdEqual = entries[0].Id;
            const string xmlData = "<metadata><SubtitleFormat>" + KalturaConfigManager.FieldValue + "</SubtitleFormat></metadata>";
            var metadata2 = client.MetadataService.Add(profileId, profile.MetadataObjectType, entries[0].Id, xmlData);

            if (metadata2.Xml != null)
            {
                Console.WriteLine("3. Successfully added the custom data field for video: " + name + ", entryid: " + id);
                var xmlStr = metadata2.Xml;
                Console.WriteLine("XML used: " + xmlStr);
            }
            else
            {
                Console.WriteLine("3. Failed to add the custom data field.");
            }

            // Now lets change the value (update) of the custom field
            // Get the metadata for the video
            var filter3 = new KalturaMetadataFilter {ObjectIdEqual = entries[0].Id};
            var metadataList = client.MetadataService.List(filter3).Objects;
            if (metadataList[0].Xml != null)
            {
                Console.WriteLine("4. Current metadata for video: " + name + ", entryid: " + id);
                var xmlquoted = metadataList[0].Xml;
                Console.WriteLine("XML: " + xmlquoted);
                var xml = metadataList[0].Xml;
                // Make sure we find the old value in the current metadata
                var pos = xml.IndexOf("<" + KalturaConfigManager.MetaDataFieldName + ">" + KalturaConfigManager.FieldValue + "</" + KalturaConfigManager.MetaDataFieldName + ">", StringComparison.Ordinal);
                if (pos == -1)
                {
                    Console.WriteLine("4. Failed to find metadata STRING for video: " + name + ", entryid: " + id);
                }
                else
                {
                    var pattern = new System.Text.RegularExpressions.Regex("@<" + KalturaConfigManager.MetaDataFieldName + ">(.+)</" + KalturaConfigManager.MetaDataFieldName + ">@");
                    xml = pattern.Replace(xml, "<" + KalturaConfigManager.MetaDataFieldName + ">Ogg Writ</" +KalturaConfigManager.MetaDataFieldName + ">");
                    var rc = client.MetadataService.Update(metadataList[0].Id, xml);
                    Console.WriteLine("5. Updated metadata for video: " + name + ", entryid: " + id);
                    xmlquoted = rc.Xml;
                    Console.WriteLine("XML: " + xmlquoted);
                }
            }
            else
            {
                Console.WriteLine("4. Failed to find metadata for video: " + name + ", entryid: " + id);
            }
        }

        /// <summary>
        /// Shows how to start session and upload media from a local file server
        /// </summary>
        /// <param name="fileStream"></param>
        /// <param name="mediaType"></param>
        /// <param name="name"></param>
        public static KalturaMediaEntry StartSessionAndUploadMedia(FileStream fileStream, KalturaMediaType mediaType, string name)
        {
            var client = new Kaltura.KalturaClient(GetConfig());

            // start new session (client session is enough when we do operations in a users scope)
            var ks = client.SessionService.Start(KalturaConfigManager.Kulturasecret,KalturaConfigManager.Kulturauserid, KalturaSessionType.USER,KalturaConfigManager.Kulturapartnerid, 86400, "");
            client.KS = ks;

            // upload the media
            var uploadTokenId = client.MediaService.Upload(fileStream); // synchronous proccess
            var mediaEntry = new KalturaMediaEntry();
            mediaEntry.Name = name;
            mediaEntry.MediaType = mediaType;
            // add the media using the upload token
            mediaEntry = client.MediaService.AddFromUploadedFile(mediaEntry, uploadTokenId);

            return mediaEntry;
        }

        /// <summary>
        /// Shows how to start session and upload media from a local file server
        /// </summary>
        /// <param name="fileStream"></param>
        /// <param name="mediaType"></param>
        /// <param name="name"></param>
        public static KalturaBulkUpload StartSessionBulkUploadAddMedia(FileStream fileStream, KalturaMediaType mediaType, string name)
        {
            var client = new Kaltura.KalturaClient(GetConfig());

            // start new session (client session is enough when we do operations in a users scope)
            var ks = client.SessionService.Start(KalturaConfigManager.Kulturasecret, KalturaConfigManager.Kulturauserid, KalturaSessionType.USER, KalturaConfigManager.Kulturapartnerid, 86400, "");
            client.KS = ks;
            //return mediaEntry;
            return null;
        }

        /// <summary>
        /// Shows how to start session and upload media from a web accessible server
        /// </summary>
        public static void StartSessionAndUploadMedia(Uri url)
        {
            var client = new Kaltura.KalturaClient(GetConfig());

            // start new session (client session is enough when we do operations in a users scope)
            var ks = client.SessionService.Start(KalturaConfigManager.Kulturasecret, KalturaConfigManager.Kulturauserid, KalturaSessionType.USER, KalturaConfigManager.Kulturapartnerid, 86400, "");
            client.KS = ks;

            var mediaEntry = new KalturaMediaEntry();
            mediaEntry.Name = "Media Entry Using .Net Client";
            mediaEntry.MediaType = KalturaMediaType.VIDEO;

            // add the media using the upload token
            mediaEntry = client.MediaService.AddFromUrl(mediaEntry, url.ToString());

            Console.WriteLine("New media was created with the following id: " + mediaEntry.Id);
        }

        /// <summary>
        /// Simple multi request example showing how to start session and list media in a single HTTP request
        /// </summary>
        public static void MultiRequestExample()
        {
            var client = new Kaltura.KalturaClient(GetConfig());

            client.StartMultiRequest();

            client.SessionService.Start(KalturaConfigManager.Kulturasecret, KalturaConfigManager.Kulturauserid, KalturaSessionType.USER, KalturaConfigManager.Kulturapartnerid, 86400, "");
            client.KS = "{1:result}"; // for the current multi request, the result of the first call will be used as the ks for next calls

            var filter = new KalturaMediaEntryFilter();
            filter.OrderBy = KalturaMediaEntryOrderBy.CREATED_AT_DESC;
            client.MediaService.List(filter, new KalturaFilterPager());

            var response = client.DoMultiRequest();

            // in multi request, when there is an error, an exception is NOT thrown, so we should check manually
            if (response[1].GetType() == typeof(KalturaAPIException))
            {
                Console.WriteLine("Error listing media " + ((KalturaAPIException)response[1]).Message);

                // we can throw the exception if we want
                //throw (KalturaAPIException)response[1]; 
            }
            else
            {
                var mediaList = (KalturaMediaListResponse)response[1];
                Console.WriteLine("Total media entries: " + mediaList.TotalCount);
                foreach (var mediaEntry in mediaList.Objects)
                {
                    Console.WriteLine("Media Name: " + mediaEntry.Name);
                }
            }
        }

        /// <summary>
        /// Shows how to start session, create a mix, add media, and append it to a mix timeline using multi request
        /// </summary>
        //private static void AdvancedMultiRequestExample(FileStream fileStream)
        //{
        //    var client = new Kaltura.KalturaClient(GetConfig());

        //    client.StartMultiRequest();

        //    // Request 1
        //    client.SessionService.Start(KalturaConfigManager.Kulturasecret, KalturaConfigManager.Kulturauserid, KalturaSessionType.USER, KalturaConfigManager.Kulturapartnerid, 86400, "");
        //    client.KS = "{1:result}"; // for the current multi request, the result of the first call will be used as the ks for next calls

        //    var mixEntry = new KalturaMixEntry();
        //    mixEntry.Name = ".Net Mix";
        //    mixEntry.EditorType = KalturaEditorType.SIMPLE;

        //    // Request 2
        //    client.MixingService.Add(mixEntry);

        //    // Request 3
        //    client.MediaService.Upload(fileStream);

        //    var mediaEntry = new KalturaMediaEntry {Name = "Media Entry For Mix", MediaType = KalturaMediaType.VIDEO};

        //    // Request 4
        //    client.MediaService.AddFromUploadedFile(mediaEntry, "");

        //    // Request 5
        //    client.MixingService.AppendMediaEntry("", "");

        //    // Map request 3 result to request 4 uploadTokeId param
        //    client.MapMultiRequestParam(3, 4, "uploadTokenId");

        //    // Map request 2 result.id to request 5 mixEntryId
        //    client.MapMultiRequestParam(2, "id", 5, "mixEntryId");

        //    // Map request 4 result.id to request 5 mediaEntryId
        //    client.MapMultiRequestParam(4, "id", 5, "mediaEntryId");

        //    var response = client.DoMultiRequest();

        //    foreach (var obj in response)
        //    {
        //        if (obj.GetType() == typeof(KalturaAPIException))
        //        {
        //            Console.WriteLine("Error occurred: " + ((KalturaAPIException)obj).Message);
        //        }
        //    }

        //    // when accessing the response object we will use an index and not the response number (response number - 1)
        //    if (response[1].GetType() != typeof (KalturaMixEntry)) return;
        //    mixEntry = (KalturaMixEntry)response[1];
        //    Console.WriteLine("The new mix entry id is: " + mixEntry.Id);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entryId"></param>
        /// <returns></returns>
        public static KalturaMediaEntry GetKalturaMediaEntry(string entryId)
        {
            var client = new Kaltura.KalturaClient(GetConfig());
            return client.MediaService.Get(entryId);
        }

        private static KalturaConfiguration GetConfig()
        {
            var config = new KalturaConfiguration(KalturaConfigManager.Kulturapartnerid);
            config.ServiceUrl = KalturaConfigManager.Kulturaserviceurl;
            return config;
        }
    }
}
