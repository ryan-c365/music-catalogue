using music_catalogue_app.Data;
using music_catalogue_app.Models;

namespace music_catalogue_app.Services {
    public class MusicCatalog {

        private readonly MusicCatalogDb _db;

        public MusicCatalog(MusicCatalogDb db)
        {
            _db = db;
        }

        public async Task AddAsync(Song song)
        {
            await _db.Songs.AddAsync(song);
        }

        public async Task UpdateAsync(Song song)
        {
            await _db.Songs.PutAsync(song);
        }

        public async Task DeleteAsync(int id)
        {
            await _db.Songs.DeleteAsync<int>(id);
        }

        public async Task<List<Song>> GetAllAsync()
        {
            return await _db.Songs.GetAllAsync<Song>();
        }

    }

}
