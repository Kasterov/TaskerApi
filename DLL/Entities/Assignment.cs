using DAL.Enums;

namespace DAL.Entities;
public class Assignment
{
    public string Name { get; set; }
    public string Description { get; set; }
    public EnumStatus Status { get; set; }
}