using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace minotl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentPage
    {
        #region переменные
        public Random rand = new Random();
        public int i = 0;
        public int ki = 0;
        #endregion

        #region intialize
        public Game()
        {
            InitializeComponent();
         
                i = rand.Next(0, 89);
                ki = 0;
                b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
               
        }
        #endregion

        #region массив цветов
        public string[,] mcol = new string[,]
        {
            { "#FA8072", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C" },
            { "#CD5C5C", "#FA8072", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C" },
            { "#CD5C5C", "#CD5C5C", "#FA8072", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C" },
            { "#CD5C5C", "#CD5C5C", "#CD5C5C", "#FA8072", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C" },
            { "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#FA8072", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C" },
            { "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#FA8072", "#CD5C5C", "#CD5C5C", "#CD5C5C" },
            { "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#FA8072", "#CD5C5C", "#CD5C5C" },
            { "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#FA8072", "#CD5C5C" },
            { "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#CD5C5C", "#FA8072" },

            { "#FFB6C1", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB" },
            { "#FFC0CB", "#FFB6C1", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB" },
            { "#FFC0CB", "#FFC0CB", "#FFB6C1", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB" },
            { "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFB6C1", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB" },
            { "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFB6C1", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB" },
            { "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFB6C1", "#FFC0CB", "#FFC0CB", "#FFC0CB" },
            { "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFB6C1", "#FFC0CB", "#FFC0CB" },
            { "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFB6C1", "#FFC0CB" },
            { "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFC0CB", "#FFB6C1" },

            { "#FFFF00", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700" },
            { "#FFD700", "#FFFF00", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700" },
            { "#FFD700", "#FFD700", "#FFFF00", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700" },
            { "#FFD700", "#FFD700", "#FFD700", "#FFFF00", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700" },
            { "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFFF00", "#FFD700", "#FFD700", "#FFD700", "#FFD700" },
            { "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFFF00", "#FFD700", "#FFD700", "#FFD700" },
            { "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFFF00", "#FFD700", "#FFD700" },
            { "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFFF00", "#FFD700" },
            { "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFD700", "#FFFF00" },

            { "#FFFACD", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0" },
            { "#FFFFE0", "#FFFACD", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0" },
            { "#FFFFE0", "#FFFFE0", "#FFFACD", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0" },
            { "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFACD", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0" },
            { "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFACD", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0" },
            { "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFACD", "#FFFFE0", "#FFFFE0", "#FFFFE0" },
            { "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFACD", "#FFFFE0", "#FFFFE0" },
            { "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFACD", "#FFFFE0" },
            { "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFFE0", "#FFFACD" },

            { "#40E0D0", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC" },
            { "#48D1CC", "#40E0D0", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC" },
            { "#48D1CC", "#48D1CC", "#40E0D0", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC" },
            { "#48D1CC", "#48D1CC", "#48D1CC", "#40E0D0", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC" },
            { "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#40E0D0", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC" },
            { "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#40E0D0", "#48D1CC", "#48D1CC", "#48D1CC" },
            { "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#40E0D0", "#48D1CC", "#48D1CC" },
            { "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#40E0D0", "#48D1CC" },
            { "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#48D1CC", "#40E0D0" },

            { "#90EE90", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98" },
            { "#98FB98", "#90EE90", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98" },
            { "#98FB98", "#98FB98", "#90EE90", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98" },
            { "#98FB98", "#98FB98", "#98FB98", "#90EE90", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98" },
            { "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#90EE90", "#98FB98", "#98FB98", "#98FB98", "#98FB98" },
            { "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#90EE90", "#98FB98", "#98FB98", "#98FB98" },
            { "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#90EE90", "#98FB98", "#98FB98" },
            { "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#90EE90", "#98FB98" },
            { "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#98FB98", "#90EE90" },

            { "#000080", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B" },
            { "#00008B", "#000080", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B" },
            { "#00008B", "#00008B", "#000080", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B" },
            { "#00008B", "#00008B", "#00008B", "#000080", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B" },
            { "#00008B", "#00008B", "#00008B", "#00008B", "#000080", "#00008B", "#00008B", "#00008B", "#00008B" },
            { "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#000080", "#00008B", "#00008B", "#00008B" },
            { "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#000080", "#00008B", "#00008B" },
            { "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#000080", "#00008B" },
            { "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#00008B", "#000080" },

            { "#708090", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899" },
            { "#778899", "#708090", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899" },
            { "#778899", "#778899", "#708090", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899" },
            { "#778899", "#778899", "#778899", "#708090", "#778899", "#778899", "#778899", "#778899", "#778899" },
            { "#778899", "#778899", "#778899", "#778899", "#708090", "#778899", "#778899", "#778899", "#778899" },
            { "#778899", "#778899", "#778899", "#778899", "#778899", "#708090", "#778899", "#778899", "#778899" },
            { "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#708090", "#778899", "#778899" },
            { "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#708090", "#778899" },
            { "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#778899", "#708090" },

            { "#FFE4E1", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7" },
            { "#FAEBD7", "#FFE4E1", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7" },
            { "#FAEBD7", "#FAEBD7", "#FFE4E1", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7" },
            { "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FFE4E1", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7" },
            { "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FFE4E1", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7" },
            { "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FFE4E1", "#FAEBD7", "#FAEBD7", "#FAEBD7" },
            { "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FFE4E1", "#FAEBD7", "#FAEBD7" },
            { "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FFE4E1", "#FAEBD7" },
            { "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FAEBD7", "#FFE4E1" },

            { "#006400", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000" },
            { "#008000", "#006400", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000" },
            { "#008000", "#008000", "#006400", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000" },
            { "#008000", "#008000", "#008000", "#006400", "#008000", "#008000", "#008000", "#008000", "#008000" },
            { "#008000", "#008000", "#008000", "#008000", "#006400", "#008000", "#008000", "#008000", "#008000" },
            { "#008000", "#008000", "#008000", "#008000", "#008000", "#006400", "#008000", "#008000", "#008000" },
            { "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#006400", "#008000", "#008000" },
            { "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#006400", "#008000" },
            { "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#008000", "#006400" }
        };
        #endregion

        #region Fake color
        public string[] ocol = new string[]
        {
            "#FA8072","#FA8072","#FA8072","#FA8072","#FA8072","#FA8072","#FA8072","#FA8072","#FA8072",
            "#FFB6C1","#FFB6C1","#FFB6C1","#FFB6C1","#FFB6C1","#FFB6C1","#FFB6C1","#FFB6C1","#FFB6C1",
            "#FFFF00","#FFFF00","#FFFF00","#FFFF00","#FFFF00","#FFFF00","#FFFF00","#FFFF00","#FFFF00",
            "#FFFACD","#FFFACD","#FFFACD","#FFFACD","#FFFACD","#FFFACD","#FFFACD","#FFFACD","#FFFACD",
            "#40E0D0","#40E0D0","#40E0D0","#40E0D0","#40E0D0","#40E0D0","#40E0D0","#40E0D0","#40E0D0",
            "#90EE90","#90EE90","#90EE90","#90EE90","#90EE90","#90EE90","#90EE90","#90EE90","#90EE90",
            "#000080","#000080","#000080","#000080","#000080","#000080","#000080","#000080","#000080",
            "#708090","#708090","#708090","#708090","#708090","#708090","#708090","#708090","#708090",
            "#FFE4E1","#FFE4E1","#FFE4E1","#FFE4E1","#FFE4E1","#FFE4E1","#FFE4E1","#FFE4E1","#FFE4E1",
            "#006400","#006400","#006400","#006400","#006400","#006400","#006400","#006400","#006400"
        };
        #endregion

        async void c1(object semder, EventArgs e)
        {

            if (b1.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }

        }
        async void c2(object semder, EventArgs e)
        {
            if (b2.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }
        async void c3(object semder, EventArgs e)
        {
            if (b3.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }
        async void c4(object semder, EventArgs e)
        {
            if (b4.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }
        async void c5(object semder, EventArgs e)
        {
            if (b5.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }
        async void c6(object semder, EventArgs e)
        {
            if (b6.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }
        async void c7(object semder, EventArgs e)
        {
            if (b7.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }
        async void c8(object semder, EventArgs e)
        {
            if (b8.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }
        async void c9(object semder, EventArgs e)
        {
            if (b9.BackgroundColor == Color.FromHex(ocol[i]))
            {
                if (ki == 14)
                {
                    await DisplayAlert("Меню", "Вы выйграли", "Закрыть");
                    await Navigation.PushAsync(new MainPage());

                }
                else
                {
                    ki++;
                    i = rand.Next(0, 89);
                    b1.BackgroundColor = Color.FromHex(mcol[i, 0]);
                    b2.BackgroundColor = Color.FromHex(mcol[i, 1]);
                    b3.BackgroundColor = Color.FromHex(mcol[i, 2]);
                    b4.BackgroundColor = Color.FromHex(mcol[i, 3]);
                    b5.BackgroundColor = Color.FromHex(mcol[i, 4]);
                    b6.BackgroundColor = Color.FromHex(mcol[i, 5]);
                    b7.BackgroundColor = Color.FromHex(mcol[i, 6]);
                    b8.BackgroundColor = Color.FromHex(mcol[i, 7]);
                    b9.BackgroundColor = Color.FromHex(mcol[i, 8]);
                }
            }
            else
            {
                await DisplayAlert("Меню", "Вы проиграли", "Закрыть");
                await Navigation.PushAsync(new MainPage());

            }
        }


    }
}