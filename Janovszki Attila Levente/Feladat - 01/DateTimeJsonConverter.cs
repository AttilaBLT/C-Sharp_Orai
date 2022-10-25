using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Feladat___01
{
    internal class DateTimeJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString(), new CultureInfo("hu-HU"));
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Date);
        }
    }
}
