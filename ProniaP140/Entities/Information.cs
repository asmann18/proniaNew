﻿namespace ProniaP140.Entities
{
    public class Information
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public byte Order { get; set; }
    }
}
