namespace DocumentFlowApp.Common.Dtos
{
    public class FileUploadDto
    {
        public string FileName { get; set; }

        public string FileExt { get; set; }

        public long FileSize { get; set; }

        public string FullPath { get; set; }

        public string UserDescriptions { get; set; }
    }
}
