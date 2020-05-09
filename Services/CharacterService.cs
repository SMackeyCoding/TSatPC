using Contracts;
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
    public class CharacterService : ICharacterService
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        public void CreateCharacter(CharacterCreateModel characterToCreate)
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

            _ctx.Characters.Add(entity);
            _ctx.SaveChanges();

        }

        public void DeleteCharacter(int characterId)
        {
            var entity = _ctx.Characters.Single(e => e.CharacterId == characterId);
            _ctx.Characters.Remove(entity);
            _ctx.SaveChanges();
        }

        public CharacterDetailModel GetCharacterDetailById(int characterId)
        {
            var i = _ctx.Characters.Single(e => e.CharacterId == characterId);
            var entity = new CharacterDetailModel()
            {
                CharacterId = i.CharacterId,
                FirstName = i.FirstName,
                LastName = i.LastName,
                Species = i.Species,
                Price = i.Price,
                Affiliation = i.Affiliation,
                DefaultWeaponId = i.DefaultWeaponId,
                DefaultShipId = i.DefaultShipId
            };
            return entity;
        }

        public IEnumerable<CharacterListModel> GetCharacters()
        {
            var returnList = _ctx.Characters.Select(e => new CharacterListModel()
            {
                CharacterId = e.CharacterId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Price = e.Price
            }).ToList();
            return returnList;
        }

        public void UpdateCharacter(int characterId, CharacterUpdateModel characterToUpdate)
        {
            var entity = _ctx.Characters.Single(e => e.CharacterId == characterId);
            if (entity != null)
            {
                if (characterToUpdate.UpdatedFirstName != null)
                    entity.FirstName = characterToUpdate.UpdatedFirstName;
                if (characterToUpdate.UpdatedLastName != null)
                    entity.LastName = characterToUpdate.UpdatedLastName;
                if (characterToUpdate.UpdatedSpecies != null)
                    entity.Species = characterToUpdate.UpdatedSpecies;
                if (characterToUpdate.UpdatedPrice != null)
                    entity.Price = (int)characterToUpdate.UpdatedPrice;
                if (characterToUpdate.UpdatedAffiliation != null)
                    entity.Affiliation = characterToUpdate.UpdatedAffiliation;
                if (characterToUpdate.UpdatedDefaultWeaponId != null)
                    entity.DefaultWeaponId = (int)characterToUpdate.UpdatedDefaultWeaponId;
                if (characterToUpdate.UpdatedDefaultShipId != null)
                    entity.DefaultShipId = (int)characterToUpdate.UpdatedDefaultShipId;
                _ctx.SaveChanges();
            }
        }
    }
}
