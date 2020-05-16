using Contracts;
using Data;
using Data.Entities;
using Models.FavoriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FavoriteService : IFavoriteService
    {
    private readonly ApplicationDbContext _ctx = new ApplicationDbContext();

    public void CreateFavorite(FavoritesCreateModel favoriteToCreate)
    {
        var entity = new Favorite()
        {
            FavoritesId = favoriteToCreate.CharacterId,
            PlanetId = favoriteToCreate.PlanetId,
            ShipId = favoriteToCreate.ShipId,
            WeaponId = favoriteToCreate.WeaponId,
        };
        _ctx.Favorites.Add(entity);
        _ctx.SaveChanges();
    }

    public void DeleteFavoritesById(int favoritesId)
    {
        var entity = _ctx.Favorites.Single(e => e.FavoritesId == favoritesId);
        _ctx.Favorites.Remove(entity);
        _ctx.SaveChanges();
    }

    public FavoritesDetailModel GetFavoritesDetailById(int favoritesId)
    {
        var i = _ctx.Favorites.Single(e => e.FavoritesId == favoritesId);
        var entity = new FavoritesDetailModel()
        {
            FavoritesId = i.FavoritesId,
            CharacterId = i.CharacterId,
            PlanetId = i.PlanetId,
            ShipId = i.ShipId,
            WeaponId = i.WeaponId,
        };
        return entity;
    }

    public IEnumerable<FavoritesListItem> GetAllFavorites()
    {
        var returnList = _ctx.Favorites.Select(e => new FavoritesListItem()
        {
            FavoritesId = e.FavoritesId,
            CharacterId = e.CharacterId,
            PlanetId = e.PlanetId,
            ShipId = e.ShipId,
            WeaponId = e.WeaponId,
        }).ToList();
        return returnList;
    }

    public void UpdateFavoritesById(int favoritesId, FavoritesUpdateModel favoriteToUpdate)
    {
        var entity = _ctx.Favorites.Single(e => e.FavoritesId == favoriteToUpdate.FavoritesId);
        if (entity != null)
        {
            if (favoriteToUpdate.CharacterId != null)
                entity.CharacterId = (int)favoriteToUpdate.CharacterId;
            if (favoriteToUpdate.PlanetId != null)
                entity.PlanetId = (int)favoriteToUpdate.PlanetId;
            if (favoriteToUpdate.ShipId != null)
                entity.ShipId = (int)favoriteToUpdate.ShipId;
            if (favoriteToUpdate.WeaponId != null)
                entity.ShipId = (int)favoriteToUpdate.WeaponId;
            _ctx.SaveChanges();
        }
    }
}
}