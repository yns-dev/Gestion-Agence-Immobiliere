using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence.Domain.Models;

public class Visite
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int BienId { get; set; }
    public DateTime DateVisite { get; set; }
    public DateOnly? DateConfirmation { get; set; }
    public string Statut { get; set; }
    public Client Client { get; set; }
    public BienImmobilier Bien { get; set; }
}
