using AnemicDomainModels.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnemicDomainModels.Models
{
    /// <summary>
    /// Armazena CPF ou CNPJ, validando a informação
    /// </summary>
    public class Document
    {
        private readonly string _document;

        public Document(string document)
        {
            if (!ValidateCpfCnpj.IsValidCpf(document) && !ValidateCpfCnpj.IsValidCnpj(document))
            {
                throw new ArgumentException($"Documento não é um CPF nem um CNPJ: {document}");
            }
            _document = document;
        }

        public override string ToString()
        {
            return _document;
        }
    }

    public class DocumentJsonSerializer : JsonConverter<Document>
    {
        public override Document? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new Document(reader.GetString() ?? "");
        }

        public override void Write(Utf8JsonWriter writer, Document value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
