using NASAv1.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASAv1.Domain.Entities
{
    public class Satellite: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }     
        public int RocketID { get; set; }
        public Rocket Rocket { get; set; }
    }
}
