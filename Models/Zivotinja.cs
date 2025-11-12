namespace Zoo.Models
{
    public class Zivotinja
    {
        public int Id { get; set; }
        public string Ime { get; set; } = string.Empty;
        public string? LatinskiNaziv { get; set; }
        public string? HrvatskiNaziv { get; set; }
        public string? NacinNabave { get; set; }
        public DateTime? DatumNabave { get; set; }
        public bool? Aktivna { get; set; }

        public int NastambaId { get; set; }
        public Nastamba? Nastamba { get; set; }

        public ICollection<Trosak> Troskovi { get; set; } = new List<Trosak>();
        public ICollection<IncidentZivotinja> Incidenti { get; set; } = new List<IncidentZivotinja>();
    }
}
