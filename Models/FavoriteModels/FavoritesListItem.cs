using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FavoriteModels
{
    public class FavoritesListItem
    {
        [Key]
        public int FavoritesId { get; set; }

        [ForeignKey("FavoriteCharacter")]
        public int CharacterId { get; set; }

        [ForeignKey("FavoritePlanet")]
        public int PlanetId { get; set; }

        [ForeignKey("FavoriteShip")]
        public int ShipId { get; set; }

        [ForeignKey("FavoriteWeapon")]
        public int WeaponId { get; set; }
    }
}
