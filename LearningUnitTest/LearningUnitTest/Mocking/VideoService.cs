using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LearningUnitTest.Mocking
{
    public class VideoService
    {
        private readonly IFileReader _fileReader;

        public VideoService(IFileReader fileReader = null)
        {
            _fileReader = fileReader ?? new FileReader();
        }
  
        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAcCsv()
        {
            var videoIds = new List<int>();

            using (var context = new VideoContext()) {
                var videos =
                    (from video in context.Videos
                        where !video.IsProcessed
                        select video).ToList();
                videoIds.AddRange(videos.Select(v => v.Id));

                return String.Join(",", videoIds);
            }
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}