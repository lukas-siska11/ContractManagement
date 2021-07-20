namespace ContractManagement.Domain.Services.Export
{
    // Represents result after export
    public class CsvExportResult
    {
        public byte[] Data { get; set; }

        public string Filename { get; set; }

        public string ContentType { get; } = "text/csv";
    }
}
