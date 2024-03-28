﻿namespace Logic.Models;

using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }

    [JsonIgnore]
    public string Password { get; set; }
}