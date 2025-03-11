using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence.Domain.Models;

public class BienImmobilier
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Adresse { get; set; }
    public int Surface { get; set; }
    public double Prix { get; set; }
    public string Statut { get; set; }
    public string Description { get; set; }
    public IEnumerable<Visite> Visites { get; set; }
}
