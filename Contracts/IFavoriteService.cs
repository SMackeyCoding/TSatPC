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
        FavoritesDetailModel GetFavoritesDetailById(int favoritesId);
        void UpdateFavoritesById(int favoritesId, FavoritesUpdateModel favoriteToUpdate);
        void DeleteFavoritesById(int favoritesId);
    }
}
