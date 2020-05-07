using Data;
using Data.Entities;
using Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CharacterService
    {
        public bool CreateCharacter(CharacterCreateModel characterToCreate)
        {
            var entity = new Character()
            {
                FirstName = characterToCreate.FirstName,
                LastName = characterToCreate.LastName,
                Species = characterToCreate.Species,
                Price = characterToCreate.Price,
                Affiliation = characterToCreate.Affiliation,
                DefaultWeaponId = characterToCreate.DefaultWeaponId,
                DefaultShipId = characterToCreate.DefaultShipId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
