using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinImageClick
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageLoadPage : ContentPage
    {
        public ImageLoadPage()
        {
            InitializeComponent();
            ImageLoad();
        }


        //<Image Source = "https://picsum.photo/200" x:Name="img"/>

        Image img;
        private void Button_Clicked(object sender, EventArgs e)
        {
            ImageLoad();
        }

        private void ImageLoad()
        {
            if (img != null && st.Children.Contains(img))
                st.Children.Remove(img);
            img = new Image();
            var source = new UriImageSource();
            source.Uri = new System.Uri("https://picsum.photos/200/300");
            source.CachingEnabled = false;
            img.Source = source;
            st.Children.Add(img);
        }
    }
}