using CloudNimble.BlazorEssentials.IndexedDb;
using Microsoft.JSInterop;

namespace music_catalogue_app.Data {
    public class MusicCatalogDb : IndexedDbDatabase{

        public IndexedDbObjectStore Songs { get; set; }

        public MusicCatalogDb(IJSRuntime jsRuntime) : base(jsRuntime)
        {
            Name = "MusicCatalogDb";
            Version = 1;

            Songs = new IndexedDbObjectStore(this, "Songs", "id", false);
        }

    }

}
