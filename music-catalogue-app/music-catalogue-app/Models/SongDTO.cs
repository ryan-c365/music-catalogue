using System.ComponentModel.DataAnnotations;

namespace music_catalogue_app.Models {
    public class SongDTO {

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string title { get; set; } = "";

        [Required(ErrorMessage = "Artist is required")]
        [StringLength(100)]
        public string artist { get; set; } = "";

    }

}
