using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    class ApplicationDbIntializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {

            var category1 = new Rolcategory
            {
                Category = "Классические",
                Id = 1
            };

            var category2 = new Rolcategory
            {
                Category = "День-Ночь",
                Id = 2
            };
            var category3 = new Rolcategory
            {
                Category = "Блэкаут",
                Id = 3
            };


            var collection1 = new Product
            {
                Id = 1,
                Description = "Сайт рыбатекст поможет дизайнеру, верстальщику, вебмастеру сгенерировать несколько абзацев более менее осмысленного текста рыбы на русском языке, а начинающему оратору отточить навык публичных выступлений в домашних условиях. При создании генератора мы использовали небезизвестный универсальный код речей. Текст генерируется абзацами случайным образом от двух до десяти предложений в абзаце, что позволяет сделать текст более привлекательным и живым для визуально-слухового восприятия.",
                Name = "Амелия",
                Price = 10,
                CategoryEntity = category1

            };

            var collection2 = new Product
            {
                Id = 2,
                Description = "Сайт рыбатекст поможет дизайнеру, верстальщику, вебмастеру сгенерировать несколько абзацев более менее осмысленного текста рыбы на русском языке, а начинающему оратору отточить навык публичных выступлений в домашних условиях. При создании генератора мы использовали небезизвестный универсальный код речей. Текст генерируется абзацами случайным образом от двух до десяти предложений в абзаце, что позволяет сделать текст более привлекательным и живым для визуально-слухового восприятия.",
                Name = "Вода",
                Price = 20,
                CategoryEntity = category1
            };
            var collection3 = new Product
            {
                Id = 3,
                Description = "Description second test",
                Name = "Бамбус",
                Price = 20,
                CategoryEntity = category1
            };

            var collection4 = new Product
            {
                Id = 4,
                Description = "Description first test",
                Name = "Цветы",
                Price = 10,
                CategoryEntity = category1

            };

            var collection5 = new Product
            {
                Id = 5,
                Description = "Description second test",
                Name = "Классик-2",
                Price = 20,
                CategoryEntity = category1
            };
            var collection6 = new Product
            {
                Id = 6,
                Description = "Description second test",
                Name = "Кола",
                Price = 20,
                CategoryEntity = category1
            };
            var collection7 = new Product
            {
                Id = 7,
                Description = "Description second test",
                Name = "Лён",
                Price = 20,
                CategoryEntity = category1
            };
            var collection8 = new Product
            {
                Id = 8,
                Description = "Description second test",
                Name = "Маракеш",
                Price = 20,
                CategoryEntity = category1
            };
            var collection9 = new Product
            {
                Id = 9,
                Description = "Description second test",
                Name = "Перла",
                Price = 20,
                CategoryEntity = category1
            };
            var collection10 = new Product
            {
                Id = 10,
                Description = "Description second test",
                Name = "Престиж",
                Price = 20,
                CategoryEntity = category1
            };
            var collection11 = new Product
            {
                Id = 11,
                Description = "Description second test",
                Name = "Сара",
                Price = 20,
                CategoryEntity = category1
            };
            var collection12 = new Product
            {
                Id = 12,
                Description = "Description second test",
                Name = "Шантунг",
                Price = 20,
                CategoryEntity = category1
            };
            var collection13 = new Product
            {
                Id = 13,
                Description = "Description second test",
                Name = "Топаз",
                Price = 20,
                CategoryEntity = category1
            };
            var collection14 = new Product
            {
                Id = 14,
                Description = "Description second test",
                Name = "Блэкаут",
                Price = 20,
                CategoryEntity = category3
            };
            var collection15 = new Product
            {
                Id = 15,
                Description = "Description second test",
                Name = "Барок",
                Price = 20,
                CategoryEntity = category3
            };
            var collection16 = new Product
            {
                Id = 16,
                Description = "Description second test",
                Name = "Багама-1",
                Price = 20,
                CategoryEntity = category2
            };
            var collection17 = new Product
            {
                Id = 17,
                Description = "Description second test",
                Name = "Багама",
                Price = 20,
                CategoryEntity = category2
            };
            var collection18 = new Product
            {
                Id = 18,
                Description = "Description second test",
                Name = "Багама-2",
                Price = 20,
                CategoryEntity = category2
            };
            var collection19 = new Product
            {
                Id = 19,
                Description = "Description second test",
                Name = "Классик-1",
                Price = 20,
                CategoryEntity = category1
            };
            var collection20 = new Product
            {
                Id = 20,
                Description = "Description second test",
                Name = "Меланж",
                Price = 20,
                CategoryEntity = category1
            };
            var color1 = new Rolcolors
            {
                Color = "Кремовый",
                Id = 1
            };
            var color2 = new Rolcolors
            {
                Color = "Песок",
                Id = 2
            };
            var color3 = new Rolcolors
            {
                Color = "Коричневый",
                Id = 3
            };
            var color4 = new Rolcolors
            {
                Color = "Серый",
                Id = 4
            };
            var color5 = new Rolcolors
            {
                Color = "Оранжевый",
                Id = 5
            };
            var color6 = new Rolcolors
            {
                Color = "Зеленый",
                Id = 6
            };
            var color7 = new Rolcolors
            {
                Color = "Фиолетовый",
                Id = 7
            };
            var color8 = new Rolcolors
            {
                Color = "Красный",
                Id = 8
            };
            var color9 = new Rolcolors
            {
                Color = "Бордовый",
                Id = 9
            };
            var color10 = new Rolcolors
            {
                Color = "Светло-Коричневый",
                Id = 10
            };
            var color11 = new Rolcolors
            {
                Color = "Бежевый",
                Id = 11
            };
            var color12 = new Rolcolors
            {
                Color = "Голубой",
                Id =12
            };
            var color13 = new Rolcolors
            {
                Color = "Желтый",
                Id =13
            };
            var color14 = new Rolcolors
            {
                Color = "Фисташковый",
                Id = 14
            };
            var color15 = new Rolcolors
            {
                Color = "Оливковый",
                Id = 15
            };
            var color16 = new Rolcolors
            {
                Color = "Абрикосовый",
                Id = 16
            };
            var color17 = new Rolcolors
            {
                Color = "Кирпичный",
                Id = 17
            };
            var color18 = new Rolcolors
            {
                Color = "Синий",
                Id = 18
            };
            var color19 = new Rolcolors
            {
                Color = "Белый",
                Id = 19
            };
            var rolTypes = new RolTypes
            {
                Id = 1,
                Type = "Mini"
            };

            var rolTypes2 = new RolTypes
            {
                Id = 2,
                Type = "Universal"
            };

            var rolsizemini = new Rolsize
            {
                Id = 1,
                Size = "37x150",
                typesCollection = rolTypes,
                TypyId = 1,

            };
            var rolsizemini2 = new Rolsize
            {
                Id = 2,
                Size = "43x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini3 = new Rolsize
            {
                Id = 3,
                Size = "48x150",
                typesCollection = rolTypes,
                TypyId = 1
            };

            var rolsizemini4 = new Rolsize
            {
                Id = 4,
                Size = "52x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini5 = new Rolsize
            {
                Id = 5,
                Size = "57x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini6 = new Rolsize
            {
                Id = 6,
                Size = "62x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini7 = new Rolsize
            {
                Id = 7,
                Size = "68x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini8 = new Rolsize
            {
                Id = 8,
                Size = "73x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini9 = new Rolsize
            {
                Id = 9,
                Size = "81x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini10 = new Rolsize
            {
                Id = 10,
                Size = "90x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini11 = new Rolsize
            {
                Id = 11,
                Size = "98x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini12 = new Rolsize
            {
                Id = 12,
                Size = "115x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini13 = new Rolsize
            {
                Id = 13,
                Size = "128x150",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini14 = new Rolsize
            {
                Id = 14,
                Size = "52x215",
                typesCollection = rolTypes,
                TypyId = 1
            };
            var rolsizemini15 = new Rolsize
            {
                Id = 15,
                Size = "68x215",
                typesCollection = rolTypes,
                TypyId = 1
            };

            var rolsize16 = new Rolsize
            {
                Id = 16,
                Size = "120x175",
                typesCollection = rolTypes2,
                TypyId = 2

            };
            var rolsize17 = new Rolsize
            {
                Id = 17,
                Size = "140x175",
                typesCollection = rolTypes2,
                TypyId = 2

            };
            var rolsize18 = new Rolsize
            {
                Id = 18,
                Size = "160x175",
                typesCollection = rolTypes2,
                TypyId = 2

            };
            var rolsize19 = new Rolsize
            {
                Id = 19,
                Size = "180x175",
                typesCollection = rolTypes2,
                TypyId = 2

            };
            var rolsize20 = new Rolsize
            {
                Id = 20,
                Size = "200x175",
                typesCollection = rolTypes2,
                TypyId = 2

            };
            var rolsize21 = new Rolsize
            {
                Id = 21,
                Size = "220x175",
                typesCollection = rolTypes2,
                TypyId = 2

            };

            var rolsize22 = new Rolsize
            {
                Id = 22,
                Size = "120x160",
                typesCollection = rolTypes2,
                TypyId = 2,
                IsDayNight = true
            };
            var rolsize23 = new Rolsize
            {
                Id = 23,
                Size = "140x160",
                typesCollection = rolTypes2,
                TypyId = 2,
                IsDayNight = true
            };
            var rolsize24 = new Rolsize
            {
                Id = 24,
                Size = "160x160",
                typesCollection = rolTypes2,
                TypyId = 2,
                IsDayNight = true
            };
            var rolsize25 = new Rolsize
            {
                Id = 25,
                Size = "180x160",
                typesCollection = rolTypes2,
                TypyId = 2,
                IsDayNight = true
            };
            var rolsize26 = new Rolsize
            {
                Id = 26,
                Size = "90x240",
                typesCollection = rolTypes2,
                TypyId = 2
            };
            var collectionColor1 = new Rolcollection_colors
            {
                ID = 1,
                collectionEntity = collection1,
                colorsEntity = color1,
                number = "01" 
            };
            var collectionColor2 = new Rolcollection_colors
            {
                ID = 2,
                collectionEntity = collection1,
                colorsEntity = color2,
                number = "02"
            };
            var collectionColor3 = new Rolcollection_colors
            {
                ID = 3,
                collectionEntity = collection1,
                colorsEntity = color3,
                number = "04"
            };
            var collectionColor4 = new Rolcollection_colors
            {
                ID = 4,
                collectionEntity = collection1,
                colorsEntity = color4,
                number = "05"
            };
            var collectionColor5 = new Rolcollection_colors
            {
                ID = 5,
                collectionEntity = collection1,
                colorsEntity = color5,
                number = "06"
            };
            var collectionColor6 = new Rolcollection_colors
            {
                ID = 6,
                collectionEntity = collection1,
                colorsEntity = color6,
                number = "07"
            };
            var collectionColor7 = new Rolcollection_colors
            {
                ID = 7,
                collectionEntity = collection1,
                colorsEntity = color7,
                number = "08"
            };
            var collectionColor8 = new Rolcollection_colors
            {
                ID = 8,
                collectionEntity = collection1,
                colorsEntity = color8,
                number = "9"
            };
            var collectionColor9 = new Rolcollection_colors
            {
                ID = 9,
                collectionEntity = collection2,
                colorsEntity = color9,
                number = "889"
            };
            var collectionColor10 = new Rolcollection_colors
            {
                ID = 10,
                collectionEntity = collection2,
                colorsEntity = color10,
                number = "1827"
            };

            context.rolCategories.Add(category1);
            context.rolCategories.Add(category2);
            context.rolCategories.Add(category3);
            context.Products.Add(collection1);
            context.Products.Add(collection2);
            context.Products.Add(collection3);
            context.Products.Add(collection4);
            context.Products.Add(collection5);
            context.Products.Add(collection6);
            context.Products.Add(collection7);
            context.Products.Add(collection8);
            context.Products.Add(collection9);
            context.Products.Add(collection10);
            context.Products.Add(collection11);
            context.Products.Add(collection12);
            context.Products.Add(collection13);
            context.Products.Add(collection14);
            context.Products.Add(collection15);
            context.Products.Add(collection16);
            context.Products.Add(collection17);
            context.Products.Add(collection18);
            context.Products.Add(collection19);
            context.Products.Add(collection20);
            context.rolColors.Add(color1);
            context.rolColors.Add(color2);
            context.rolColors.Add(color3);
            context.rolColors.Add(color4);
            context.rolColors.Add(color5);
            context.rolColors.Add(color6);
            context.rolColors.Add(color7);
            context.rolColors.Add(color8);
            context.rolColors.Add(color9);
            context.rolColors.Add(color10);
            context.rolColors.Add(color11);
            context.rolColors.Add(color12);
            context.rolColors.Add(color13);
            context.rolColors.Add(color14);
            context.rolColors.Add(color15);
            context.rolColors.Add(color16);
            context.rolColors.Add(color17);
            context.rolColors.Add(color18);
            context.rolColors.Add(color19);
            context.rolTypes.Add(rolTypes);
            context.rolTypes.Add(rolTypes2);
            context.rolSize.Add(rolsizemini);
            context.rolSize.Add(rolsizemini2);
            context.rolSize.Add(rolsizemini3);
            context.rolSize.Add(rolsizemini4);
            context.rolSize.Add(rolsizemini5);
            context.rolSize.Add(rolsizemini6);
            context.rolSize.Add(rolsizemini7);
            context.rolSize.Add(rolsizemini8);
            context.rolSize.Add(rolsizemini9);
            context.rolSize.Add(rolsizemini10);
            context.rolSize.Add(rolsizemini11);
            context.rolSize.Add(rolsizemini12);
            context.rolSize.Add(rolsizemini13);
            context.rolSize.Add(rolsizemini14);
            context.rolSize.Add(rolsizemini15);
            context.rolSize.Add(rolsize16);
            context.rolSize.Add(rolsize17);
            context.rolSize.Add(rolsize18);
            context.rolSize.Add(rolsize19);
            context.rolSize.Add(rolsize20);
            context.rolSize.Add(rolsize21);
            context.rolSize.Add(rolsize22);
            context.rolSize.Add(rolsize23);
            context.rolSize.Add(rolsize24);
            context.rolSize.Add(rolsize25);
            context.rolSize.Add(rolsize26);
            context.rolcollection.Add(collectionColor1);
            context.rolcollection.Add(collectionColor2);
            context.rolcollection.Add(collectionColor3);
            context.rolcollection.Add(collectionColor4);
            context.rolcollection.Add(collectionColor5);
            context.rolcollection.Add(collectionColor6);
            context.rolcollection.Add(collectionColor7);
            context.rolcollection.Add(collectionColor8);
            context.rolcollection.Add(collectionColor9);
            context.rolcollection.Add(collectionColor10);

            context.SaveChanges();
        }
    }
}
