using System;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Mvc;

namespace HotelDotNet.Utility
{
	public class Utility
	{
        public async Task<IFormFile> UploadFileToS3(IFormFile file)
        {
            using (var amazonS3Client = new AmazonS3Client("AKIA6KTTLEAA7AAEM77A", ""))
            {
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    var request = new TransferUtilityUploadRequest
                    {
                        InputStream = memoryStream,
                        Key = file.FileName,
                        BucketName = "",
                        ContentType = file.ContentType

                    };
                    var transferUtility = new TransferUtility(amazonS3Client);
                    await transferUtility.UploadAsync(request);
                }
            }

            return file;
        }
    }
}

