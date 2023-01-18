using DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;
public class Assignment
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public EnumStatus Status { get; set; }
}