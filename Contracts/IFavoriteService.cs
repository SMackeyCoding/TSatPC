using Models.FavoriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFavoriteService
    {
        void CreateFavorite(FavoritesCreateModel favoriteToCreate);
        IEnumerable<FavoritesListItem> GetAllFavorites();
        FavoritesDetailModel GetFavoritesDetailById(int favoriteId);
        void UpdateFavoritesById(int favoriteId, FavoritesUpdateModel favoriteToUpdate);
        void DeleteFavoritesById(int favoriteId);
    }
}
