using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Feladat___01
{
    public class User
    {
        public string Id { get; set; }
        
        public int Index { get; set; }
        
        public string Guid { get; set; }
        
        public bool IsActive { get; set; }

        [JsonConverter(typeof(CurrencyJsonConverter))]
        public string Balance  { get; set; }
        
        public string Picture { get; set; }
        
        public int Age { get; set; }
        
        public string EyeColor { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Company { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string About { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime Registered { get; set; }

        public User()
        {
        }

        public User(string id, int index, string guid, bool isActive, string balance, string picture, int age, string eyeColor, string name, string gender, string company, string email, string phone, string address, string about, DateTime registered)
        {
            Id = id;
            Index = index;
            Guid = guid;
            IsActive = isActive;
            Balance = balance;
            Picture = picture;
            Age = age;
            EyeColor = eyeColor;
            Name = name;
            Gender = gender;
            Company = company;
            Email = email;
            Phone = phone;
            Address = address;
            About = about;
            Registered = registered;
        }

        public override string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
            };

            return JsonSerializer.Serialize(this, options);
        }
    }
}
