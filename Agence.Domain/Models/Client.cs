using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence.Domain.Models;

public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Email { get; set; }
    public string Tel { get; set; }
    public string Genre { get; set; }
    public string Adresse { get; set; }
    public DateOnly DateNaissance { get; set; }
    public string SituationFamiliale { get; set; }
    public IEnumerable<Visite> Visites { get; set; }

}
