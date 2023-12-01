using System.Collections.ObjectModel;

namespace ProgressTest
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ImageItem> ImageItems { get; } = new ObservableCollection<ImageItem>
        {
            new ImageItem { ImagePath = "peachtree.jpg", ImageText = "Peach Tree In Blossom",ImagePrice = "$950,000"},
            new ImageItem { ImagePath = "cafe.jpg", ImageText = "Cafe Trrrace at Night",ImagePrice = "$1,920,000" },
            new ImageItem { ImagePath = "starrynight.jpg", ImageText = "Starry Night" ,ImagePrice = "$1000,000"},
            new ImageItem { ImagePath = "sunflowers.jpg", ImageText = "Sunflowers" ,ImagePrice = "$1000,000"}
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
    public class ImageItem
    {
        public string ImagePath { get; set; }
        public string ImageText { get; set; }
        public string ImagePrice { get; set; }
    }
} 