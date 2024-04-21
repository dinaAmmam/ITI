namespace APID2.DTO
{
    public class deptstudentsDTO
    {
        public string name { get; set; }
        public string loc { get; set; }
        public string supervisorName { get; set; }


        public List<string> studentNames { get; set; } = new List<string>();
    }
}
