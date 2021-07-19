using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Services.Export
{
    public abstract class AbstractCsvExportService<TObject> where TObject : class
    {
        public async Task<CsvExportResult> Export()
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(stream: memoryStream, encoding: new UTF8Encoding(true)))
                {
                    using (var cswWriter = new CsvWriter(streamWriter, new CsvConfiguration(new CultureInfo("cs-CZ"))))
                    {
                        cswWriter.WriteRecords(await this.GetRecords());
                    }

                    return new CsvExportResult()
                    {
                        Data = memoryStream.ToArray(),
                        Filename = this.GetFilename()
                    };
                }
            }
        }

        protected abstract Task<IList<TObject>> GetRecords();

        protected abstract string GetFilename();
    }
}
