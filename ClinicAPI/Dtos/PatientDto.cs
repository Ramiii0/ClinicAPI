﻿using ClinicAPI.Models;

namespace ClinicAPI.Dtos
{
    public class PatientDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Residence { get; set; }
        public string? Phone { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public string? Medical { get; set; }
        public string? Surgical { get; set; }
        public string? Social { get; set; }
        public string? Photo { get; set; }
        public byte[]? ImageData { get; set; }
        public List<VisitDto> Visits { get; set; }
    }
}
