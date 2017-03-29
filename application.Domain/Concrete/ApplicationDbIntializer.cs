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
                Id = 1,
                Description = "Данная коллекция относится к категории классических рулонных штор. Отличительной чертой этой категории является огромное разнообразие фактур и цветов ткани, что позволит подобрать рольшторы под любой вкус. Классические рольшторы обладают светопроницаемостью приблизительно от 20% до 70% в зависимости от выбранного Вами цвета ткани. Светлые тона пропускают больше света и подходят в том случае, если Вы хотите создать в комнате уютную атмосферу в жаркий или солнечный день. Прямые солнечные лучи, в таком случае, не будут попадать в комнату, при этом, света будет вполне достаточно. Тёмные тона, в свою очередь, создадут в комнате атмосферу с приглушенным светом."
            };

            var category2 = new Rolcategory
            {
                Category = "День-Ночь",
                Id = 2,
                Description = "Данная коллекция относится к категории 'День-Ночь'. Такие рольшторы являются эффективным решением для регулирования количества света в помещении. Полотно ткани состоит из горизонтальных прозрачных и непрозрачных полос, чередуя которые, можно добиться той степени освещения в комнате, которая необходима Вам в данный момент. Кроме того, рольштору День - Ночь, так же как и классические рольшторы, можно полностью убрать вверх в тех случаях, когда в помещении не хватает света. Эти рольшторы обладают светопроницаемостью приблизительно от 20% до 70% в зависимости от выбранного Вами цвета ткани. Светлые тона пропускают больше света и подходят в том случае, если Вы хотите создать в комнате уютную атмосферу в жаркий или солнечный день. Тёмные тона, в свою очередь, создадут в комнате атмосферу с приглушенным светом."

            };
            var category3 = new Rolcategory
            {
                Category = "Блэкаут",
                Id = 3,
                 Description = "Данная коллекция относится к категории 'Блэкаут'. Эти рольшторы подходят для тех помещений, где необходимо создать иммитацию ночи, т.к. на тыльную сторону ткани нанесено покрытие, которое совсем не пропускает свет."
            };
            context.rolCategories.Add(category1);
            context.rolCategories.Add(category2);
            context.rolCategories.Add(category3);
            context.SaveChanges();
            var collection1 = new Product
            {
                Id = 1,
                Description = "",
                Name = "Амелия",
                Price = 10,
                CategoryEntity = category1

            };

            var collection2 = new Product
            {
                Id = 2,
                Description = "",
                Name = "Вода",
                Price = 20,
                CategoryEntity = category1
            };
            var collection3 = new Product
            {
                Id = 3,
                Description = "",
                Name = "Бамбус",
                Price = 20,
                CategoryEntity = category1
            };

            var collection4 = new Product
            {
                Id = 4,
                Description = "",
                Name = "Цветы",
                Price = 10,
                CategoryEntity = category1

            };

            var collection5 = new Product
            {
                Id = 5,
                Description = "",
                Name = "Классик-2",
                Price = 20,
                CategoryEntity = category1
            };
            var collection6 = new Product
            {
                Id = 6,
                Description = "",
                Name = "Кола",
                Price = 20,
                CategoryEntity = category1
            };
            var collection7 = new Product
            {
                Id = 7,
                Description = "",
                Name = "Лён",
                Price = 20,
                CategoryEntity = category1
            };
            var collection8 = new Product
            {
                Id = 8,
                Description = "",
                Name = "Маракеш",
                Price = 20,
                CategoryEntity = category1
            };
            var collection9 = new Product
            {
                Id = 9,
                Description = "",
                Name = "Перла",
                Price = 20,
                CategoryEntity = category1
            };
            var collection10 = new Product
            {
                Id = 10,
                Description = "",
                Name = "Престиж",
                Price = 20,
                CategoryEntity = category1
            };
            var collection11 = new Product
            {
                Id = 11,
                Description = "",
                Name = "Сара",
                Price = 20,
                CategoryEntity = category1
            };
            var collection12 = new Product
            {
                Id = 12,
                Description = "",
                Name = "Шантунг",
                Price = 20,
                CategoryEntity = category1
            };
            var collection13 = new Product
            {
                Id = 13,
                Description = "",
                Name = "Топаз",
                Price = 20,
                CategoryEntity = category1
            };
            var collection14 = new Product
            {
                Id = 14,
                Description = "В коллекции Блэкаут это прорезиненное покрытие, выполненное в том же цвете, что и ткань на лицевой стороне.",
                Name = "Блэкаут",
                Price = 20,
                CategoryEntity = category3
            };
            var collection15 = new Product
            {
                Id = 15,
                Description = "В коллекции Барок это серебристое светоотражающее покрытие, которое, вдобавок ко всему, отражает солнечные лучи и защищает помещение от нагревания в жаркие дни.",
                Name = "Барок",
                Price = 20,
                CategoryEntity = category3
            };
            var collection16 = new Product
            {
                Id = 16,
                Description = "",
                Name = "Багама-1",
                Price = 20,
                CategoryEntity = category2
            };
            var collection17 = new Product
            {
                Id = 17,
                Description = "",
                Name = "Багама",
                Price = 20,
                CategoryEntity = category2
            };
            var collection18 = new Product
            {
                Id = 18,
                Description = "",
                Name = "Багама-2",
                Price = 20,
                CategoryEntity = category2
            };
            var collection19 = new Product
            {
                Id = 19,
                Description = "",
                Name = "Классик-1",
                Price = 20,
                CategoryEntity = category1
            };
            var collection20 = new Product
            {
                Id = 20,
                Description = "",
                Name = "Меланж",
                Price = 20,
                CategoryEntity = category1
            };
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
            context.SaveChanges();
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
                Id = 12
            };
            var color13 = new Rolcolors
            {
                Color = "Желтый",
                Id = 13
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
            var color20 = new Rolcolors
            {
                Color = "Капучино",
                Id = 20
            };
            var color21 = new Rolcolors
            {
                Color = "Тёмно-Коричневый",
                Id = 21
            };
            var color22 = new Rolcolors
            {
                Color = "Графитовый",
                Id = 22
            };
            var color23 = new Rolcolors
            {
                Color = "Тёмно-Фиолетовый",
                Id = 23
            };
            var color24 = new Rolcolors
            {
                Color = "Светло-Фиолетовый",
                Id = 24
            };
            var color25 = new Rolcolors
            {
                Color = "Лавандовый",
                Id = 25
            };
            var color26 = new Rolcolors
            {
                Color = "Лазурный",
                Id = 26
            };
            var color27 = new Rolcolors
            {
                Color = "Натуральный",
                Id = 27
            };
            var color28 = new Rolcolors
            {
                Color = "Чёрный",
                Id = 28
            };
            var color29 = new Rolcolors
            {
                Color = "Тёмно-Жёлтый",
                Id = 29
            };
            var color30 = new Rolcolors
            {
                Color = "Тёмно-Бежевый",
                Id = 30
            };
            var color31 = new Rolcolors
            {
                Color = "Светло-Жёлтый",
                Id = 31
            };
            var color32 = new Rolcolors
            {
                Color = "Микс",
                Id = 32
            };
            var color33 = new Rolcolors
            {
                Color = "Персиковый",
                Id = 33
            };
            var color34 = new Rolcolors
            {
                Color = "Салатовый",
                Id = 34
            };
            var color35 = new Rolcolors
            {
                Color = "Розовый",
                Id = 35
            };
            var color36 = new Rolcolors
            {
                Color = "Гранатовый",
                Id = 36
            };
            var color37 = new Rolcolors
            {
                Color = "Гороховый",
                Id = 37
            };
            var color38 = new Rolcolors
            {
                Color = "Ореховый",
                Id = 38
            };
            var color39 = new Rolcolors
            {
                Color = "Шоколадный",
                Id = 39
            };
            var color40 = new Rolcolors
            {
                Color = "Морской",
                Id = 40
            };
            var color41 = new Rolcolors
            {
                Color = "Лимонный",
                Id = 41
            };
            var color42 = new Rolcolors
            {
                Color = "Солнечный Жёлтый",
                Id = 42
            };
            var color43 = new Rolcolors
            {
                Color = "Кофейный",
                Id = 43
            };
            var color44 = new Rolcolors
            {
                Color = "Лён Белый",
                Id = 44
            };
            var color45 = new Rolcolors
            {
                Color = "Лён Коричневый",
                Id = 45
            };
            var color46 = new Rolcolors
            {
                Color = "Лён Серый",
                Id = 46
            };
            var color47 = new Rolcolors
            {
                Color = "Венге",
                Id = 47
            };
            var color48 = new Rolcolors
            {
                Color = "Золотой",
                Id = 48
            };
            var color49 = new Rolcolors
            {
                Color = "Серебряный",
                Id = 49
            };
            var color50 = new Rolcolors
            {
                Color = "Стальной",
                Id = 50
            };
            var color51 = new Rolcolors
            {
                Color = "Медовый",
                Id = 51
            };
            var color52 = new Rolcolors
            {
                Color = "Мятный",
                Id = 52
            };
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
            context.rolColors.Add(color20);
            context.rolColors.Add(color21);
            context.rolColors.Add(color22);
            context.rolColors.Add(color23);
            context.rolColors.Add(color24);
            context.rolColors.Add(color25);
            context.rolColors.Add(color26);
            context.rolColors.Add(color27);
            context.rolColors.Add(color28);
            context.rolColors.Add(color29);
            context.rolColors.Add(color30);
            context.rolColors.Add(color31);
            context.rolColors.Add(color32);
            context.rolColors.Add(color33);
            context.rolColors.Add(color34);
            context.rolColors.Add(color35);
            context.rolColors.Add(color36);
            context.rolColors.Add(color37);
            context.rolColors.Add(color38);
            context.rolColors.Add(color39);
            context.rolColors.Add(color40);
            context.rolColors.Add(color41);
            context.rolColors.Add(color42);
            context.rolColors.Add(color43);
            context.rolColors.Add(color44);
            context.rolColors.Add(color45);
            context.rolColors.Add(color46);
            context.rolColors.Add(color47);
            context.rolColors.Add(color48);
            context.rolColors.Add(color49);
            context.rolColors.Add(color50);
            context.rolColors.Add(color51);
            context.rolColors.Add(color52);
            context.SaveChanges();
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
            context.rolTypes.Add(rolTypes);
            context.rolTypes.Add(rolTypes2);
            context.SaveChanges();
            var rolSizeMini = new Rolsize
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
            context.rolSize.Add(rolSizeMini);
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
            context.SaveChanges();
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
                number = "09"
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
            var collectionColor11 = new Rolcollection_colors
            {
                ID = 11,
                collectionEntity = collection2,
                colorsEntity = color11,
                number = "1839"
            };
            var collectionColor12 = new Rolcollection_colors
            {
                ID = 12,
                collectionEntity = collection2,
                colorsEntity = color12,
                number = "1840"
            };
            var collectionColor13 = new Rolcollection_colors
            {
                ID = 13,
                collectionEntity = collection2,
                colorsEntity = color5,
                number = "1844"
            };
            var collectionColor14 = new Rolcollection_colors
            {
                ID = 14,
                collectionEntity = collection2,
                colorsEntity = color7,
                number = "2010"
            };
            var collectionColor15 = new Rolcollection_colors
            {
                ID = 15,
                collectionEntity = collection2,
                colorsEntity = color13,
                number = "2072"
            };
            var collectionColor16 = new Rolcollection_colors
            {
                ID = 16,
                collectionEntity = collection2,
                colorsEntity = color14,
                number = "2073"
            };
            var collectionColor17 = new Rolcollection_colors
            {
                ID = 17,
                collectionEntity = collection2,
                colorsEntity = color15,
                number = "2074"
            };
            var collectionColor18 = new Rolcollection_colors
            {
                ID = 18,
                collectionEntity = collection2,
                colorsEntity = color3,
                number = "2106"
            };
            var collectionColor19 = new Rolcollection_colors
            {
                ID = 19,
                collectionEntity = collection2,
                colorsEntity = color16,
                number = "2200"
            };
            var collectionColor20 = new Rolcollection_colors
            {
                ID = 20,
                collectionEntity = collection2,
                colorsEntity = color17,
                number = "2202"
            };
            var collectionColor21 = new Rolcollection_colors
            {
                ID = 21,
                collectionEntity = collection2,
                colorsEntity = color18,
                number = "2090"
            };
            var collectionColor22 = new Rolcollection_colors
            {
                ID = 22,
                collectionEntity = collection2,
                colorsEntity = color1,
                number = "1834"
            };
            var collectionColor23 = new Rolcollection_colors
            {
                ID = 23,
                collectionEntity = collection2,
                colorsEntity = color42,
                number = "2080"
            };
            var collectionColor24 = new Rolcollection_colors
            {
                ID = 24,
                collectionEntity = collection3,
                colorsEntity = color19,
                number = "320"
            };
            var collectionColor25 = new Rolcollection_colors
            {
                ID = 25,
                collectionEntity = collection3,
                colorsEntity = color11,
                number = "321"
            };
            var collectionColor26 = new Rolcollection_colors
            {
                ID = 26,
                collectionEntity = collection3,
                colorsEntity = color20,
                number = "322"
            };
            var collectionColor27 = new Rolcollection_colors
            {
                ID = 27,
                collectionEntity = collection3,
                colorsEntity = color10,
                number = "323"
            };
            var collectionColor28 = new Rolcollection_colors
            {
                ID = 28,
                collectionEntity = collection3,
                colorsEntity = color21,
                number = "324"
            };
            var collectionColor29 = new Rolcollection_colors
            {
                ID = 29,
                collectionEntity = collection3,
                colorsEntity = color6,
                number = "325"
            };
            var collectionColor30 = new Rolcollection_colors
            {
                ID = 30,
                collectionEntity = collection4,
                colorsEntity = color19,
                number = "002"
            };
            var collectionColor31 = new Rolcollection_colors
            {
                ID = 31,
                collectionEntity = collection4,
                colorsEntity = color11,
                number = "866"
            };
            var collectionColor32 = new Rolcollection_colors
            {
                ID = 32,
                collectionEntity = collection4,
                colorsEntity = color16,
                number = "877"
            };
            var collectionColor33 = new Rolcollection_colors
            {
                ID = 33,
                collectionEntity = collection4,
                colorsEntity = color4,
                number = "911"
            };
            var collectionColor34 = new Rolcollection_colors
            {
                ID = 34,
                collectionEntity = collection4,
                colorsEntity = color22,
                number = "913"
            };
            var collectionColor35 = new Rolcollection_colors
            {
                ID = 35,
                collectionEntity = collection4,
                colorsEntity = color6,
                number = "924"
            };
            var collectionColor36 = new Rolcollection_colors
            {
                ID = 36,
                collectionEntity = collection4,
                colorsEntity = color18,
                number = "934"
            };
            var collectionColor37 = new Rolcollection_colors
            {
                ID = 37,
                collectionEntity = collection5,
                colorsEntity = color8,
                number = "007"
            };
            var collectionColor38 = new Rolcollection_colors
            {
                ID = 38,
                collectionEntity = collection5,
                colorsEntity = color23,
                number = "008"
            };
            var collectionColor39 = new Rolcollection_colors
            {
                ID = 39,
                collectionEntity = collection5,
                colorsEntity = color24,
                number = "009"
            };
            var collectionColor40 = new Rolcollection_colors
            {
                ID = 40,
                collectionEntity = collection5,
                colorsEntity = color25,
                number = "011"
            };
            var collectionColor41 = new Rolcollection_colors
            {
                ID = 41,
                collectionEntity = collection5,
                colorsEntity = color26,
                number = "017"
            };
            var collectionColor42 = new Rolcollection_colors
            {
                ID = 42,
                collectionEntity = collection5,
                colorsEntity = color27,
                number = "031"
            };
            var collectionColor43 = new Rolcollection_colors
            {
                ID = 43,
                collectionEntity = collection5,
                colorsEntity = color3,
                number = "032"
            };
            var collectionColor44 = new Rolcollection_colors
            {
                ID = 44,
                collectionEntity = collection5,
                colorsEntity = color28,
                number = "036"
            };
            var collectionColor45 = new Rolcollection_colors
            {
                ID = 45,
                collectionEntity = collection6,
                colorsEntity = color1,
                number = "01"
            };
            var collectionColor46 = new Rolcollection_colors
            {
                ID = 46,
                collectionEntity = collection6,
                colorsEntity = color19,
                number = "02"
            };
            var collectionColor47 = new Rolcollection_colors
            {
                ID = 47,
                collectionEntity = collection6,
                colorsEntity = color10,
                number = "03"
            };
            var collectionColor48 = new Rolcollection_colors
            {
                ID = 48,
                collectionEntity = collection6,
                colorsEntity = color3,
                number = "04"
            };
            var collectionColor49 = new Rolcollection_colors
            {
                ID = 49,
                collectionEntity = collection6,
                colorsEntity = color4,
                number = "05"
            };
            var collectionColor50 = new Rolcollection_colors
            {
                ID = 50,
                collectionEntity = collection6,
                colorsEntity = color5,
                number = "06"
            };
            var collectionColor51 = new Rolcollection_colors
            {
                ID = 51,
                collectionEntity = collection6,
                colorsEntity = color6,
                number = "07"
            };
            var collectionColor52 = new Rolcollection_colors
            {
                ID = 52,
                collectionEntity = collection6,
                colorsEntity = color7,
                number = "08"
            };
            var collectionColor53 = new Rolcollection_colors
            {
                ID = 53,
                collectionEntity = collection7,
                colorsEntity = color29,
                number = "852"
            };
            var collectionColor54 = new Rolcollection_colors
            {
                ID = 54,
                collectionEntity = collection7,
                colorsEntity = color12,
                number = "874"
            };
            var collectionColor55 = new Rolcollection_colors
            {
                ID = 55,
                collectionEntity = collection7,
                colorsEntity = color11,
                number = "875"
            };
            var collectionColor56 = new Rolcollection_colors
            {
                ID = 56,
                collectionEntity = collection7,
                colorsEntity = color30,
                number = "877"
            };
            var collectionColor57 = new Rolcollection_colors
            {
                ID = 57,
                collectionEntity = collection7,
                colorsEntity = color1,
                number = "881"
            };
            var collectionColor58 = new Rolcollection_colors
            {
                ID = 58,
                collectionEntity = collection7,
                colorsEntity = color9,
                number = "888"
            };
            var collectionColor59 = new Rolcollection_colors
            {
                ID = 59,
                collectionEntity = collection7,
                colorsEntity = color16,
                number = "2070"
            };
            var collectionColor60 = new Rolcollection_colors
            {
                ID = 60,
                collectionEntity = collection7,
                colorsEntity = color5,
                number = "2095"
            };
            var collectionColor61 = new Rolcollection_colors
            {
                ID = 61,
                collectionEntity = collection7,
                colorsEntity = color15,
                number = "2098"
            };
            var collectionColor62 = new Rolcollection_colors
            {
                ID = 62,
                collectionEntity = collection7,
                colorsEntity = color10,
                number = "2103"
            };
            var collectionColor63 = new Rolcollection_colors
            {
                ID = 63,
                collectionEntity = collection7,
                colorsEntity = color6,
                number = "2105"
            };
            var collectionColor64 = new Rolcollection_colors
            {
                ID = 64,
                collectionEntity = collection7,
                colorsEntity = color21,
                number = "2106"
            };
            var collectionColor65 = new Rolcollection_colors
            {
                ID = 65,
                collectionEntity = collection7,
                colorsEntity = color8,
                number = "2107"
            };
            var collectionColor66 = new Rolcollection_colors
            {
                ID = 66,
                collectionEntity = collection7,
                colorsEntity = color31,
                number = "2108"
            };
            var collectionColor67 = new Rolcollection_colors
            {
                ID = 67,
                collectionEntity = collection7,
                colorsEntity = color23,
                number = "2109"
            };
            var collectionColor68 = new Rolcollection_colors
            {
                ID = 68,
                collectionEntity = collection7,
                colorsEntity = color24,
                number = "2110"
            };
            var collectionColor69 = new Rolcollection_colors
            {
                ID = 69,
                collectionEntity = collection8,
                colorsEntity = color21,
                number = "02"
            };
            var collectionColor70 = new Rolcollection_colors
            {
                ID = 70,
                collectionEntity = collection8,
                colorsEntity = color10,
                number = "04"
            };
            var collectionColor71 = new Rolcollection_colors
            {
                ID = 71,
                collectionEntity = collection8,
                colorsEntity = color4,
                number = "11"
            };
            var collectionColor72 = new Rolcollection_colors
            {
                ID = 72,
                collectionEntity = collection8,
                colorsEntity = color11,
                number = "14"
            };
            var collectionColor73 = new Rolcollection_colors
            {
                ID = 73,
                collectionEntity = collection8,
                colorsEntity = color32,
                number = "15"
            };
            var collectionColor74 = new Rolcollection_colors
            {
                ID = 74,
                collectionEntity = collection9,
                colorsEntity = color1,
                number = "1800"
            };
            var collectionColor75 = new Rolcollection_colors
            {
                ID = 75,
                collectionEntity = collection9,
                colorsEntity = color33,
                number = "1816"
            };
            var collectionColor76 = new Rolcollection_colors
            {
                ID = 76,
                collectionEntity = collection9,
                colorsEntity = color12,
                number = "1817"
            };
            var collectionColor77 = new Rolcollection_colors
            {
                ID = 77,
                collectionEntity = collection9,
                colorsEntity = color34,
                number = "1861"
            };
            var collectionColor78 = new Rolcollection_colors
            {
                ID = 78,
                collectionEntity = collection9,
                colorsEntity = color17,
                number = "1862"
            };
            var collectionColor79 = new Rolcollection_colors
            {
                ID = 79,
                collectionEntity = collection9,
                colorsEntity = color5,
                number = "1865"
            };
            var collectionColor80 = new Rolcollection_colors
            {
                ID = 80,
                collectionEntity = collection9,
                colorsEntity = color30,
                number = "1869"
            };
            var collectionColor81 = new Rolcollection_colors
            {
                ID = 81,
                collectionEntity = collection9,
                colorsEntity = color9,
                number = "1873"
            };
            var collectionColor82 = new Rolcollection_colors
            {
                ID = 82,
                collectionEntity = collection9,
                colorsEntity = color6,
                number = "1875"
            };
            var collectionColor83 = new Rolcollection_colors
            {
                ID = 83,
                collectionEntity = collection9,
                colorsEntity = color35,
                number = "2070"
            };
            var collectionColor84 = new Rolcollection_colors
            {
                ID = 84,
                collectionEntity = collection9,
                colorsEntity = color7,
                number = "2079"
            };
            var collectionColor85 = new Rolcollection_colors
            {
                ID = 85,
                collectionEntity = collection9,
                colorsEntity = color4,
                number = "2082"
            };
            var collectionColor86 = new Rolcollection_colors
            {
                ID = 86,
                collectionEntity = collection9,
                colorsEntity = color36,
                number = "2083"
            };
            var collectionColor87 = new Rolcollection_colors
            {
                ID = 87,
                collectionEntity = collection9,
                colorsEntity = color13,
                number = "2806"
            };
            var collectionColor88 = new Rolcollection_colors
            {
                ID = 88,
                collectionEntity = collection9,
                colorsEntity = color37,
                number = "4279"
            };
            var collectionColor89 = new Rolcollection_colors
            {
                ID = 89,
                collectionEntity = collection9,
                colorsEntity = color3,
                number = "507"
            };
            var collectionColor90 = new Rolcollection_colors
            {
                ID = 90,
                collectionEntity = collection10,
                colorsEntity = color1,
                number = "01"
            };
            var collectionColor91 = new Rolcollection_colors
            {
                ID = 91,
                collectionEntity = collection10,
                colorsEntity = color6,
                number = "02"
            };
            var collectionColor92 = new Rolcollection_colors
            {
                ID = 92,
                collectionEntity = collection10,
                colorsEntity = color11,
                number = "03"
            };
            var collectionColor93 = new Rolcollection_colors
            {
                ID = 93,
                collectionEntity = collection10,
                colorsEntity = color10,
                number = "04"
            };
            var collectionColor94 = new Rolcollection_colors
            {
                ID = 94,
                collectionEntity = collection10,
                colorsEntity = color21,
                number = "05"
            };
            var collectionColor95 = new Rolcollection_colors
            {
                ID = 95,
                collectionEntity = collection10,
                colorsEntity = color32,
                number = "06"
            };
            var collectionColor96 = new Rolcollection_colors
            {
                ID = 96,
                collectionEntity = collection10,
                colorsEntity = color8,
                number = "07"
            };
            var collectionColor97 = new Rolcollection_colors
            {
                ID = 97,
                collectionEntity = collection11,
                colorsEntity = color4,
                number = "01"
            };
            var collectionColor98 = new Rolcollection_colors
            {
                ID = 98,
                collectionEntity = collection11,
                colorsEntity = color11,
                number = "02"
            };
            var collectionColor99 = new Rolcollection_colors
            {
                ID = 99,
                collectionEntity = collection11,
                colorsEntity = color38,
                number = "03"
            };
            var collectionColor100 = new Rolcollection_colors
            {
                ID = 100,
                collectionEntity = collection11,
                colorsEntity = color3,
                number = "04"
            };
            var collectionColor101 = new Rolcollection_colors
            {
                ID = 101,
                collectionEntity = collection11,
                colorsEntity = color39,
                number = "05"
            };
            var collectionColor102 = new Rolcollection_colors
            {
                ID = 102,
                collectionEntity = collection11,
                colorsEntity = color40,
                number = "06"
            };
            var collectionColor103 = new Rolcollection_colors
            {
                ID = 103,
                collectionEntity = collection12,
                colorsEntity = color19,
                number = "171"
            };
            var collectionColor104 = new Rolcollection_colors
            {
                ID = 104,
                collectionEntity = collection12,
                colorsEntity = color1,
                number = "172"
            };
            var collectionColor105 = new Rolcollection_colors
            {
                ID = 105,
                collectionEntity = collection12,
                colorsEntity = color2,
                number = "173"
            };
            var collectionColor106 = new Rolcollection_colors
            {
                ID = 106,
                collectionEntity = collection12,
                colorsEntity = color5,
                number = "174"
            };
            var collectionColor107 = new Rolcollection_colors
            {
                ID = 107,
                collectionEntity = collection12,
                colorsEntity = color41,
                number = "175"
            };
            var collectionColor108 = new Rolcollection_colors
            {
                ID = 108,
                collectionEntity = collection12,
                colorsEntity = color6,
                number = "176"
            };
            var collectionColor109 = new Rolcollection_colors
            {
                ID = 109,
                collectionEntity = collection12,
                colorsEntity = color12,
                number = "177"
            };
            var collectionColor110 = new Rolcollection_colors
            {
                ID = 110,
                collectionEntity = collection12,
                colorsEntity = color36,
                number = "178"
            };
            var collectionColor111 = new Rolcollection_colors
            {
                ID = 111,
                collectionEntity = collection13,
                colorsEntity = color1,
                number = "875"
            };
            var collectionColor112 = new Rolcollection_colors
            {
                ID = 112,
                collectionEntity = collection13,
                colorsEntity = color13,
                number = "057"
            };
            var collectionColor113 = new Rolcollection_colors
            {
                ID = 113,
                collectionEntity = collection13,
                colorsEntity = color2,
                number = "877"
            };
            var collectionColor114 = new Rolcollection_colors
            {
                ID = 114,
                collectionEntity = collection13,
                colorsEntity = color5,
                number = "232"
            };
            var collectionColor115 = new Rolcollection_colors
            {
                ID = 115,
                collectionEntity = collection13,
                colorsEntity = color17,
                number = "093"
            };
            var collectionColor116 = new Rolcollection_colors
            {
                ID = 116,
                collectionEntity = collection13,
                colorsEntity = color6,
                number = "873"
            };
            var collectionColor117 = new Rolcollection_colors
            {
                ID = 117,
                collectionEntity = collection14,
                colorsEntity = color19,
                number = "051"
            };
            var collectionColor118 = new Rolcollection_colors
            {
                ID = 118,
                collectionEntity = collection14,
                colorsEntity = color11,
                number = "053"
            };
            var collectionColor119 = new Rolcollection_colors
            {
                ID = 119,
                collectionEntity = collection14,
                colorsEntity = color4,
                number = "054"
            };
            var collectionColor120 = new Rolcollection_colors
            {
                ID = 120,
                collectionEntity = collection14,
                colorsEntity = color1,
                number = "056"
            };
            var collectionColor121 = new Rolcollection_colors
            {
                ID = 121,
                collectionEntity = collection14,
                colorsEntity = color13,
                number = "059"
            };
            var collectionColor122 = new Rolcollection_colors
            {
                ID = 122,
                collectionEntity = collection14,
                colorsEntity = color22,
                number = "061"
            };
            var collectionColor123 = new Rolcollection_colors
            {
                ID = 123,
                collectionEntity = collection14,
                colorsEntity = color6,
                number = "205"
            };
            var collectionColor124 = new Rolcollection_colors
            {
                ID = 124,
                collectionEntity = collection14,
                colorsEntity = color18,
                number = "206"
            };
            var collectionColor125 = new Rolcollection_colors
            {
                ID = 125,
                collectionEntity = collection15,
                colorsEntity = color1,
                number = "01"
            };
            var collectionColor126 = new Rolcollection_colors
            {
                ID = 126,
                collectionEntity = collection15,
                colorsEntity = color11,
                number = "02"
            };
            var collectionColor127 = new Rolcollection_colors
            {
                ID = 127,
                collectionEntity = collection15,
                colorsEntity = color4,
                number = "03"
            };
            var collectionColor128 = new Rolcollection_colors
            {
                ID = 128,
                collectionEntity = collection15,
                colorsEntity = color6,
                number = "04"
            };
            var collectionColor129 = new Rolcollection_colors
            {
                ID = 129,
                collectionEntity = collection16,
                colorsEntity = color1,
                number = "01"
            };
            var collectionColor130 = new Rolcollection_colors
            {
                ID = 130,
                collectionEntity = collection16,
                colorsEntity = color11,
                number = "02"
            };
            var collectionColor131 = new Rolcollection_colors
            {
                ID = 131,
                collectionEntity = collection16,
                colorsEntity = color43,
                number = "03"
            };
            var collectionColor132 = new Rolcollection_colors
            {
                ID = 132,
                collectionEntity = collection16,
                colorsEntity = color39,
                number = "04"
            };
            var collectionColor133 = new Rolcollection_colors
            {
                ID = 133,
                collectionEntity = collection16,
                colorsEntity = color6,
                number = "05"
            };
            var collectionColor134 = new Rolcollection_colors
            {
                ID = 134,
                collectionEntity = collection16,
                colorsEntity = color4,
                number = "06"
            };
            var collectionColor135 = new Rolcollection_colors
            {
                ID = 135,
                collectionEntity = collection16,
                colorsEntity = color44,
                number = "08"
            };
            var collectionColor136 = new Rolcollection_colors
            {
                ID = 136,
                collectionEntity = collection17,
                colorsEntity = color19,
                number = "10"
            };
            var collectionColor137 = new Rolcollection_colors
            {
                ID = 137,
                collectionEntity = collection17,
                colorsEntity = color45,
                number = "11"
            };
            var collectionColor138 = new Rolcollection_colors
            {
                ID = 138,
                collectionEntity = collection17,
                colorsEntity = color46,
                number = "12"
            };
            var collectionColor139 = new Rolcollection_colors
            {
                ID = 139,
                collectionEntity = collection17,
                colorsEntity = color11,
                number = "13"
            };
            var collectionColor140 = new Rolcollection_colors
            {
                ID = 140,
                collectionEntity = collection17,
                colorsEntity = color10,
                number = "14"
            };
            var collectionColor141 = new Rolcollection_colors
            {
                ID = 141,
                collectionEntity = collection17,
                colorsEntity = color21,
                number = "15"
            };
            var collectionColor142 = new Rolcollection_colors
            {
                ID = 142,
                collectionEntity = collection17,
                colorsEntity = color47,
                number = "16"
            };
            var collectionColor143 = new Rolcollection_colors
            {
                ID = 143,
                collectionEntity = collection17,
                colorsEntity = color40,
                number = "17"
            };
            var collectionColor144 = new Rolcollection_colors
            {
                ID = 144,
                collectionEntity = collection17,
                colorsEntity = color5,
                number = "18"
            };
            var collectionColor145 = new Rolcollection_colors
            {
                ID = 145,
                collectionEntity = collection17,
                colorsEntity = color7,
                number = "19"
            };
            var collectionColor146 = new Rolcollection_colors
            {
                ID = 146,
                collectionEntity = collection17,
                colorsEntity = color48,
                number = "30"
            };
            var collectionColor147 = new Rolcollection_colors
            {
                ID = 147,
                collectionEntity = collection17,
                colorsEntity = color49,
                number = "31"
            };
            var collectionColor148 = new Rolcollection_colors
            {
                ID = 148,
                collectionEntity = collection18,
                colorsEntity = color19,
                number = "21"
            };
            var collectionColor149 = new Rolcollection_colors
            {
                ID = 149,
                collectionEntity = collection18,
                colorsEntity = color1,
                number = "22"
            };
            var collectionColor150 = new Rolcollection_colors
            {
                ID = 150,
                collectionEntity = collection18,
                colorsEntity = color11,
                number = "23"
            };
            var collectionColor151 = new Rolcollection_colors
            {
                ID = 151,
                collectionEntity = collection18,
                colorsEntity = color5,
                number = "24"
            };
            var collectionColor152 = new Rolcollection_colors
            {
                ID = 152,
                collectionEntity = collection18,
                colorsEntity = color45,
                number = "25"
            };
            var collectionColor153 = new Rolcollection_colors
            {
                ID = 153,
                collectionEntity = collection18,
                colorsEntity = color46,
                number = "26"
            };
            var collectionColor154 = new Rolcollection_colors
            {
                ID = 154,
                collectionEntity = collection18,
                colorsEntity = color28,
                number = "27"
            };
            var collectionColor155 = new Rolcollection_colors
            {
                ID = 155,
                collectionEntity = collection18,
                colorsEntity = color50,
                number = "28"
            };
            var collectionColor156 = new Rolcollection_colors
            {
                ID = 156,
                collectionEntity = collection19,
                colorsEntity = color51,
                number = "002"
            };
            var collectionColor157 = new Rolcollection_colors
            {
                ID = 157,
                collectionEntity = collection19,
                colorsEntity = color9,
                number = "006"
            };
            var collectionColor158 = new Rolcollection_colors
            {
                ID = 158,
                collectionEntity = collection19,
                colorsEntity = color1,
                number = "025"
            };
            var collectionColor159 = new Rolcollection_colors
            {
                ID = 159,
                collectionEntity = collection19,
                colorsEntity = color4,
                number = "602"
            };
            var collectionColor160 = new Rolcollection_colors
            {
                ID = 160,
                collectionEntity = collection19,
                colorsEntity = color16,
                number = "604"
            };
            var collectionColor161 = new Rolcollection_colors
            {
                ID = 161,
                collectionEntity = collection19,
                colorsEntity = color11,
                number = "605"
            };
            var collectionColor162 = new Rolcollection_colors
            {
                ID = 162,
                collectionEntity = collection19,
                colorsEntity = color31,
                number = "606"
            };
            var collectionColor163 = new Rolcollection_colors
            {
                ID = 163,
                collectionEntity = collection19,
                colorsEntity = color29,
                number = "608"
            };
            var collectionColor164 = new Rolcollection_colors
            {
                ID = 164,
                collectionEntity = collection19,
                colorsEntity = color14,
                number = "611"
            };
            var collectionColor165 = new Rolcollection_colors
            {
                ID = 165,
                collectionEntity = collection19,
                colorsEntity = color36,
                number = "613"
            };
            var collectionColor166 = new Rolcollection_colors
            {
                ID = 166,
                collectionEntity = collection19,
                colorsEntity = color35,
                number = "614"
            };
            var collectionColor167 = new Rolcollection_colors
            {
                ID = 167,
                collectionEntity = collection19,
                colorsEntity = color5,
                number = "618"
            };
            var collectionColor168 = new Rolcollection_colors
            {
                ID = 168,
                collectionEntity = collection19,
                colorsEntity = color12,
                number = "621"
            };
            var collectionColor169 = new Rolcollection_colors
            {
                ID = 169,
                collectionEntity = collection19,
                colorsEntity = color6,
                number = "622"
            };
            var collectionColor170 = new Rolcollection_colors
            {
                ID = 170,
                collectionEntity = collection20,
                colorsEntity = color21,
                number = "01"
            };
            var collectionColor171 = new Rolcollection_colors
            {
                ID = 171,
                collectionEntity = collection20,
                colorsEntity = color4,
                number = "02"
            };
            var collectionColor172 = new Rolcollection_colors
            {
                ID = 172,
                collectionEntity = collection20,
                colorsEntity = color11,
                number = "03"
            };
            var collectionColor173 = new Rolcollection_colors
            {
                ID = 173,
                collectionEntity = collection20,
                colorsEntity = color18,
                number = "04"
            };
            var collectionColor174 = new Rolcollection_colors
            {
                ID = 174,
                collectionEntity = collection20,
                colorsEntity = color35,
                number = "05"
            };
            var collectionColor175 = new Rolcollection_colors
            {
                ID = 175,
                collectionEntity = collection20,
                colorsEntity = color10,
                number = "06"
            };
            var collectionColor176 = new Rolcollection_colors
            {
                ID = 176,
                collectionEntity = collection20,
                colorsEntity = color52,
                number = "07"
            };
            var collectionColor177 = new Rolcollection_colors
            {
                ID = 177,
                collectionEntity = collection20,
                colorsEntity = color36,
                number = "08"
            };
            var collectionColor178 = new Rolcollection_colors
            {
                ID = 178,
                collectionEntity = collection20,
                colorsEntity = color22,
                number = "09"
            };

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
            context.rolcollection.Add(collectionColor11);
            context.rolcollection.Add(collectionColor12);
            context.rolcollection.Add(collectionColor13);
            context.rolcollection.Add(collectionColor14);
            context.rolcollection.Add(collectionColor15);
            context.rolcollection.Add(collectionColor16);
            context.rolcollection.Add(collectionColor17);
            context.rolcollection.Add(collectionColor18);
            context.rolcollection.Add(collectionColor19);
            context.rolcollection.Add(collectionColor20);
            context.rolcollection.Add(collectionColor21);
            context.rolcollection.Add(collectionColor22);
            context.rolcollection.Add(collectionColor23);
            context.rolcollection.Add(collectionColor24);
            context.rolcollection.Add(collectionColor25);
            context.rolcollection.Add(collectionColor26);
            context.rolcollection.Add(collectionColor27);
            context.rolcollection.Add(collectionColor28);
            context.rolcollection.Add(collectionColor29);
            context.rolcollection.Add(collectionColor30);
            context.rolcollection.Add(collectionColor31);
            context.rolcollection.Add(collectionColor32);
            context.rolcollection.Add(collectionColor33);
            context.rolcollection.Add(collectionColor34);
            context.rolcollection.Add(collectionColor35);
            context.rolcollection.Add(collectionColor36);
            context.rolcollection.Add(collectionColor37);
            context.rolcollection.Add(collectionColor38);
            context.rolcollection.Add(collectionColor39);
            context.rolcollection.Add(collectionColor40);
            context.rolcollection.Add(collectionColor41);
            context.rolcollection.Add(collectionColor42);
            context.rolcollection.Add(collectionColor43);
            context.rolcollection.Add(collectionColor44);
            context.rolcollection.Add(collectionColor45);
            context.rolcollection.Add(collectionColor46);
            context.rolcollection.Add(collectionColor47);
            context.rolcollection.Add(collectionColor48);
            context.rolcollection.Add(collectionColor49);
            context.rolcollection.Add(collectionColor50);
            context.rolcollection.Add(collectionColor51);
            context.rolcollection.Add(collectionColor52);
            context.rolcollection.Add(collectionColor53);
            context.rolcollection.Add(collectionColor54);
            context.rolcollection.Add(collectionColor55);
            context.rolcollection.Add(collectionColor56);
            context.rolcollection.Add(collectionColor57);
            context.rolcollection.Add(collectionColor58);
            context.rolcollection.Add(collectionColor59);
            context.rolcollection.Add(collectionColor60);
            context.rolcollection.Add(collectionColor61);
            context.rolcollection.Add(collectionColor62);
            context.rolcollection.Add(collectionColor63);
            context.rolcollection.Add(collectionColor64);
            context.rolcollection.Add(collectionColor65);
            context.rolcollection.Add(collectionColor66);
            context.rolcollection.Add(collectionColor67);
            context.rolcollection.Add(collectionColor68);
            context.rolcollection.Add(collectionColor69);
            context.rolcollection.Add(collectionColor70);
            context.rolcollection.Add(collectionColor71);
            context.rolcollection.Add(collectionColor72);
            context.rolcollection.Add(collectionColor73);
            context.rolcollection.Add(collectionColor74);
            context.rolcollection.Add(collectionColor75);
            context.rolcollection.Add(collectionColor76);
            context.rolcollection.Add(collectionColor77);
            context.rolcollection.Add(collectionColor78);
            context.rolcollection.Add(collectionColor79);
            context.rolcollection.Add(collectionColor80);
            context.rolcollection.Add(collectionColor81);
            context.rolcollection.Add(collectionColor82);
            context.rolcollection.Add(collectionColor83);
            context.rolcollection.Add(collectionColor84);
            context.rolcollection.Add(collectionColor85);
            context.rolcollection.Add(collectionColor86);
            context.rolcollection.Add(collectionColor87);
            context.rolcollection.Add(collectionColor88);
            context.rolcollection.Add(collectionColor89);
            context.rolcollection.Add(collectionColor90);
            context.rolcollection.Add(collectionColor91);
            context.rolcollection.Add(collectionColor92);
            context.rolcollection.Add(collectionColor93);
            context.rolcollection.Add(collectionColor94);
            context.rolcollection.Add(collectionColor95);
            context.rolcollection.Add(collectionColor96);
            context.rolcollection.Add(collectionColor97);
            context.rolcollection.Add(collectionColor98);
            context.rolcollection.Add(collectionColor99);
            context.rolcollection.Add(collectionColor100);
            context.rolcollection.Add(collectionColor101);
            context.rolcollection.Add(collectionColor102);
            context.rolcollection.Add(collectionColor103);
            context.rolcollection.Add(collectionColor104);
            context.rolcollection.Add(collectionColor105);
            context.rolcollection.Add(collectionColor106);
            context.rolcollection.Add(collectionColor107);
            context.rolcollection.Add(collectionColor108);
            context.rolcollection.Add(collectionColor109);
            context.rolcollection.Add(collectionColor110);
            context.rolcollection.Add(collectionColor111);
            context.rolcollection.Add(collectionColor112);
            context.rolcollection.Add(collectionColor113);
            context.rolcollection.Add(collectionColor114);
            context.rolcollection.Add(collectionColor115);
            context.rolcollection.Add(collectionColor116);
            context.rolcollection.Add(collectionColor117);
            context.rolcollection.Add(collectionColor118);
            context.rolcollection.Add(collectionColor119);
            context.rolcollection.Add(collectionColor120);
            context.rolcollection.Add(collectionColor121);
            context.rolcollection.Add(collectionColor122);
            context.rolcollection.Add(collectionColor123);
            context.rolcollection.Add(collectionColor124);
            context.rolcollection.Add(collectionColor125);
            context.rolcollection.Add(collectionColor126);
            context.rolcollection.Add(collectionColor127);
            context.rolcollection.Add(collectionColor128);
            context.rolcollection.Add(collectionColor129);
            context.rolcollection.Add(collectionColor130);
            context.rolcollection.Add(collectionColor131);
            context.rolcollection.Add(collectionColor132);
            context.rolcollection.Add(collectionColor133);
            context.rolcollection.Add(collectionColor134);
            context.rolcollection.Add(collectionColor135);
            context.rolcollection.Add(collectionColor136);
            context.rolcollection.Add(collectionColor137);
            context.rolcollection.Add(collectionColor138);
            context.rolcollection.Add(collectionColor139);
            context.rolcollection.Add(collectionColor140);
            context.rolcollection.Add(collectionColor141);
            context.rolcollection.Add(collectionColor142);
            context.rolcollection.Add(collectionColor143);
            context.rolcollection.Add(collectionColor144);
            context.rolcollection.Add(collectionColor145);
            context.rolcollection.Add(collectionColor146);
            context.rolcollection.Add(collectionColor147);
            context.rolcollection.Add(collectionColor148);
            context.rolcollection.Add(collectionColor149);
            context.rolcollection.Add(collectionColor150);
            context.rolcollection.Add(collectionColor151);
            context.rolcollection.Add(collectionColor152);
            context.rolcollection.Add(collectionColor153);
            context.rolcollection.Add(collectionColor154);
            context.rolcollection.Add(collectionColor155);
            context.rolcollection.Add(collectionColor156);
            context.rolcollection.Add(collectionColor157);
            context.rolcollection.Add(collectionColor158);
            context.rolcollection.Add(collectionColor159);
            context.rolcollection.Add(collectionColor160);
            context.rolcollection.Add(collectionColor161);
            context.rolcollection.Add(collectionColor162);
            context.rolcollection.Add(collectionColor163);
            context.rolcollection.Add(collectionColor164);
            context.rolcollection.Add(collectionColor165);
            context.rolcollection.Add(collectionColor166);
            context.rolcollection.Add(collectionColor167);
            context.rolcollection.Add(collectionColor168);
            context.rolcollection.Add(collectionColor169);
            context.rolcollection.Add(collectionColor170);
            context.rolcollection.Add(collectionColor171);
            context.rolcollection.Add(collectionColor172);
            context.rolcollection.Add(collectionColor173);
            context.rolcollection.Add(collectionColor174);
            context.rolcollection.Add(collectionColor175);
            context.rolcollection.Add(collectionColor176);
            context.rolcollection.Add(collectionColor177);
            context.rolcollection.Add(collectionColor178);

            context.SaveChanges();
        }
    }
}
