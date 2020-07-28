using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Text.Json;

namespace CoreEngine.BuildingBlocks.CommonPackage
{
    //TODO CONVERT DATETIME
    //public static class RegisterDateTimeConverter
    //{
    //    /// <summary>
    //    /// Register gzip compress
    //    /// </summary>
    //    /// <param name="services"></param>
    //    /// <returns></returns>
    //    public static IServiceCollection AddGzipCompress(this IServiceCollection services)
    //    {
    //        services.AddControllers().AddJsonOptions(o =>
    //        {
    //            o.JsonSerializerOptions.Converters.Add(new ConvertDateTimeConverter());
    //        });

    //        return services;
    //    }

    //    /// <summary>
    //    /// Use Gzip compress
    //    /// </summary>
    //    /// <param name="app"></param>
    //    /// <returns></returns>
    //    public static IApplicationBuilder UseGzipCompress(this IApplicationBuilder app)
    //    {
    //        app.UseResponseCompression();

    //        return app;
    //    }
    //}

    //public class DateTimeConverter : JsonConverter<DateTime>
    //{
    //    public override DateTime Read(ref Utf8JsonReader reader,
    //                                  Type typeToConvert,
    //                                  JsonSerializerOptions options)
    //    {
    //        if (reader.GetType() == typeof(DateTime))
    //        {
    //            DateTime value = (DateTime)reader.Value;
    //            if (value.Kind == DateTimeKind.Utc)
    //            {
    //                value = value.ToLocalTime();
    //                return value;
    //            }
    //        }

    //        var name = reader.GetString();

    //        return new DateTime(name);
    //    }

    //    public override void Write(Utf8JsonWriter writer,
    //                               Category value,
    //                               JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.Name);
    //    }
    //}

    //public class DateTimeConverter : JsonConverter<DateTime>
    //{
    //    public override DateTime Read(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        try
    //        {
    //            if (reader.ValueType == typeof(DateTime))
    //            {
    //                DateTime value = (DateTime)reader.Value;
    //                if (value.Kind == DateTimeKind.Utc)
    //                {
    //                    value = value.ToLocalTime();
    //                    return value;
    //                }
    //            }

    //            if (reader.ValueType == typeof(DateTime?))
    //            {
    //                DateTime? value = (DateTime?)reader.Value;
    //                if (value.HasValue && value.Value.Kind == DateTimeKind.Utc)
    //                {
    //                    value.Value.ToLocalTime();
    //                    return value.Value;
    //                }
    //            }

    //            string format = "dd/MM/yyyy";
    //            var provider = new CultureInfo("vi-VN");
    //            DateTime parsedDateTime = new DateTime();
    //            bool success = DateTime.TryParseExact(reader.Value.ToString(), format, provider, DateTimeStyles.None, out parsedDateTime);
    //            if (success)
    //                return parsedDateTime;

    //            return DateTime.Parse(reader.Value.ToString());
    //        }
    //        catch
    //        {
    //            throw new Exception("Read datetime not valid format");
    //        }
    //    }

    //    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions serializer)
    //    {
    //        DateTime? nullDateTime = null;
    //        try
    //        {
    //            if (value == null || (DateTime)value == DateTime.MinValue)
    //                writer.WriteStringValue(nullDateTime.Value);
    //            else
    //                writer.WriteStringValue(((DateTime)value));
    //        }
    //        catch
    //        {
    //            throw new Exception("Write datetime not valid format");
    //        }
    //    }
    //}
}