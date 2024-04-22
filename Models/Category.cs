using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace pedals_api.Models;
public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    //public virtual ICollection<Pedal> Pedals { get; set; }
}
