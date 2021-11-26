namespace DatingService.Infrastructure.ViewModels
{
    public class PlacemarkViewModel
    {
        public double x { get; set; }
        public double y { get; set; }
        public bool balloonCloseButton { get; set; }
        public string balloonContent { get; set; }
        public bool hideIconOnBalloonOpen { get; set; }
        public string iconContent { get; set; }
        public string preset { get; set; }
    }
}
