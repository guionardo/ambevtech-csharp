using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnemicDomainModels.Models
{
    public class PhoneNumber
    {
        private string _ddi = "";
        private string _ddd = "";
        private string _number = "";

        /// <summary>
        /// Número de telefone
        /// 99999999        8 = Só o número Fixo
        /// 999999999       9 = Só o número Móvel        
        /// 99 99999999     10 = DDD + Fixo
        /// 99 999999999    11 = DDD + Móvel
        /// 99 99 99999999  12 = DDI + DDD + Fixo
        /// 99 99 999999999 13 = DDI + DDD + Móvel
        /// </summary>
        /// <param name="phoneNumber"></param>
        public PhoneNumber(string phoneNumber)
        {
            var numbers = string.Join("", phoneNumber.Where(c => c >= '0' && c <= '9'));
            switch (numbers.Length)
            {
                case 8:
                case 9:
                    _number = numbers;
                    break;
                case 10:
                case 11:
                    _ddd = numbers[0..2];
                    _number = numbers[2..];
                    break;
                case 12:
                case 13:
                    _ddi = numbers[0..2];
                    _ddd = numbers[2..4];
                    _number = numbers[4..];
                    break;
                default:
                    throw new ArgumentException($"Número de telefone é ínválido {phoneNumber}");
            }
        }

        public override string ToString()
        {
            return (!string.IsNullOrEmpty(_ddi) ? $"+{_ddi} " : "") + (!string.IsNullOrEmpty(_ddd) ? $"({_ddd}) " : "") + _number;
        }
    }

    public class PhoneNumberJsonConverter : JsonConverter<PhoneNumber>
    {
        public override PhoneNumber? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new PhoneNumber(reader.GetString() ?? "");
        }

        public override void Write(Utf8JsonWriter writer, PhoneNumber value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
