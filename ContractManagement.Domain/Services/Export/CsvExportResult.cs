namespace ContractManagement.Domain.Services.Export
{
    public class CsvExportResult
    {
        public byte[] Data { get; set; }

        public string Filename { get; set; }

        public string ContentType { get; } = "text/csv";
    }
}
