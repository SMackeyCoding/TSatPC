using Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICharacterService
    {
        void CreateCharacter(CharacterCreateModel characterToCreate);
        IEnumerable<CharacterListModel> GetCharacters();
        CharacterDetailModel GetCharacterDetailById(int characterId);
        void UpdateCharacter(CharacterUpdateModel characterToUpdate);
        void DeleteCharacter(CharacterDeleteModel characterToDelete);
    }
}
