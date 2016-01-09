namespace SubtitleMover.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SubMover
    {
        private const string episodeFindPattern = "(s|S)+[0-9]+(e|E)[+[0-9]+";
        private string workFodler;

        public SubMover(string workFodler)
        {
            this.workFodler = workFodler;
        }

        public Response MoveSubtitlesToDirectories()
        {
            var response = new Response();
            var subtitles = new List<string>();
            try
            {
                subtitles = Directory.GetFiles(this.workFodler, "*.*").Where(s => IsSubtitles(s)).ToList();
            }
            catch (DirectoryNotFoundException)
            {
                response.HasMoved = false;
                response.Message = "The directory you gave me isn't correct!";
                return response;
            }
            var directories = new List<string>();
            try
            {
                directories = Directory.GetDirectories(this.workFodler).ToList();
            }
            catch (DirectoryNotFoundException)
            {
                response.HasMoved = false;
                response.Message = "The directory you gave me isn't correct!";
                return response;
            }

            var foundItemsAreValid = FoundSubsAndDirs(subtitles, directories);
            if (foundItemsAreValid.Length != 0)
            {
                response.HasMoved = false;
                response.Message = foundItemsAreValid;
                return response;
            }

            foreach (var sub in subtitles)
            {
                var subEpisode = Regex.Match(sub, episodeFindPattern);

                foreach (var dir in directories)
                {
                    if (dir.Contains(subEpisode.ToString()))
                    {
                        response.Count++;
                        var videoNameWholePath = Directory.GetFiles(dir).Select(x => x).Where(x => IsVideoFile(x)).FirstOrDefault();
                        if (videoNameWholePath == null)
                        {
                            response.Message = "No videos were found";
                            response.HasMoved = false;
                            return response;
                        }
                        response.FoundSubs = true;
                        var range = videoNameWholePath.LastIndexOf(".avi");
                        var subsName = RenameSubtitles(videoNameWholePath);
                        File.Move(sub, dir + "\\" + subsName);
                    }
                }
            }
            if (response.FoundSubs == false)
            {
                response.HasMoved = false;
                response.Message = "Not a single matching episode was found!";
                return response;
            }
            if (response.Count != 0)
            {
                response.HasMoved = true;
            }

            return response;
        }

        public Response MoveVideosToMainDirectory()
        {
            var response = new Response();
            
            var directories = new List<string>();
            try
            {
                directories = Directory.GetDirectories(this.workFodler).ToList();
            }
            catch (DirectoryNotFoundException)
            {
                response.HasMoved = false;
                response.Message = "The directory you gave me isn't correct!";
                return response;
            }
            var subtitles = new List<string>();
            try
            {
                 subtitles = Directory.GetFiles(this.workFodler, "*.*").Where(s => s.EndsWith(".srt") || s.EndsWith(".sub")).ToList();

            }
            catch (DirectoryNotFoundException)
            {
                response.HasMoved = false;
                response.Message = "The directory you gave me isn't correct!";
                return response;
            }

            var foundItemsAreValid = FoundSubsAndDirs(subtitles, directories);
            if (foundItemsAreValid.Length != 0)
            {
                response.HasMoved = false;
                response.Message = foundItemsAreValid;
                return response;
            }

            foreach (var dir in directories)
            {
                var videoFile = Directory.GetFiles(dir, "*.*").Where(s => IsVideoFile(s));
                if (videoFile.Count() != 0)
                {
                    foreach (var video in videoFile)
                    {
                        var videoName = video.Substring(video.LastIndexOf('\\') + 1);
                        File.Move(video, workFodler + "\\" + videoName);
                        response.Count++;
                        response.HasMoved = true;

                        foreach (var sub in subtitles)
                        {
                            //var fileName = sub.Substring(sub.LastIndexOf('\\') + 1).ToLower();
                            var subEpisode = Regex.Match(sub, episodeFindPattern);

                            if (video.Contains(subEpisode.ToString()))
                            {
                                var newSubName = RenameSubtitles(video);
                                File.Move(sub, workFodler + "\\" + newSubName);
                            }
                        }
                    }

                }

            }
            if (response.Count==0)
            {
                response.Message = "No videos were moved";
                response.HasMoved = false;
            }

            return response;
        }

        private string RenameSubtitles(string videoName)
        {
            return videoName.Substring(videoName.LastIndexOf('\\') + 1).Replace(".avi", ".srt");
        }
        private bool IsVideoFile(string path)
        {
            string[] mediaExtensions = { ".AVI", ".MP4", ".DIVX", ".WMV" };
            return -1 != Array.IndexOf(mediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }
        private bool IsSubtitles(string path)
        {
            string[] mediaExtensions = { ".SRT", ".SUB" };
            return -1 != Array.IndexOf(mediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }
        private string FoundSubsAndDirs(List<string> subs, List<string> dirs)
        {
            if (subs.Count <= 0)
            {
                return  "No subtitles were found in the folder that you gave me!";
            }
            else if (dirs.Count <= 0)
            {
                return "No sub directories were found in the folder that you gave me!";
            }
            return string.Empty;
        }
    }
}