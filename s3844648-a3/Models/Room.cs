using System.ComponentModel.DataAnnotations;

namespace s3844648_a3.Models;
public class Room
{
    [StringLength(8)]
    [RegularExpression(@"^([0-9]{2}\.[0-9]{2}\.[0-9]{2})$", ErrorMessage = "Must be in the format: <2-digits>.<2-digits>.<2-digits>")]
    public string RoomID { get; set; }

    [Range(2, 300, ErrorMessage = "Must be within the range 2 to 300")]
    public int Capacity { get; set; }

    public bool HasProjector { get; set; }
}