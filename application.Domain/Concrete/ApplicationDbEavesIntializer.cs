using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    class ApplicationDbEavesIntializer : DropCreateDatabaseAlways<EFDbEavesContex>
    {
        protected override void Seed(EFDbEavesContex context)
        {
            var pipe1 = new Pipe
            {
                Id = 1,
                PipesName = "Гладкая"
            };
            var pipe2 = new Pipe
            {
                Id = 2,
                PipesName = "Рифлёная"
            };
            var pipe3 = new Pipe
            {
                Id = 3,
                PipesName = "Твистер"
            };
            var pipe4 = new Pipe
            {
                Id = 4,
                PipesName = "Кросс-Твистер"
            };
            var pipe5 = new Pipe
            {
                Id = 5,
                PipesName = "Венге"
            };
            var pipe6 = new Pipe
            {
                Id = 6,
                PipesName = "Гладкая Квадро"
            };
            var pipe7 = new Pipe
            {
                Id = 7,
                PipesName = "Гладкая Оникс"
            };
            var pipe8 = new Pipe
            {
                Id = 8,
                PipesName = "Плоский Профиль"
            };
            context.Pipes.Add(pipe1);
            context.Pipes.Add(pipe2);
            context.Pipes.Add(pipe3);
            context.Pipes.Add(pipe4);
            context.Pipes.Add(pipe5);
            context.Pipes.Add(pipe6);
            context.Pipes.Add(pipe7);
            context.Pipes.Add(pipe8);
            context.SaveChanges();
            var eavesCategoty1 = new EavesCatogory
            {
                Id = 1,
                Name = "Круглые"
            };
            var eavesCategory2 = new EavesCatogory
            {
                Id = 2,
                Name = "Квадратные"
            };
            var eavesCategory3 = new EavesCatogory
            {
                Id = 3,
                Name = "Плоский Профиль"
            };
            context.EavesCatogories.Add(eavesCategoty1);
            context.EavesCatogories.Add(eavesCategory2);
            context.EavesCatogories.Add(eavesCategory3);
            context.SaveChanges();
            var series1 = new EavesCollection
            {
                Id = 1,
                Name = "16мм",
                Details = "<strong>Металлические карнизы &Oslash;16мм</strong> отлично подойдут для небольших помещений с шириной стены и высотой потолка не более 3х метров. Диаметр трубы 16мм - идеальный выбор для кухни или небольшой жилой комнаты. Разнообразие цветов и видов труб, а также большое количество наконечников, позволит выбрать карниз, подходящий любому стилю интерьера: от классического и кантри до хай-тек. Установка данного типа карнизов может осуществляться как на стеновых, так и на потолочных кронштейнах. По количеству рядов, карнизы Ø16мм могут быть одинарными, двойными или тройными.< p > Все карнизы < strong > польской фабрики Marcin Dekor </ strong > проходят специальную обработку и имеют < strong > гальваническое покрытие.</ strong > Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии.Кроме того, < strong > гальваническое покрытие </ strong > придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</ p >",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series2 = new EavesCollection
            {
                Id = 2,
                Name = "19мм",
                Details = "<strong>Кованые металлические карнизы Ø19мм</strong>  пользуются большой популярностью, благодаря своим универсальным свойствам. Данный диаметр карниза отлично подойдет как для больших, так и для маленьких комнат с небольшой высотой потолка. Многообразие форм, видов труб и наконечников позволит подобрать карниз для любого стиля интерьера: от классического до хай-тек.< p > Все карнизы < strong > польской фабрики Marcin Dekor </ strong > проходят специальную обработку и имеют < strong > гальваническое покрытие.</ strong > Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии.Кроме того, < strong > гальваническое покрытие </ strong > придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</ p >",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series3 = new EavesCollection
            {
                Id = 3,
                Name = "25мм",
                Details = "Test details3",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series4 = new EavesCollection
            {
                Id = 4,
                Name = "Квадро",
                Details = "Test details4",
                eavesCategoriesEntity = eavesCategory2,
                eavesVendorsEntity = null
            };
            var series5 = new EavesCollection
            {
                Id = 5,
                Name = "Оникс 19мм",
                Details = "Test details4",
                eavesCategoriesEntity = eavesCategory2,
                eavesVendorsEntity = null
            };
            var series6 = new EavesCollection
            {
                Id = 6,
                Name = "Оникс 25мм",
                Details = "Test details4",
                eavesCategoriesEntity = eavesCategory2,
                eavesVendorsEntity = null
            };
            var series7 = new EavesCollection
            {
                Id = 7,
                Name = "Square Line (Свайер Лайн)",
                Details = "",
                eavesCategoriesEntity = eavesCategory3,
                eavesVendorsEntity = null
            };
            context.EavesCollections.Add(series1);
            context.EavesCollections.Add(series2);
            context.EavesCollections.Add(series3);
            context.EavesCollections.Add(series4);
            context.EavesCollections.Add(series5);
            context.EavesCollections.Add(series6);
            context.EavesCollections.Add(series7);
            context.SaveChanges();
            var item1 = new EavesItem
            {
                Id = 1,
                Name = "Кула Кристалл"
            };
            var item2 = new EavesItem
            {
                Id = 2,
                Name = "Кристалл"
            };
            var item3 = new EavesItem
            {
                Id = 3,
                Name = "Аллюр"
            };
            var item4 = new EavesItem
            {
                Id = 4,
                Name = "Кларион"
            };
            var item5 = new EavesItem
            {
                Id = 5,
                Name = "Сириус"
            };
            var item6 = new EavesItem
            {
                Id = 6,
                Name = "Цилиндр"
            };
            var item7 = new EavesItem
            {
                Id = 7,
                Name = "Сигма"
            };
            var item8 = new EavesItem
            {
                Id = 8,
                Name = "Линея"
            };
            var item9 = new EavesItem
            {
                Id = 9,
                Name = "Валео"
            };
            var item10 = new EavesItem
            {
                Id = 10,
                Name = "Мелба"
            };
            var item11 = new EavesItem
            {
                Id = 11,
                Name = "Севилла"
            };
            var item12 = new EavesItem
            {
                Id = 12,
                Name = "Принц"
            };
            var item13 = new EavesItem
            {
                Id = 13,
                Name = "Лукка"
            };
            var item14 = new EavesItem
            {
                Id = 14,
                Name = "Галазка"
            };
            var item15 = new EavesItem
            {
                Id = 15,
                Name = "Беллуно Мини"
            };
            var item16 = new EavesItem
            {
                Id = 16,
                Name = "Паола"
            };
            var item17 = new EavesItem
            {
                Id = 17,
                Name = "Баваро"
            };
            var item18 = new EavesItem
            {
                Id = 18,
                Name = "Клён"
            };
            var item19 = new EavesItem
            {
                Id = 19,
                Name = "Ареззо"
            };
            var item20 = new EavesItem
            {
                Id = 20,
                Name = "Зевс"
            };
            var item21 = new EavesItem
            {
                Id = 21,
                Name = "Дафне"
            };
            var item22 = new EavesItem
            {
                Id = 22,
                Name = "Диана"
            };
            var item23 = new EavesItem
            {
                Id = 23,
                Name = "Фламинго"
            };
            var item24 = new EavesItem
            {
                Id = 24,
                Name = "Квадро"
            };
            var item25 = new EavesItem
            {
                Id = 25,
                Name = "Луна"
            };
            var item26 = new EavesItem
            {
                Id = 26,
                Name = "Орион"
            };
            var item27 = new EavesItem
            {
                Id = 27,
                Name = "Свеча"
            };
            var item28 = new EavesItem
            {
                Id = 28,
                Name = "Модель V"
            };
            var item29 = new EavesItem
            {
                Id = 29,
                Name = "Орфеус"
            };
            var item30 = new EavesItem
            {
                Id = 30,
                Name = "Тоди Макс"
            };
            var item31 = new EavesItem
            {
                Id = 31,
                Name = "Твистер"
            };
            var item35 = new EavesItem
            {
                Id = 35,
                Name = "Беллуно"
            };
            var item36 = new EavesItem
            {
                Id = 36,
                Name = "Картер"
            };
            var item37 = new EavesItem
            {
                Id = 37,
                Name = "Флора"
            };
            var item38 = new EavesItem
            {
                Id = 38,
                Name = "Галаз"
            };
            var item39 = new EavesItem
            {
                Id = 39,
                Name = "Люксор"
            };
            var item40 = new EavesItem
            {
                Id = 40,
                Name = "Вега"
            };
            var item41 = new EavesItem
            {
                Id = 41,
                Name = "Верди"
            };
            var item42 = new EavesItem
            {
                Id = 42,
                Name = "Ксантос"
            };
            var item43 = new EavesItem
            {
                Id = 43,
                Name = "Бизетт"
            };
            var item44 = new EavesItem
            {
                Id = 44,
                Name = "Лиллет"
            };
            var item45 = new EavesItem
            {
                Id = 45,
                Name = "Делия"
            };
            var item46 = new EavesItem
            {
                Id = 46,
                Name = "Алмеро"
            };
            var item47 = new EavesItem
            {
                Id = 47,
                Name = "Бостон"
            };
            var item48 = new EavesItem
            {
                Id = 48,
                Name = "Дункан"
            };
            var item49 = new EavesItem
            {
                Id = 49,
                Name = "Дива"
            };
            var item50 = new EavesItem
            {
                Id = 50,
                Name = "Интегра"
            };
            var item51 = new EavesItem
            {
                Id = 51,
                Name = "Одеон"
            };
            var item52 = new EavesItem
            {
                Id = 52,
                Name = "Палацио"
            };
            var item53 = new EavesItem
            {
                Id = 53,
                Name = "Свинг"
            };
            var item54 = new EavesItem
            {
                Id = 54,
                Name = "Венус"
            };
            var item55 = new EavesItem
            {
                Id = 55,
                Name = "Верона"
            };
            var item56 = new EavesItem
            {
                Id = 56,
                Name = "Версус"
            };
            var item57 = new EavesItem
            {
                Id = 57,
                Name = "Вена"
            };
            var item58 = new EavesItem
            {
                Id = 58,
                Name = "Фаберже"
            };
            var item59 = new EavesItem
            {
                Id = 59,
                Name = "Симпл Дуо"
            };
            var item60 = new EavesItem
            {
                Id = 60,
                Name = "Азарро"
            };
            var item61 = new EavesItem
            {
                Id = 61,
                Name = "Квадро Кристалл"
            };
            var item62 = new EavesItem
            {
                Id = 62,
                Name = "Стратус"
            };
            var item63 = new EavesItem
            {
                Id = 63,
                Name = "Тоска"
            };
            var item64 = new EavesItem
            {
                Id = 64,
                Name = "Трезано"
            };
            var item65 = new EavesItem
            {
                Id = 65,
                Name = "Занотти"
            };
            var item66 = new EavesItem
            {
                Id = 66,
                Name = "Ксантос"
            };
            var item67 = new EavesItem
            {
                Id = 67,
                Name = "Картер"
            };
            var item68 = new EavesItem
            {
                Id = 68,
                Name = "Аллюр"
            };
            var item69 = new EavesItem
            {
                Id = 69,
                Name = "Модуло"
            };
            var item70 = new EavesItem
            {
                Id = 70,
                Name = "Сиенна"
            };
            var item71 = new EavesItem
            {
                Id = 71,
                Name = "Q-Art (Белый Кристалл)"
            };
            var item72 = new EavesItem
            {
                Id = 72,
                Name = "Q-Art (Черный Кристалл)"
            };
            var item73 = new EavesItem
            {
                Id = 73,
                Name = "Q-Art (Янтарный Кристалл)"
            };
            var item74 = new EavesItem
            {
                Id = 74,
                Name = "Square (Сквайер)"
            };
            var item75 = new EavesItem
            {
                Id = 75,
                Name = "Artis (Артис)"
            };
            var item76 = new EavesItem
            {
                Id = 76,
                Name = "G-Tech (Джи-Тех)"
            };
            var item77 = new EavesItem
            {
                Id = 77,
                Name = "Boss"
            };
            var item78 = new EavesItem
            {
                Id = 78,
                Name = "Boss-1"
            };
            var item79 = new EavesItem
            {
                Id = 79,
                Name = "Boss-2"
            };
            var item80 = new EavesItem
            {
                Id = 80,
                Name = "Boss Duo-1"
            };
            var item81 = new EavesItem
            {
                Id = 81,
                Name = "Boss Duo-2"
            };
            context.EavesItems.Add(item1);
            context.EavesItems.Add(item2);
            context.EavesItems.Add(item3);
            context.EavesItems.Add(item4);
            context.EavesItems.Add(item5);
            context.EavesItems.Add(item6);
            context.EavesItems.Add(item7);
            context.EavesItems.Add(item8);
            context.EavesItems.Add(item9);
            context.EavesItems.Add(item10);
            context.EavesItems.Add(item11);
            context.EavesItems.Add(item12);
            context.EavesItems.Add(item13);
            context.EavesItems.Add(item14);
            context.EavesItems.Add(item15);
            context.EavesItems.Add(item16);
            context.EavesItems.Add(item17);
            context.EavesItems.Add(item18);
            context.EavesItems.Add(item19);
            context.EavesItems.Add(item20);
            context.EavesItems.Add(item21);
            context.EavesItems.Add(item22);
            context.EavesItems.Add(item23);
            context.EavesItems.Add(item24);
            context.EavesItems.Add(item25);
            context.EavesItems.Add(item26);
            context.EavesItems.Add(item27);
            context.EavesItems.Add(item28);
            context.EavesItems.Add(item29);
            context.EavesItems.Add(item30);
            context.EavesItems.Add(item31);
            context.EavesItems.Add(item35);
            context.EavesItems.Add(item36);
            context.EavesItems.Add(item37);
            context.EavesItems.Add(item38);
            context.EavesItems.Add(item39);
            context.EavesItems.Add(item40);
            context.EavesItems.Add(item41);
            context.EavesItems.Add(item42);
            context.EavesItems.Add(item43);
            context.EavesItems.Add(item44);
            context.EavesItems.Add(item45);
            context.EavesItems.Add(item46);
            context.EavesItems.Add(item47);
            context.EavesItems.Add(item48);
            context.EavesItems.Add(item49);
            context.EavesItems.Add(item50);
            context.EavesItems.Add(item51);
            context.EavesItems.Add(item52);
            context.EavesItems.Add(item53);
            context.EavesItems.Add(item54);
            context.EavesItems.Add(item55);
            context.EavesItems.Add(item56);
            context.EavesItems.Add(item57);
            context.EavesItems.Add(item58);
            context.EavesItems.Add(item59);
            context.EavesItems.Add(item60);
            context.EavesItems.Add(item61);
            context.EavesItems.Add(item62);
            context.EavesItems.Add(item63);
            context.EavesItems.Add(item64);
            context.EavesItems.Add(item65);
            context.EavesItems.Add(item66);
            context.EavesItems.Add(item67);
            context.EavesItems.Add(item68);
            context.EavesItems.Add(item69);
            context.EavesItems.Add(item70);
            context.EavesItems.Add(item71);
            context.EavesItems.Add(item72);
            context.EavesItems.Add(item73);
            context.EavesItems.Add(item74);
            context.EavesItems.Add(item75);
            context.EavesItems.Add(item76);
            context.EavesItems.Add(item77);
            context.EavesItems.Add(item78);
            context.EavesItems.Add(item79);
            context.EavesItems.Add(item80);
            context.EavesItems.Add(item81);
            context.SaveChanges();
            var collectionItem1 = new EavesCollectionItem
            {
                Id = 1,
                Description = "Test description",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item1
            };
            var collectionItem2 = new EavesCollectionItem
            {
                Id = 2,
                Description = "Test description",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item2
            };
            var collectionItem3 = new EavesCollectionItem
            {
                Id = 3,
                Description = "Test description",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item3
            };
            var collectionItem4 = new EavesCollectionItem
            {
                Id = 4,
                Description = "Test description",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item4
            };
            var collectionItem5 = new EavesCollectionItem
            {
                Id = 5,
                Description = "Test description",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item5
            };
            var collectionItem6 = new EavesCollectionItem
            {
                Id = 6,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item6
            };
            var collectionItem7 = new EavesCollectionItem
            {
                Id = 7,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item7
            };
            var collectionItem8 = new EavesCollectionItem
            {
                Id = 8,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item8
            };
            var collectionItem9 = new EavesCollectionItem
            {
                Id = 9,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item9
            };
            var collectionItem10 = new EavesCollectionItem
            {
                Id = 10,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item10
            };
            var collectionItem11 = new EavesCollectionItem
            {
                Id = 11,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item11
            };
            var collectionItem12 = new EavesCollectionItem
            {
                Id = 12,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item12
            };
            var collectionItem13 = new EavesCollectionItem
            {
                Id = 13,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item13
            };
            var collectionItem14 = new EavesCollectionItem
            {
                Id = 14,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item14
            };
            var collectionItem15 = new EavesCollectionItem
            {
                Id = 15,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item15
            };
            var collectionItem16 = new EavesCollectionItem
            {
                Id = 16,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item16
            };
            var collectionItem17 = new EavesCollectionItem
            {
                Id = 17,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item17
            };
            var collectionItem18 = new EavesCollectionItem
            {
                Id = 18,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item18
            };
            var collectionItem19 = new EavesCollectionItem
            {
                Id = 19,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item19
            };
            var collectionItem20 = new EavesCollectionItem
            {
                Id = 20,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item20
            };
            var collectionItem21 = new EavesCollectionItem
            {
                Id = 21,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item21
            };
            var collectionItem22 = new EavesCollectionItem
            {
                Id = 22,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item22
            };
            var collectionItem23 = new EavesCollectionItem
            {
                Id = 23,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item23
            };
            var collectionItem24 = new EavesCollectionItem
            {
                Id = 24,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item24
            };
            var collectionItem25 = new EavesCollectionItem
            {
                Id = 25,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item25
            };
            var collectionItem26 = new EavesCollectionItem
            {
                Id = 26,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item26
            };
            var collectionItem27 = new EavesCollectionItem
            {
                Id = 27,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item27
            };
            var collectionItem28 = new EavesCollectionItem
            {
                Id = 28,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item28
            };
            var collectionItem29 = new EavesCollectionItem
            {
                Id = 29,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item29
            };
            var collectionItem30 = new EavesCollectionItem
            {
                Id = 30,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item30
            };
            var collectionItem31 = new EavesCollectionItem
            {
                Id = 31,
                Description = "",
                eavesCollectionEntity = series1,
                eavesItemsEntity = item31
            };
            var collectionItem32 = new EavesCollectionItem
            {
                Id = 32,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item3
            };
            var collectionItem33 = new EavesCollectionItem
            {
                Id = 33,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item35
            };
            var collectionItem34 = new EavesCollectionItem
            {
                Id = 34,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item36
            };
            var collectionItem35 = new EavesCollectionItem
            {
                Id = 35,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item37
            };
            var collectionItem36 = new EavesCollectionItem
            {
                Id = 36,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item38
            };
            var collectionItem37 = new EavesCollectionItem
            {
                Id = 37,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item1
            };
            var collectionItem38 = new EavesCollectionItem
            {
                Id = 38,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item39
            };
            var collectionItem39 = new EavesCollectionItem
            {
                Id = 39,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item12
            };
            var collectionItem40 = new EavesCollectionItem
            {
                Id = 40,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item11
            };
            var collectionItem41 = new EavesCollectionItem
            {
                Id = 41,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item30
            };
            var collectionItem42 = new EavesCollectionItem
            {
                Id = 42,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item40
            };
            var collectionItem43 = new EavesCollectionItem
            {
                Id = 43,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item41
            };
            var collectionItem44 = new EavesCollectionItem
            {
                Id = 44,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item42
            };
            var collectionItem45 = new EavesCollectionItem
            {
                Id = 45,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item43
            };
            var collectionItem46 = new EavesCollectionItem
            {
                Id = 46,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item44
            };
            var collectionItem47 = new EavesCollectionItem
            {
                Id = 47,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item6
            };
            var collectionItem48 = new EavesCollectionItem
            {
                Id = 48,
                Description = "",
                eavesCollectionEntity = series2,
                eavesItemsEntity = item45
            };
            var collectionItem49 = new EavesCollectionItem
            {
                Id = 49,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item46
            };
            var collectionItem50 = new EavesCollectionItem
            {
                Id = 50,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item35
            };
            var collectionItem51 = new EavesCollectionItem
            {
                Id = 51,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item47
            };
            var collectionItem52 = new EavesCollectionItem
            {
                Id = 52,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item48
            };
            var collectionItem53 = new EavesCollectionItem
            {
                Id = 53,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item49
            };
            var collectionItem54 = new EavesCollectionItem
            {
                Id = 54,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item38
            };
            var collectionItem55 = new EavesCollectionItem
            {
                Id = 55,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item50
            };
            var collectionItem56 = new EavesCollectionItem
            {
                Id = 56,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item1
            };
            var collectionItem57 = new EavesCollectionItem
            {
                Id = 57,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item39
            };
            var collectionItem58 = new EavesCollectionItem
            {
                Id = 58,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item51
            };
            var collectionItem59 = new EavesCollectionItem
            {
                Id = 59,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item52
            };
            var collectionItem60 = new EavesCollectionItem
            {
                Id = 60,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item53
            };
            var collectionItem61 = new EavesCollectionItem
            {
                Id = 61,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item31
            };
            var collectionItem62 = new EavesCollectionItem
            {
                Id = 62,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item54
            };
            var collectionItem63 = new EavesCollectionItem
            {
                Id = 63,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item41
            };
            var collectionItem64 = new EavesCollectionItem
            {
                Id = 64,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item55
            };
            var collectionItem65 = new EavesCollectionItem
            {
                Id = 65,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item56
            };
            var collectionItem66 = new EavesCollectionItem
            {
                Id = 66,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item57
            };
            var collectionItem67 = new EavesCollectionItem
            {
                Id = 67,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item20
            };
            var collectionItem68 = new EavesCollectionItem
            {
                Id = 68,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item58
            };
            var collectionItem69 = new EavesCollectionItem
            {
                Id = 69,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item59
            };
            var collectionItem70 = new EavesCollectionItem
            {
                Id = 70,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item45
            };
            var collectionItem71 = new EavesCollectionItem
            {
                Id = 71,
                Description = "",
                eavesCollectionEntity = series3,
                eavesItemsEntity = item43
            };
            var collectionItem72 = new EavesCollectionItem
            {
                Id = 72,
                Description = "",
                eavesCollectionEntity = series4,
                eavesItemsEntity = item60
            };
            var collectionItem73 = new EavesCollectionItem
            {
                Id = 73,
                Description = "",
                eavesCollectionEntity = series4,
                eavesItemsEntity = item61
            };
            var collectionItem74 = new EavesCollectionItem
            {
                Id = 74,
                Description = "",
                eavesCollectionEntity = series4,
                eavesItemsEntity = item62
            };
            var collectionItem75 = new EavesCollectionItem
            {
                Id = 75,
                Description = "",
                eavesCollectionEntity = series4,
                eavesItemsEntity = item63
            };
            var collectionItem76 = new EavesCollectionItem
            {
                Id = 76,
                Description = "",
                eavesCollectionEntity = series4,
                eavesItemsEntity = item64
            };
            var collectionItem77 = new EavesCollectionItem
            {
                Id = 77,
                Description = "",
                eavesCollectionEntity = series4,
                eavesItemsEntity = item65
            };
            var collectionItem78 = new EavesCollectionItem
            {
                Id = 78,
                Description = "",
                eavesCollectionEntity = series5,
                eavesItemsEntity = item66
            };
            var collectionItem79 = new EavesCollectionItem
            {
                Id = 79,
                Description = "",
                eavesCollectionEntity = series6,
                eavesItemsEntity = item66
            };
            var collectionItem80 = new EavesCollectionItem
            {
                Id = 80,
                Description = "",
                eavesCollectionEntity = series5,
                eavesItemsEntity = item67
            };
            var collectionItem81 = new EavesCollectionItem
            {
                Id = 81,
                Description = "",
                eavesCollectionEntity = series6,
                eavesItemsEntity = item67
            };
            var collectionItem82 = new EavesCollectionItem
            {
                Id = 82,
                Description = "",
                eavesCollectionEntity = series6,
                eavesItemsEntity = item68
            };
            var collectionItem83 = new EavesCollectionItem
            {
                Id = 83,
                Description = "",
                eavesCollectionEntity = series6,
                eavesItemsEntity = item69
            };
            var collectionItem84 = new EavesCollectionItem
            {
                Id = 84,
                Description = "",
                eavesCollectionEntity = series6,
                eavesItemsEntity = item70
            };
            var collectionItem85 = new EavesCollectionItem
            {
                Id = 85,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item71
            };
            var collectionItem86 = new EavesCollectionItem
            {
                Id = 86,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item72
            };
            var collectionItem87 = new EavesCollectionItem
            {
                Id = 87,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item73
            };
            var collectionItem88 = new EavesCollectionItem
            {
                Id = 88,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item74
            };
            var collectionItem89 = new EavesCollectionItem
            {
                Id = 89,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item75
            };
            var collectionItem90 = new EavesCollectionItem
            {
                Id = 90,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item76
            };
            var collectionItem91 = new EavesCollectionItem
            {
                Id = 91,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item77
            };
            var collectionItem92 = new EavesCollectionItem
            {
                Id = 92,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item78
            };
            var collectionItem93 = new EavesCollectionItem
            {
                Id = 93,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item79
            };
            var collectionItem94 = new EavesCollectionItem
            {
                Id = 94,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item80
            };
            var collectionItem95 = new EavesCollectionItem
            {
                Id = 95,
                Description = "",
                eavesCollectionEntity = series7,
                eavesItemsEntity = item81
            };
            context.EavesCollectionItems.Add(collectionItem1);
            context.EavesCollectionItems.Add(collectionItem2);
            context.EavesCollectionItems.Add(collectionItem3);
            context.EavesCollectionItems.Add(collectionItem4);
            context.EavesCollectionItems.Add(collectionItem5);
            context.EavesCollectionItems.Add(collectionItem6);
            context.EavesCollectionItems.Add(collectionItem7);
            context.EavesCollectionItems.Add(collectionItem8);
            context.EavesCollectionItems.Add(collectionItem9);
            context.EavesCollectionItems.Add(collectionItem10);
            context.EavesCollectionItems.Add(collectionItem11);
            context.EavesCollectionItems.Add(collectionItem12);
            context.EavesCollectionItems.Add(collectionItem13);
            context.EavesCollectionItems.Add(collectionItem14);
            context.EavesCollectionItems.Add(collectionItem15);
            context.EavesCollectionItems.Add(collectionItem16);
            context.EavesCollectionItems.Add(collectionItem17);
            context.EavesCollectionItems.Add(collectionItem18);
            context.EavesCollectionItems.Add(collectionItem19);
            context.EavesCollectionItems.Add(collectionItem20);
            context.EavesCollectionItems.Add(collectionItem21);
            context.EavesCollectionItems.Add(collectionItem22);
            context.EavesCollectionItems.Add(collectionItem23);
            context.EavesCollectionItems.Add(collectionItem24);
            context.EavesCollectionItems.Add(collectionItem25);
            context.EavesCollectionItems.Add(collectionItem26);
            context.EavesCollectionItems.Add(collectionItem27);
            context.EavesCollectionItems.Add(collectionItem28);
            context.EavesCollectionItems.Add(collectionItem29);
            context.EavesCollectionItems.Add(collectionItem30);
            context.EavesCollectionItems.Add(collectionItem31);
            context.EavesCollectionItems.Add(collectionItem32);
            context.EavesCollectionItems.Add(collectionItem33);
            context.EavesCollectionItems.Add(collectionItem34);
            context.EavesCollectionItems.Add(collectionItem35);
            context.EavesCollectionItems.Add(collectionItem36);
            context.EavesCollectionItems.Add(collectionItem37);
            context.EavesCollectionItems.Add(collectionItem38);
            context.EavesCollectionItems.Add(collectionItem39);
            context.EavesCollectionItems.Add(collectionItem40);
            context.EavesCollectionItems.Add(collectionItem41);
            context.EavesCollectionItems.Add(collectionItem42);
            context.EavesCollectionItems.Add(collectionItem43);
            context.EavesCollectionItems.Add(collectionItem44);
            context.EavesCollectionItems.Add(collectionItem45);
            context.EavesCollectionItems.Add(collectionItem46);
            context.EavesCollectionItems.Add(collectionItem47);
            context.EavesCollectionItems.Add(collectionItem48);
            context.EavesCollectionItems.Add(collectionItem49);
            context.EavesCollectionItems.Add(collectionItem50);
            context.EavesCollectionItems.Add(collectionItem51);
            context.EavesCollectionItems.Add(collectionItem52);
            context.EavesCollectionItems.Add(collectionItem53);
            context.EavesCollectionItems.Add(collectionItem54);
            context.EavesCollectionItems.Add(collectionItem55);
            context.EavesCollectionItems.Add(collectionItem56);
            context.EavesCollectionItems.Add(collectionItem57);
            context.EavesCollectionItems.Add(collectionItem58);
            context.EavesCollectionItems.Add(collectionItem59);
            context.EavesCollectionItems.Add(collectionItem60);
            context.EavesCollectionItems.Add(collectionItem61);
            context.EavesCollectionItems.Add(collectionItem62);
            context.EavesCollectionItems.Add(collectionItem63);
            context.EavesCollectionItems.Add(collectionItem64);
            context.EavesCollectionItems.Add(collectionItem65);
            context.EavesCollectionItems.Add(collectionItem66);
            context.EavesCollectionItems.Add(collectionItem67);
            context.EavesCollectionItems.Add(collectionItem68);
            context.EavesCollectionItems.Add(collectionItem69);
            context.EavesCollectionItems.Add(collectionItem70);
            context.EavesCollectionItems.Add(collectionItem71);
            context.EavesCollectionItems.Add(collectionItem72);
            context.EavesCollectionItems.Add(collectionItem73);
            context.EavesCollectionItems.Add(collectionItem74);
            context.EavesCollectionItems.Add(collectionItem75);
            context.EavesCollectionItems.Add(collectionItem76);
            context.EavesCollectionItems.Add(collectionItem77);
            context.EavesCollectionItems.Add(collectionItem78);
            context.EavesCollectionItems.Add(collectionItem79);
            context.EavesCollectionItems.Add(collectionItem80);
            context.EavesCollectionItems.Add(collectionItem81);
            context.EavesCollectionItems.Add(collectionItem82);
            context.EavesCollectionItems.Add(collectionItem83);
            context.EavesCollectionItems.Add(collectionItem84);
            context.EavesCollectionItems.Add(collectionItem85);
            context.EavesCollectionItems.Add(collectionItem86);
            context.EavesCollectionItems.Add(collectionItem87);
            context.EavesCollectionItems.Add(collectionItem88);
            context.EavesCollectionItems.Add(collectionItem89);
            context.EavesCollectionItems.Add(collectionItem90);
            context.EavesCollectionItems.Add(collectionItem91);
            context.EavesCollectionItems.Add(collectionItem92);
            context.EavesCollectionItems.Add(collectionItem93);
            context.EavesCollectionItems.Add(collectionItem94);
            context.EavesCollectionItems.Add(collectionItem95);
            context.SaveChanges();
            var color1 = new EavesColor
            {
                Id = 1,
                ColorName = "Антик"
            };
            var color2 = new EavesColor
            {
                Id = 2,
                ColorName = "Хром-Мат"
            };
            var color3 = new EavesColor
            {
                Id = 3,
                ColorName = "Эффект Стали"
            };
            var color4 = new EavesColor
            {
                Id = 4,
                ColorName = "Хром"
            };
            var color5 = new EavesColor
            {
                Id = 5,
                ColorName = "Золото"
            };
            var color6 = new EavesColor
            {
                Id = 6,
                ColorName = "Чёрный"
            };
            var color7 = new EavesColor
            {
                Id = 7,
                ColorName = "Оникс"
            };
            var color8 = new EavesColor
            {
                Id = 8,
                ColorName = "Сталь"
            };
            var color9 = new EavesColor
            {
                Id = 9,
                ColorName = "Чёрный Матовый"
            };
            var color10 = new EavesColor
            {
                Id = 10,
                ColorName = "Чёрный Глянец"
            };
            var color11 = new EavesColor
            {
                Id = 11,
                ColorName = "Белый Глянец"
            };
            context.EavesColors.Add(color1);
            context.EavesColors.Add(color2);
            context.EavesColors.Add(color3);
            context.EavesColors.Add(color4);
            context.EavesColors.Add(color5);
            context.EavesColors.Add(color6);
            context.EavesColors.Add(color7);
            context.EavesColors.Add(color8);
            context.EavesColors.Add(color9);
            context.EavesColors.Add(color10);
            context.EavesColors.Add(color11);
            context.SaveChanges();
            var collectionItemColor1 = new EavesItemsColor
            {
                Id = 1,
                eavesCollectionItemsEntity = collectionItem1,
                eavesColorsEntity = color1
            };
            var collectionItemColor2 = new EavesItemsColor
            {
                Id = 2,
                eavesCollectionItemsEntity = collectionItem1,
                eavesColorsEntity = color2
            };
            var collectionItemColor3 = new EavesItemsColor
            {
                Id = 3,
                eavesCollectionItemsEntity = collectionItem1,
                eavesColorsEntity = color3
            };
            var collectionItemColor4 = new EavesItemsColor
            {
                Id = 4,
                eavesCollectionItemsEntity = collectionItem2,
                eavesColorsEntity = color1
            };
            var collectionItemColor5 = new EavesItemsColor
            {
                Id = 5,
                eavesCollectionItemsEntity = collectionItem2,
                eavesColorsEntity = color2
            };
            var collectionItemColor6 = new EavesItemsColor
            {
                Id = 6,
                eavesCollectionItemsEntity = collectionItem2,
                eavesColorsEntity = color3
            };
            var collectionItemColor7 = new EavesItemsColor
            {
                Id = 7,
                eavesCollectionItemsEntity = collectionItem19,
                eavesColorsEntity = color1
            };
            var collectionItemColor8 = new EavesItemsColor
            {
                Id = 8,
                eavesCollectionItemsEntity = collectionItem19,
                eavesColorsEntity = color2
            };
            var collectionItemColor9 = new EavesItemsColor
            {
                Id = 9,
                eavesCollectionItemsEntity = collectionItem19,
                eavesColorsEntity = color4
            };
            var collectionItemColor10 = new EavesItemsColor
            {
                Id = 10,
                eavesCollectionItemsEntity = collectionItem19,
                eavesColorsEntity = color5
            };
            var collectionItemColor11 = new EavesItemsColor
            {
                Id = 11,
                eavesCollectionItemsEntity = collectionItem19,
                eavesColorsEntity = color6
            };
            var collectionItemColor12 = new EavesItemsColor
            {
                Id = 12,
                eavesCollectionItemsEntity = collectionItem3,
                eavesColorsEntity = color1
            };
            var collectionItemColor13 = new EavesItemsColor
            {
                Id = 13,
                eavesCollectionItemsEntity = collectionItem3,
                eavesColorsEntity = color2
            };
            var collectionItemColor14 = new EavesItemsColor
            {
                Id = 14,
                eavesCollectionItemsEntity = collectionItem3,
                eavesColorsEntity = color3
            };
            var collectionItemColor15 = new EavesItemsColor
            {
                Id = 15,
                eavesCollectionItemsEntity = collectionItem4,
                eavesColorsEntity = color1
            };
            var collectionItemColor16 = new EavesItemsColor
            {
                Id = 16,
                eavesCollectionItemsEntity = collectionItem4,
                eavesColorsEntity = color3
            };
            var collectionItemColor17 = new EavesItemsColor
            {
                Id = 17,
                eavesCollectionItemsEntity = collectionItem4,
                eavesColorsEntity = color4
            };
            var collectionItemColor18 = new EavesItemsColor
            {
                Id = 18,
                eavesCollectionItemsEntity = collectionItem5,
                eavesColorsEntity = color1
            };
            var collectionItemColor19 = new EavesItemsColor
            {
                Id = 19,
                eavesCollectionItemsEntity = collectionItem5,
                eavesColorsEntity = color2
            };
            var collectionItemColor20 = new EavesItemsColor
            {
                Id = 20,
                eavesCollectionItemsEntity = collectionItem5,
                eavesColorsEntity = color3
            };
            var collectionItemColor21 = new EavesItemsColor
            {
                Id = 21,
                eavesCollectionItemsEntity = collectionItem6,
                eavesColorsEntity = color1
            };
            var collectionItemColor22 = new EavesItemsColor
            {
                Id = 22,
                eavesCollectionItemsEntity = collectionItem6,
                eavesColorsEntity = color2
            };
            var collectionItemColor23 = new EavesItemsColor
            {
                Id = 23,
                eavesCollectionItemsEntity = collectionItem6,
                eavesColorsEntity = color3
            };
            var collectionItemColor24 = new EavesItemsColor
            {
                Id = 24,
                eavesCollectionItemsEntity = collectionItem7,
                eavesColorsEntity = color1
            };
            var collectionItemColor25 = new EavesItemsColor
            {
                Id = 25,
                eavesCollectionItemsEntity = collectionItem7,
                eavesColorsEntity = color2
            };
            var collectionItemColor26 = new EavesItemsColor
            {
                Id = 26,
                eavesCollectionItemsEntity = collectionItem8,
                eavesColorsEntity = color1
            };
            var collectionItemColor27 = new EavesItemsColor
            {
                Id = 27,
                eavesCollectionItemsEntity = collectionItem8,
                eavesColorsEntity = color2
            };
            var collectionItemColor28 = new EavesItemsColor
            {
                Id = 28,
                eavesCollectionItemsEntity = collectionItem9,
                eavesColorsEntity = color1
            };
            var collectionItemColor29 = new EavesItemsColor
            {
                Id = 29,
                eavesCollectionItemsEntity = collectionItem9,
                eavesColorsEntity = color2
            };
            var collectionItemColor30 = new EavesItemsColor
            {
                Id = 30,
                eavesCollectionItemsEntity = collectionItem10,
                eavesColorsEntity = color1
            };
            var collectionItemColor31 = new EavesItemsColor
            {
                Id = 31,
                eavesCollectionItemsEntity = collectionItem10,
                eavesColorsEntity = color2
            };
            var collectionItemColor32 = new EavesItemsColor
            {
                Id = 32,
                eavesCollectionItemsEntity = collectionItem11,
                eavesColorsEntity = color1
            };
            var collectionItemColor33 = new EavesItemsColor
            {
                Id = 33,
                eavesCollectionItemsEntity = collectionItem11,
                eavesColorsEntity = color2
            };
            var collectionItemColor34 = new EavesItemsColor
            {
                Id = 34,
                eavesCollectionItemsEntity = collectionItem11,
                eavesColorsEntity = color3
            };
            var collectionItemColor35 = new EavesItemsColor
            {
                Id = 35,
                eavesCollectionItemsEntity = collectionItem12,
                eavesColorsEntity = color1
            };
            var collectionItemColor36 = new EavesItemsColor
            {
                Id = 36,
                eavesCollectionItemsEntity = collectionItem12,
                eavesColorsEntity = color2
            };
            var collectionItemColor37 = new EavesItemsColor
            {
                Id = 37,
                eavesCollectionItemsEntity = collectionItem12,
                eavesColorsEntity = color3
            };
            var collectionItemColor38 = new EavesItemsColor
            {
                Id = 38,
                eavesCollectionItemsEntity = collectionItem13,
                eavesColorsEntity = color1
            };
            var collectionItemColor39 = new EavesItemsColor
            {
                Id = 39,
                eavesCollectionItemsEntity = collectionItem13,
                eavesColorsEntity = color2
            };
            var collectionItemColor40 = new EavesItemsColor
            {
                Id = 40,
                eavesCollectionItemsEntity = collectionItem14,
                eavesColorsEntity = color1
            };
            var collectionItemColor41 = new EavesItemsColor
            {
                Id = 41,
                eavesCollectionItemsEntity = collectionItem14,
                eavesColorsEntity = color2
            };
            var collectionItemColor42 = new EavesItemsColor
            {
                Id = 42,
                eavesCollectionItemsEntity = collectionItem15,
                eavesColorsEntity = color1
            };
            var collectionItemColor43 = new EavesItemsColor
            {
                Id = 43,
                eavesCollectionItemsEntity = collectionItem15,
                eavesColorsEntity = color2
            };
            var collectionItemColor44 = new EavesItemsColor
            {
                Id = 44,
                eavesCollectionItemsEntity = collectionItem15,
                eavesColorsEntity = color3
            };
            var collectionItemColor45 = new EavesItemsColor
            {
                Id = 45,
                eavesCollectionItemsEntity = collectionItem16,
                eavesColorsEntity = color1
            };
            var collectionItemColor46 = new EavesItemsColor
            {
                Id = 46,
                eavesCollectionItemsEntity = collectionItem16,
                eavesColorsEntity = color2
            };
            var collectionItemColor47 = new EavesItemsColor
            {
                Id = 77,
                eavesCollectionItemsEntity = collectionItem16,
                eavesColorsEntity = color3
            };
            var collectionItemColor48 = new EavesItemsColor
            {
                Id = 48,
                eavesCollectionItemsEntity = collectionItem17,
                eavesColorsEntity = color1
            };
            var collectionItemColor49 = new EavesItemsColor
            {
                Id = 49,
                eavesCollectionItemsEntity = collectionItem17,
                eavesColorsEntity = color2
            };
            var collectionItemColor50 = new EavesItemsColor
            {
                Id = 50,
                eavesCollectionItemsEntity = collectionItem18,
                eavesColorsEntity = color1
            };
            var collectionItemColor51 = new EavesItemsColor
            {
                Id = 51,
                eavesCollectionItemsEntity = collectionItem20,
                eavesColorsEntity = color1
            };
            var collectionItemColor52 = new EavesItemsColor
            {
                Id = 52,
                eavesCollectionItemsEntity = collectionItem20,
                eavesColorsEntity = color2
            };
            var collectionItemColor53 = new EavesItemsColor
            {
                Id = 53,
                eavesCollectionItemsEntity = collectionItem20,
                eavesColorsEntity = color4
            };
            var collectionItemColor54 = new EavesItemsColor
            {
                Id = 54,
                eavesCollectionItemsEntity = collectionItem20,
                eavesColorsEntity = color5
            };
            var collectionItemColor55 = new EavesItemsColor
            {
                Id = 55,
                eavesCollectionItemsEntity = collectionItem20,
                eavesColorsEntity = color6
            };
            var collectionItemColor56 = new EavesItemsColor
            {
                Id = 56,
                eavesCollectionItemsEntity = collectionItem21,
                eavesColorsEntity = color1
            };
            var collectionItemColor57 = new EavesItemsColor
            {
                Id = 57,
                eavesCollectionItemsEntity = collectionItem21,
                eavesColorsEntity = color2
            };
            var collectionItemColor58 = new EavesItemsColor
            {
                Id = 58,
                eavesCollectionItemsEntity = collectionItem22,
                eavesColorsEntity = color6
            };
            var collectionItemColor59 = new EavesItemsColor
            {
                Id = 59,
                eavesCollectionItemsEntity = collectionItem23,
                eavesColorsEntity = color1
            };
            var collectionItemColor60 = new EavesItemsColor
            {
                Id = 60,
                eavesCollectionItemsEntity = collectionItem23,
                eavesColorsEntity = color2
            };
            var collectionItemColor61 = new EavesItemsColor
            {
                Id = 61,
                eavesCollectionItemsEntity = collectionItem24,
                eavesColorsEntity = color1
            };
            var collectionItemColor62 = new EavesItemsColor
            {
                Id = 62,
                eavesCollectionItemsEntity = collectionItem24,
                eavesColorsEntity = color2
            };
            var collectionItemColor63 = new EavesItemsColor
            {
                Id = 63,
                eavesCollectionItemsEntity = collectionItem25,
                eavesColorsEntity = color1
            };
            var collectionItemColor64 = new EavesItemsColor
            {
                Id = 64,
                eavesCollectionItemsEntity = collectionItem25,
                eavesColorsEntity = color2
            };
            var collectionItemColor65 = new EavesItemsColor
            {
                Id = 65,
                eavesCollectionItemsEntity = collectionItem26,
                eavesColorsEntity = color1
            };
            var collectionItemColor66 = new EavesItemsColor
            {
                Id = 66,
                eavesCollectionItemsEntity = collectionItem26,
                eavesColorsEntity = color2
            };
            var collectionItemColor67 = new EavesItemsColor
            {
                Id = 67,
                eavesCollectionItemsEntity = collectionItem26,
                eavesColorsEntity = color3
            };
            var collectionItemColor68 = new EavesItemsColor
            {
                Id = 68,
                eavesCollectionItemsEntity = collectionItem26,
                eavesColorsEntity = color4
            };
            var collectionItemColor69 = new EavesItemsColor
            {
                Id = 69,
                eavesCollectionItemsEntity = collectionItem27,
                eavesColorsEntity = color1
            };
            var collectionItemColor70 = new EavesItemsColor
            {
                Id = 70,
                eavesCollectionItemsEntity = collectionItem27,
                eavesColorsEntity = color2
            };
            var collectionItemColor71 = new EavesItemsColor
            {
                Id = 71,
                eavesCollectionItemsEntity = collectionItem28,
                eavesColorsEntity = color1
            };
            var collectionItemColor72 = new EavesItemsColor
            {
                Id = 72,
                eavesCollectionItemsEntity = collectionItem28,
                eavesColorsEntity = color2
            };
            var collectionItemColor73 = new EavesItemsColor
            {
                Id = 73,
                eavesCollectionItemsEntity = collectionItem28,
                eavesColorsEntity = color4
            };
            var collectionItemColor74 = new EavesItemsColor
            {
                Id = 74,
                eavesCollectionItemsEntity = collectionItem28,
                eavesColorsEntity = color5
            };
            var collectionItemColor75 = new EavesItemsColor
            {
                Id = 75,
                eavesCollectionItemsEntity = collectionItem28,
                eavesColorsEntity = color6
            };
            var collectionItemColor76 = new EavesItemsColor
            {
                Id = 76,
                eavesCollectionItemsEntity = collectionItem29,
                eavesColorsEntity = color1
            };
            var collectionItemColor77 = new EavesItemsColor
            {
                Id = 77,
                eavesCollectionItemsEntity = collectionItem29,
                eavesColorsEntity = color2
            };
            var collectionItemColor78 = new EavesItemsColor
            {
                Id = 78,
                eavesCollectionItemsEntity = collectionItem30,
                eavesColorsEntity = color1
            };
            var collectionItemColor79 = new EavesItemsColor
            {
                Id = 79,
                eavesCollectionItemsEntity = collectionItem30,
                eavesColorsEntity = color2
            };
            var collectionItemColor80 = new EavesItemsColor
            {
                Id = 80,
                eavesCollectionItemsEntity = collectionItem30,
                eavesColorsEntity = color3
            };
            var collectionItemColor81 = new EavesItemsColor
            {
                Id = 81,
                eavesCollectionItemsEntity = collectionItem31,
                eavesColorsEntity = color1
            };
            var collectionItemColor82 = new EavesItemsColor
            {
                Id = 82,
                eavesCollectionItemsEntity = collectionItem32,
                eavesColorsEntity = color1
            };
            var collectionItemColor83 = new EavesItemsColor
            {
                Id = 83,
                eavesCollectionItemsEntity = collectionItem32,
                eavesColorsEntity = color2
            };
            var collectionItemColor84 = new EavesItemsColor
            {
                Id = 84,
                eavesCollectionItemsEntity = collectionItem33,
                eavesColorsEntity = color1
            };
            var collectionItemColor85 = new EavesItemsColor
            {
                Id = 85,
                eavesCollectionItemsEntity = collectionItem33,
                eavesColorsEntity = color2
            };
            var collectionItemColor86 = new EavesItemsColor
            {
                Id = 86,
                eavesCollectionItemsEntity = collectionItem33,
                eavesColorsEntity = color3
            };
            var collectionItemColor87 = new EavesItemsColor
            {
                Id = 87,
                eavesCollectionItemsEntity = collectionItem34,
                eavesColorsEntity = color1
            };
            var collectionItemColor88 = new EavesItemsColor
            {
                Id = 88,
                eavesCollectionItemsEntity = collectionItem34,
                eavesColorsEntity = color2
            };
            var collectionItemColor89 = new EavesItemsColor
            {
                Id = 89,
                eavesCollectionItemsEntity = collectionItem34,
                eavesColorsEntity = color3
            };
            var collectionItemColor90 = new EavesItemsColor
            {
                Id = 90,
                eavesCollectionItemsEntity = collectionItem35,
                eavesColorsEntity = color1
            };
            var collectionItemColor91 = new EavesItemsColor
            {
                Id = 91,
                eavesCollectionItemsEntity = collectionItem35,
                eavesColorsEntity = color2
            };
            var collectionItemColor92 = new EavesItemsColor
            {
                Id = 92,
                eavesCollectionItemsEntity = collectionItem35,
                eavesColorsEntity = color3
            };
            var collectionItemColor93 = new EavesItemsColor
            {
                Id = 93,
                eavesCollectionItemsEntity = collectionItem36,
                eavesColorsEntity = color1
            };
            var collectionItemColor94 = new EavesItemsColor
            {
                Id = 94,
                eavesCollectionItemsEntity = collectionItem36,
                eavesColorsEntity = color2
            };
            var collectionItemColor95 = new EavesItemsColor
            {
                Id = 95,
                eavesCollectionItemsEntity = collectionItem36,
                eavesColorsEntity = color3
            };
            var collectionItemColor96 = new EavesItemsColor
            {
                Id = 96,
                eavesCollectionItemsEntity = collectionItem37,
                eavesColorsEntity = color1
            };
            var collectionItemColor97 = new EavesItemsColor
            {
                Id = 97,
                eavesCollectionItemsEntity = collectionItem37,
                eavesColorsEntity = color2
            };
            var collectionItemColor98 = new EavesItemsColor
            {
                Id = 98,
                eavesCollectionItemsEntity = collectionItem37,
                eavesColorsEntity = color3
            };
            var collectionItemColor99 = new EavesItemsColor
            {
                Id = 99,
                eavesCollectionItemsEntity = collectionItem38,
                eavesColorsEntity = color1
            };
            var collectionItemColor100 = new EavesItemsColor
            {
                Id = 100,
                eavesCollectionItemsEntity = collectionItem38,
                eavesColorsEntity = color2
            };
            var collectionItemColor101 = new EavesItemsColor
            {
                Id = 101,
                eavesCollectionItemsEntity = collectionItem38,
                eavesColorsEntity = color3
            };
            var collectionItemColor102 = new EavesItemsColor
            {
                Id = 102,
                eavesCollectionItemsEntity = collectionItem39,
                eavesColorsEntity = color1
            };
            var collectionItemColor103 = new EavesItemsColor
            {
                Id = 100,
                eavesCollectionItemsEntity = collectionItem39,
                eavesColorsEntity = color2
            };
            var collectionItemColor104 = new EavesItemsColor
            {
                Id = 104,
                eavesCollectionItemsEntity = collectionItem39,
                eavesColorsEntity = color3
            };
            var collectionItemColor105 = new EavesItemsColor
            {
                Id = 105,
                eavesCollectionItemsEntity = collectionItem40,
                eavesColorsEntity = color1
            };
            var collectionItemColor106 = new EavesItemsColor
            {
                Id = 106,
                eavesCollectionItemsEntity = collectionItem40,
                eavesColorsEntity = color2
            };
            var collectionItemColor107 = new EavesItemsColor
            {
                Id = 107,
                eavesCollectionItemsEntity = collectionItem40,
                eavesColorsEntity = color3
            };
            var collectionItemColor108 = new EavesItemsColor
            {
                Id = 108,
                eavesCollectionItemsEntity = collectionItem41,
                eavesColorsEntity = color1
            };
            var collectionItemColor109 = new EavesItemsColor
            {
                Id = 109,
                eavesCollectionItemsEntity = collectionItem41,
                eavesColorsEntity = color2
            };
            var collectionItemColor110 = new EavesItemsColor
            {
                Id = 110,
                eavesCollectionItemsEntity = collectionItem41,
                eavesColorsEntity = color3
            };
            var collectionItemColor111 = new EavesItemsColor
            {
                Id = 111,
                eavesCollectionItemsEntity = collectionItem42,
                eavesColorsEntity = color2
            };
            var collectionItemColor112 = new EavesItemsColor
            {
                Id = 112,
                eavesCollectionItemsEntity = collectionItem42,
                eavesColorsEntity = color3
            };
            var collectionItemColor113 = new EavesItemsColor
            {
                Id = 113,
                eavesCollectionItemsEntity = collectionItem43,
                eavesColorsEntity = color1
            };
            var collectionItemColor114 = new EavesItemsColor
            {
                Id = 114,
                eavesCollectionItemsEntity = collectionItem43,
                eavesColorsEntity = color2
            };
            var collectionItemColor115 = new EavesItemsColor
            {
                Id = 115,
                eavesCollectionItemsEntity = collectionItem43,
                eavesColorsEntity = color3
            };
            var collectionItemColor116 = new EavesItemsColor
            {
                Id = 116,
                eavesCollectionItemsEntity = collectionItem44,
                eavesColorsEntity = color1
            };
            var collectionItemColor117 = new EavesItemsColor
            {
                Id = 117,
                eavesCollectionItemsEntity = collectionItem44,
                eavesColorsEntity = color2
            };
            var collectionItemColor118 = new EavesItemsColor
            {
                Id = 118,
                eavesCollectionItemsEntity = collectionItem44,
                eavesColorsEntity = color3
            };
            var collectionItemColor119 = new EavesItemsColor
            {
                Id = 119,
                eavesCollectionItemsEntity = collectionItem45,
                eavesColorsEntity = color1
            };
            var collectionItemColor120 = new EavesItemsColor
            {
                Id = 120,
                eavesCollectionItemsEntity = collectionItem46,
                eavesColorsEntity = color1
            };
            var collectionItemColor121 = new EavesItemsColor
            {
                Id = 121,
                eavesCollectionItemsEntity = collectionItem47,
                eavesColorsEntity = color2
            };
            var collectionItemColor122 = new EavesItemsColor
            {
                Id = 122,
                eavesCollectionItemsEntity = collectionItem48,
                eavesColorsEntity = color1
            };
            var collectionItemColor123 = new EavesItemsColor
            {
                Id = 123,
                eavesCollectionItemsEntity = collectionItem48,
                eavesColorsEntity = color2
            };
            var collectionItemColor124 = new EavesItemsColor
            {
                Id = 124,
                eavesCollectionItemsEntity = collectionItem49,
                eavesColorsEntity = color1
            };
            var collectionItemColor125 = new EavesItemsColor
            {
                Id = 125,
                eavesCollectionItemsEntity = collectionItem49,
                eavesColorsEntity = color2
            };
            var collectionItemColor126 = new EavesItemsColor
            {
                Id = 126,
                eavesCollectionItemsEntity = collectionItem49,
                eavesColorsEntity = color3
            };
            var collectionItemColor127 = new EavesItemsColor
            {
                Id = 127,
                eavesCollectionItemsEntity = collectionItem50,
                eavesColorsEntity = color1
            };
            var collectionItemColor128 = new EavesItemsColor
            {
                Id = 128,
                eavesCollectionItemsEntity = collectionItem50,
                eavesColorsEntity = color2
            };
            var collectionItemColor129 = new EavesItemsColor
            {
                Id = 129,
                eavesCollectionItemsEntity = collectionItem50,
                eavesColorsEntity = color3
            };
            var collectionItemColor130 = new EavesItemsColor
            {
                Id = 130,
                eavesCollectionItemsEntity = collectionItem51,
                eavesColorsEntity = color1
            };
            var collectionItemColor131 = new EavesItemsColor
            {
                Id = 131,
                eavesCollectionItemsEntity = collectionItem51,
                eavesColorsEntity = color2
            };
            var collectionItemColor132 = new EavesItemsColor
            {
                Id = 132,
                eavesCollectionItemsEntity = collectionItem51,
                eavesColorsEntity = color3
            };
            var collectionItemColor133 = new EavesItemsColor
            {
                Id = 133,
                eavesCollectionItemsEntity = collectionItem52,
                eavesColorsEntity = color1
            };
            var collectionItemColor134 = new EavesItemsColor
            {
                Id = 134,
                eavesCollectionItemsEntity = collectionItem52,
                eavesColorsEntity = color2
            };
            var collectionItemColor135 = new EavesItemsColor
            {
                Id = 135,
                eavesCollectionItemsEntity = collectionItem52,
                eavesColorsEntity = color3
            };
            var collectionItemColor136 = new EavesItemsColor
            {
                Id = 136,
                eavesCollectionItemsEntity = collectionItem53,
                eavesColorsEntity = color1
            };
            var collectionItemColor137 = new EavesItemsColor
            {
                Id = 137,
                eavesCollectionItemsEntity = collectionItem54,
                eavesColorsEntity = color1
            };
            var collectionItemColor138 = new EavesItemsColor
            {
                Id = 138,
                eavesCollectionItemsEntity = collectionItem54,
                eavesColorsEntity = color2
            };
            var collectionItemColor139 = new EavesItemsColor
            {
                Id = 139,
                eavesCollectionItemsEntity = collectionItem54,
                eavesColorsEntity = color3
            };
            var collectionItemColor140 = new EavesItemsColor
            {
                Id = 140,
                eavesCollectionItemsEntity = collectionItem55,
                eavesColorsEntity = color2
            };
            var collectionItemColor141 = new EavesItemsColor
            {
                Id = 141,
                eavesCollectionItemsEntity = collectionItem56,
                eavesColorsEntity = color1
            };
            var collectionItemColor142 = new EavesItemsColor
            {
                Id = 142,
                eavesCollectionItemsEntity = collectionItem56,
                eavesColorsEntity = color2
            };
            var collectionItemColor143 = new EavesItemsColor
            {
                Id = 143,
                eavesCollectionItemsEntity = collectionItem56,
                eavesColorsEntity = color3
            };
            var collectionItemColor144 = new EavesItemsColor
            {
                Id = 144,
                eavesCollectionItemsEntity = collectionItem57,
                eavesColorsEntity = color1
            };
            var collectionItemColor145 = new EavesItemsColor
            {
                Id = 145,
                eavesCollectionItemsEntity = collectionItem58,
                eavesColorsEntity = color1
            };
            var collectionItemColor146 = new EavesItemsColor
            {
                Id = 146,
                eavesCollectionItemsEntity = collectionItem58,
                eavesColorsEntity = color2
            };
            var collectionItemColor147 = new EavesItemsColor
            {
                Id = 147,
                eavesCollectionItemsEntity = collectionItem58,
                eavesColorsEntity = color3
            };
            var collectionItemColor148 = new EavesItemsColor
            {
                Id = 148,
                eavesCollectionItemsEntity = collectionItem59,
                eavesColorsEntity = color1
            };
            var collectionItemColor149 = new EavesItemsColor
            {
                Id = 149,
                eavesCollectionItemsEntity = collectionItem59,
                eavesColorsEntity = color2
            };
            var collectionItemColor150 = new EavesItemsColor
            {
                Id = 150,
                eavesCollectionItemsEntity = collectionItem59,
                eavesColorsEntity = color3
            };
            var collectionItemColor151 = new EavesItemsColor
            {
                Id = 151,
                eavesCollectionItemsEntity = collectionItem60,
                eavesColorsEntity = color1
            };
            var collectionItemColor152 = new EavesItemsColor
            {
                Id = 152,
                eavesCollectionItemsEntity = collectionItem60,
                eavesColorsEntity = color2
            };
            var collectionItemColor153 = new EavesItemsColor
            {
                Id = 153,
                eavesCollectionItemsEntity = collectionItem60,
                eavesColorsEntity = color3
            };
            var collectionItemColor154 = new EavesItemsColor
            {
                Id = 154,
                eavesCollectionItemsEntity = collectionItem61,
                eavesColorsEntity = color1
            };
            var collectionItemColor155 = new EavesItemsColor
            {
                Id = 155,
                eavesCollectionItemsEntity = collectionItem61,
                eavesColorsEntity = color2
            };
            var collectionItemColor156 = new EavesItemsColor
            {
                Id = 156,
                eavesCollectionItemsEntity = collectionItem61,
                eavesColorsEntity = color3
            };
            var collectionItemColor157 = new EavesItemsColor
            {
                Id = 157,
                eavesCollectionItemsEntity = collectionItem62,
                eavesColorsEntity = color1
            };
            var collectionItemColor158 = new EavesItemsColor
            {
                Id = 158,
                eavesCollectionItemsEntity = collectionItem62,
                eavesColorsEntity = color2
            };
            var collectionItemColor159 = new EavesItemsColor
            {
                Id = 159,
                eavesCollectionItemsEntity = collectionItem63,
                eavesColorsEntity = color1
            };
            var collectionItemColor160 = new EavesItemsColor
            {
                Id = 160,
                eavesCollectionItemsEntity = collectionItem63,
                eavesColorsEntity = color2
            };
            var collectionItemColor161 = new EavesItemsColor
            {
                Id = 161,
                eavesCollectionItemsEntity = collectionItem63,
                eavesColorsEntity = color3
            };
            var collectionItemColor162 = new EavesItemsColor
            {
                Id = 162,
                eavesCollectionItemsEntity = collectionItem64,
                eavesColorsEntity = color1
            };
            var collectionItemColor163 = new EavesItemsColor
            {
                Id = 163,
                eavesCollectionItemsEntity = collectionItem64,
                eavesColorsEntity = color3
            };
            var collectionItemColor164 = new EavesItemsColor
            {
                Id = 164,
                eavesCollectionItemsEntity = collectionItem65,
                eavesColorsEntity = color1
            };
            var collectionItemColor165 = new EavesItemsColor
            {
                Id = 165,
                eavesCollectionItemsEntity = collectionItem65,
                eavesColorsEntity = color2
            };
            var collectionItemColor166 = new EavesItemsColor
            {
                Id = 166,
                eavesCollectionItemsEntity = collectionItem65,
                eavesColorsEntity = color3
            };
            var collectionItemColor167 = new EavesItemsColor
            {
                Id = 167,
                eavesCollectionItemsEntity = collectionItem66,
                eavesColorsEntity = color1
            };
            var collectionItemColor168 = new EavesItemsColor
            {
                Id = 168,
                eavesCollectionItemsEntity = collectionItem66,
                eavesColorsEntity = color2
            };
            var collectionItemColor169 = new EavesItemsColor
            {
                Id = 169,
                eavesCollectionItemsEntity = collectionItem66,
                eavesColorsEntity = color3
            };
            var collectionItemColor170 = new EavesItemsColor
            {
                Id = 170,
                eavesCollectionItemsEntity = collectionItem67,
                eavesColorsEntity = color1
            };
            var collectionItemColor171 = new EavesItemsColor
            {
                Id = 171,
                eavesCollectionItemsEntity = collectionItem67,
                eavesColorsEntity = color2
            };
            var collectionItemColor172 = new EavesItemsColor
            {
                Id = 172,
                eavesCollectionItemsEntity = collectionItem68,
                eavesColorsEntity = color1
            };
            var collectionItemColor173 = new EavesItemsColor
            {
                Id = 173,
                eavesCollectionItemsEntity = collectionItem68,
                eavesColorsEntity = color2
            };
            var collectionItemColor174 = new EavesItemsColor
            {
                Id = 174,
                eavesCollectionItemsEntity = collectionItem68,
                eavesColorsEntity = color3
            };
            var collectionItemColor175 = new EavesItemsColor
            {
                Id = 175,
                eavesCollectionItemsEntity = collectionItem69,
                eavesColorsEntity = color1
            };
            var collectionItemColor176 = new EavesItemsColor
            {
                Id = 176,
                eavesCollectionItemsEntity = collectionItem70,
                eavesColorsEntity = color2
            };
            var collectionItemColor177 = new EavesItemsColor
            {
                Id = 177,
                eavesCollectionItemsEntity = collectionItem70,
                eavesColorsEntity = color3
            };
            var collectionItemColor178 = new EavesItemsColor
            {
                Id = 178,
                eavesCollectionItemsEntity = collectionItem71,
                eavesColorsEntity = color1
            };
            var collectionItemColor179 = new EavesItemsColor
            {
                Id = 179,
                eavesCollectionItemsEntity = collectionItem71,
                eavesColorsEntity = color2
            };
            var collectionItemColor180 = new EavesItemsColor
            {
                Id = 180,
                eavesCollectionItemsEntity = collectionItem71,
                eavesColorsEntity = color3
            };
            var collectionItemColor181 = new EavesItemsColor
            {
                Id = 181,
                eavesCollectionItemsEntity = collectionItem72,
                eavesColorsEntity = color1
            };
            var collectionItemColor182 = new EavesItemsColor
            {
                Id = 182,
                eavesCollectionItemsEntity = collectionItem72,
                eavesColorsEntity = color2
            };
            var collectionItemColor183 = new EavesItemsColor
            {
                Id = 183,
                eavesCollectionItemsEntity = collectionItem72,
                eavesColorsEntity = color3
            };
            var collectionItemColor184 = new EavesItemsColor
            {
                Id = 184,
                eavesCollectionItemsEntity = collectionItem73,
                eavesColorsEntity = color1
            };
            var collectionItemColor185 = new EavesItemsColor
            {
                Id = 185,
                eavesCollectionItemsEntity = collectionItem73,
                eavesColorsEntity = color2
            };
            var collectionItemColor186 = new EavesItemsColor
            {
                Id = 186,
                eavesCollectionItemsEntity = collectionItem73,
                eavesColorsEntity = color3
            };
            var collectionItemColor187 = new EavesItemsColor
            {
                Id = 187,
                eavesCollectionItemsEntity = collectionItem74,
                eavesColorsEntity = color1
            };
            var collectionItemColor188 = new EavesItemsColor
            {
                Id = 188,
                eavesCollectionItemsEntity = collectionItem74,
                eavesColorsEntity = color2
            };
            var collectionItemColor189 = new EavesItemsColor
            {
                Id = 189,
                eavesCollectionItemsEntity = collectionItem74,
                eavesColorsEntity = color3
            };
            var collectionItemColor190 = new EavesItemsColor
            {
                Id = 190,
                eavesCollectionItemsEntity = collectionItem75,
                eavesColorsEntity = color1
            };
            var collectionItemColor191 = new EavesItemsColor
            {
                Id = 191,
                eavesCollectionItemsEntity = collectionItem75,
                eavesColorsEntity = color2
            };
            var collectionItemColor192 = new EavesItemsColor
            {
                Id = 192,
                eavesCollectionItemsEntity = collectionItem75,
                eavesColorsEntity = color3
            };
            var collectionItemColor193 = new EavesItemsColor
            {
                Id = 193,
                eavesCollectionItemsEntity = collectionItem76,
                eavesColorsEntity = color1
            };
            var collectionItemColor194 = new EavesItemsColor
            {
                Id = 194,
                eavesCollectionItemsEntity = collectionItem76,
                eavesColorsEntity = color2
            };
            var collectionItemColor195 = new EavesItemsColor
            {
                Id = 195,
                eavesCollectionItemsEntity = collectionItem77,
                eavesColorsEntity = color1
            };
            var collectionItemColor196 = new EavesItemsColor
            {
                Id = 196,
                eavesCollectionItemsEntity = collectionItem77,
                eavesColorsEntity = color2
            };
            var collectionItemColor197 = new EavesItemsColor
            {
                Id = 197,
                eavesCollectionItemsEntity = collectionItem77,
                eavesColorsEntity = color3
            };
            var collectionItemColor198 = new EavesItemsColor
            {
                Id = 198,
                eavesCollectionItemsEntity = collectionItem78,
                eavesColorsEntity = color7
            };
            var collectionItemColor199 = new EavesItemsColor
            {
                Id = 199,
                eavesCollectionItemsEntity = collectionItem79,
                eavesColorsEntity = color7
            };
            var collectionItemColor200 = new EavesItemsColor
            {
                Id = 200,
                eavesCollectionItemsEntity = collectionItem80,
                eavesColorsEntity = color7
            };
            var collectionItemColor201 = new EavesItemsColor
            {
                Id = 201,
                eavesCollectionItemsEntity = collectionItem81,
                eavesColorsEntity = color7
            };
            var collectionItemColor202 = new EavesItemsColor
            {
                Id = 202,
                eavesCollectionItemsEntity = collectionItem82,
                eavesColorsEntity = color7
            };
            var collectionItemColor203 = new EavesItemsColor
            {
                Id = 203,
                eavesCollectionItemsEntity = collectionItem83,
                eavesColorsEntity = color7
            };
            var collectionItemColor204 = new EavesItemsColor
            {
                Id = 204,
                eavesCollectionItemsEntity = collectionItem84,
                eavesColorsEntity = color7
            };
            var collectionItemColor205 = new EavesItemsColor
            {
                Id = 205,
                eavesCollectionItemsEntity = collectionItem85,
                eavesColorsEntity = color8
            };
            var collectionItemColor206 = new EavesItemsColor
            {
                Id = 206,
                eavesCollectionItemsEntity = collectionItem85,
                eavesColorsEntity = color9
            };
            var collectionItemColor207 = new EavesItemsColor
            {
                Id = 207,
                eavesCollectionItemsEntity = collectionItem85,
                eavesColorsEntity = color10
            };
            var collectionItemColor208 = new EavesItemsColor
            {
                Id = 208,
                eavesCollectionItemsEntity = collectionItem85,
                eavesColorsEntity = color11
            };
            var collectionItemColor209 = new EavesItemsColor
            {
                Id = 209,
                eavesCollectionItemsEntity = collectionItem86,
                eavesColorsEntity = color8
            };
            var collectionItemColor210 = new EavesItemsColor
            {
                Id = 210,
                eavesCollectionItemsEntity = collectionItem86,
                eavesColorsEntity = color9
            };
            var collectionItemColor211 = new EavesItemsColor
            {
                Id = 211,
                eavesCollectionItemsEntity = collectionItem86,
                eavesColorsEntity = color10
            };
            var collectionItemColor212 = new EavesItemsColor
            {
                Id = 212,
                eavesCollectionItemsEntity = collectionItem86,
                eavesColorsEntity = color11
            };
            var collectionItemColor213 = new EavesItemsColor
            {
                Id = 213,
                eavesCollectionItemsEntity = collectionItem87,
                eavesColorsEntity = color8
            };
            var collectionItemColor214 = new EavesItemsColor
            {
                Id = 214,
                eavesCollectionItemsEntity = collectionItem87,
                eavesColorsEntity = color11
            };
            var collectionItemColor215 = new EavesItemsColor
            {
                Id = 215,
                eavesCollectionItemsEntity = collectionItem88,
                eavesColorsEntity = color8
            };
            var collectionItemColor216 = new EavesItemsColor
            {
                Id = 216,
                eavesCollectionItemsEntity = collectionItem88,
                eavesColorsEntity = color9
            };
            var collectionItemColor217 = new EavesItemsColor
            {
                Id = 217,
                eavesCollectionItemsEntity = collectionItem88,
                eavesColorsEntity = color10
            };
            var collectionItemColor218 = new EavesItemsColor
            {
                Id = 218,
                eavesCollectionItemsEntity = collectionItem88,
                eavesColorsEntity = color11
            };
            var collectionItemColor219 = new EavesItemsColor
            {
                Id = 219,
                eavesCollectionItemsEntity = collectionItem89,
                eavesColorsEntity = color8
            };
            var collectionItemColor220 = new EavesItemsColor
            {
                Id = 220,
                eavesCollectionItemsEntity = collectionItem90,
                eavesColorsEntity = color8
            };
            var collectionItemColor221 = new EavesItemsColor
            {
                Id = 221,
                eavesCollectionItemsEntity = collectionItem91,
                eavesColorsEntity = color8
            };
            var collectionItemColor222 = new EavesItemsColor
            {
                Id = 222,
                eavesCollectionItemsEntity = collectionItem92,
                eavesColorsEntity = color8
            };
            var collectionItemColor223 = new EavesItemsColor
            {
                Id = 223,
                eavesCollectionItemsEntity = collectionItem93,
                eavesColorsEntity = color8
            };
            var collectionItemColor224 = new EavesItemsColor
            {
                Id = 224,
                eavesCollectionItemsEntity = collectionItem94,
                eavesColorsEntity = color8
            };
            var collectionItemColor225 = new EavesItemsColor
            {
                Id = 225,
                eavesCollectionItemsEntity = collectionItem95,
                eavesColorsEntity = color8
            };
            context.EavesItemsColors.Add(collectionItemColor1);
            context.EavesItemsColors.Add(collectionItemColor2);
            context.EavesItemsColors.Add(collectionItemColor3);
            context.EavesItemsColors.Add(collectionItemColor4);
            context.EavesItemsColors.Add(collectionItemColor5);
            context.EavesItemsColors.Add(collectionItemColor6);
            context.EavesItemsColors.Add(collectionItemColor7);
            context.EavesItemsColors.Add(collectionItemColor8);
            context.EavesItemsColors.Add(collectionItemColor9);
            context.EavesItemsColors.Add(collectionItemColor10);
            context.EavesItemsColors.Add(collectionItemColor11);
            context.EavesItemsColors.Add(collectionItemColor12);
            context.EavesItemsColors.Add(collectionItemColor13);
            context.EavesItemsColors.Add(collectionItemColor14);
            context.EavesItemsColors.Add(collectionItemColor15);
            context.EavesItemsColors.Add(collectionItemColor16);
            context.EavesItemsColors.Add(collectionItemColor17);
            context.EavesItemsColors.Add(collectionItemColor18);
            context.EavesItemsColors.Add(collectionItemColor19);
            context.EavesItemsColors.Add(collectionItemColor20);
            context.EavesItemsColors.Add(collectionItemColor21);
            context.EavesItemsColors.Add(collectionItemColor22);
            context.EavesItemsColors.Add(collectionItemColor23);
            context.EavesItemsColors.Add(collectionItemColor24);
            context.EavesItemsColors.Add(collectionItemColor25);
            context.EavesItemsColors.Add(collectionItemColor26);
            context.EavesItemsColors.Add(collectionItemColor27);
            context.EavesItemsColors.Add(collectionItemColor28);
            context.EavesItemsColors.Add(collectionItemColor29);
            context.EavesItemsColors.Add(collectionItemColor30);
            context.EavesItemsColors.Add(collectionItemColor31);
            context.EavesItemsColors.Add(collectionItemColor32);
            context.EavesItemsColors.Add(collectionItemColor33);
            context.EavesItemsColors.Add(collectionItemColor34);
            context.EavesItemsColors.Add(collectionItemColor35);
            context.EavesItemsColors.Add(collectionItemColor36);
            context.EavesItemsColors.Add(collectionItemColor37);
            context.EavesItemsColors.Add(collectionItemColor38);
            context.EavesItemsColors.Add(collectionItemColor39);
            context.EavesItemsColors.Add(collectionItemColor40);
            context.EavesItemsColors.Add(collectionItemColor41);
            context.EavesItemsColors.Add(collectionItemColor42);
            context.EavesItemsColors.Add(collectionItemColor43);
            context.EavesItemsColors.Add(collectionItemColor44);
            context.EavesItemsColors.Add(collectionItemColor45);
            context.EavesItemsColors.Add(collectionItemColor46);
            context.EavesItemsColors.Add(collectionItemColor47);
            context.EavesItemsColors.Add(collectionItemColor48);
            context.EavesItemsColors.Add(collectionItemColor49);
            context.EavesItemsColors.Add(collectionItemColor50);
            context.EavesItemsColors.Add(collectionItemColor51);
            context.EavesItemsColors.Add(collectionItemColor52);
            context.EavesItemsColors.Add(collectionItemColor53);
            context.EavesItemsColors.Add(collectionItemColor54);
            context.EavesItemsColors.Add(collectionItemColor55);
            context.EavesItemsColors.Add(collectionItemColor56);
            context.EavesItemsColors.Add(collectionItemColor57);
            context.EavesItemsColors.Add(collectionItemColor58);
            context.EavesItemsColors.Add(collectionItemColor59);
            context.EavesItemsColors.Add(collectionItemColor60);
            context.EavesItemsColors.Add(collectionItemColor61);
            context.EavesItemsColors.Add(collectionItemColor62);
            context.EavesItemsColors.Add(collectionItemColor63);
            context.EavesItemsColors.Add(collectionItemColor64);
            context.EavesItemsColors.Add(collectionItemColor65);
            context.EavesItemsColors.Add(collectionItemColor66);
            context.EavesItemsColors.Add(collectionItemColor67);
            context.EavesItemsColors.Add(collectionItemColor68);
            context.EavesItemsColors.Add(collectionItemColor69);
            context.EavesItemsColors.Add(collectionItemColor70);
            context.EavesItemsColors.Add(collectionItemColor71);
            context.EavesItemsColors.Add(collectionItemColor72);
            context.EavesItemsColors.Add(collectionItemColor73);
            context.EavesItemsColors.Add(collectionItemColor74);
            context.EavesItemsColors.Add(collectionItemColor75);
            context.EavesItemsColors.Add(collectionItemColor76);
            context.EavesItemsColors.Add(collectionItemColor77);
            context.EavesItemsColors.Add(collectionItemColor78);
            context.EavesItemsColors.Add(collectionItemColor79);
            context.EavesItemsColors.Add(collectionItemColor80);
            context.EavesItemsColors.Add(collectionItemColor81);
            context.EavesItemsColors.Add(collectionItemColor82);
            context.EavesItemsColors.Add(collectionItemColor83);
            context.EavesItemsColors.Add(collectionItemColor84);
            context.EavesItemsColors.Add(collectionItemColor85);
            context.EavesItemsColors.Add(collectionItemColor86);
            context.EavesItemsColors.Add(collectionItemColor87);
            context.EavesItemsColors.Add(collectionItemColor88);
            context.EavesItemsColors.Add(collectionItemColor89);
            context.EavesItemsColors.Add(collectionItemColor90);
            context.EavesItemsColors.Add(collectionItemColor91);
            context.EavesItemsColors.Add(collectionItemColor92);
            context.EavesItemsColors.Add(collectionItemColor93);
            context.EavesItemsColors.Add(collectionItemColor94);
            context.EavesItemsColors.Add(collectionItemColor95);
            context.EavesItemsColors.Add(collectionItemColor96);
            context.EavesItemsColors.Add(collectionItemColor97);
            context.EavesItemsColors.Add(collectionItemColor98);
            context.EavesItemsColors.Add(collectionItemColor99);
            context.EavesItemsColors.Add(collectionItemColor100);
            context.EavesItemsColors.Add(collectionItemColor101);
            context.EavesItemsColors.Add(collectionItemColor102);
            context.EavesItemsColors.Add(collectionItemColor103);
            context.EavesItemsColors.Add(collectionItemColor104);
            context.EavesItemsColors.Add(collectionItemColor105);
            context.EavesItemsColors.Add(collectionItemColor106);
            context.EavesItemsColors.Add(collectionItemColor107);
            context.EavesItemsColors.Add(collectionItemColor108);
            context.EavesItemsColors.Add(collectionItemColor109);
            context.EavesItemsColors.Add(collectionItemColor110);
            context.EavesItemsColors.Add(collectionItemColor111);
            context.EavesItemsColors.Add(collectionItemColor112);
            context.EavesItemsColors.Add(collectionItemColor113);
            context.EavesItemsColors.Add(collectionItemColor114);
            context.EavesItemsColors.Add(collectionItemColor115);
            context.EavesItemsColors.Add(collectionItemColor116);
            context.EavesItemsColors.Add(collectionItemColor117);
            context.EavesItemsColors.Add(collectionItemColor118);
            context.EavesItemsColors.Add(collectionItemColor119);
            context.EavesItemsColors.Add(collectionItemColor120);
            context.EavesItemsColors.Add(collectionItemColor121);
            context.EavesItemsColors.Add(collectionItemColor122);
            context.EavesItemsColors.Add(collectionItemColor123);
            context.EavesItemsColors.Add(collectionItemColor124);
            context.EavesItemsColors.Add(collectionItemColor125);
            context.EavesItemsColors.Add(collectionItemColor126);
            context.EavesItemsColors.Add(collectionItemColor127);
            context.EavesItemsColors.Add(collectionItemColor128);
            context.EavesItemsColors.Add(collectionItemColor129);
            context.EavesItemsColors.Add(collectionItemColor130);
            context.EavesItemsColors.Add(collectionItemColor131);
            context.EavesItemsColors.Add(collectionItemColor132);
            context.EavesItemsColors.Add(collectionItemColor133);
            context.EavesItemsColors.Add(collectionItemColor134);
            context.EavesItemsColors.Add(collectionItemColor135);
            context.EavesItemsColors.Add(collectionItemColor136);
            context.EavesItemsColors.Add(collectionItemColor137);
            context.EavesItemsColors.Add(collectionItemColor138);
            context.EavesItemsColors.Add(collectionItemColor139);
            context.EavesItemsColors.Add(collectionItemColor140);
            context.EavesItemsColors.Add(collectionItemColor141);
            context.EavesItemsColors.Add(collectionItemColor142);
            context.EavesItemsColors.Add(collectionItemColor143);
            context.EavesItemsColors.Add(collectionItemColor144);
            context.EavesItemsColors.Add(collectionItemColor145);
            context.EavesItemsColors.Add(collectionItemColor146);
            context.EavesItemsColors.Add(collectionItemColor147);
            context.EavesItemsColors.Add(collectionItemColor148);
            context.EavesItemsColors.Add(collectionItemColor149);
            context.EavesItemsColors.Add(collectionItemColor150);
            context.EavesItemsColors.Add(collectionItemColor151);
            context.EavesItemsColors.Add(collectionItemColor152);
            context.EavesItemsColors.Add(collectionItemColor153);
            context.EavesItemsColors.Add(collectionItemColor154);
            context.EavesItemsColors.Add(collectionItemColor155);
            context.EavesItemsColors.Add(collectionItemColor156);
            context.EavesItemsColors.Add(collectionItemColor157);
            context.EavesItemsColors.Add(collectionItemColor158);
            context.EavesItemsColors.Add(collectionItemColor159);
            context.EavesItemsColors.Add(collectionItemColor160);
            context.EavesItemsColors.Add(collectionItemColor161);
            context.EavesItemsColors.Add(collectionItemColor162);
            context.EavesItemsColors.Add(collectionItemColor163);
            context.EavesItemsColors.Add(collectionItemColor164);
            context.EavesItemsColors.Add(collectionItemColor165);
            context.EavesItemsColors.Add(collectionItemColor166);
            context.EavesItemsColors.Add(collectionItemColor167);
            context.EavesItemsColors.Add(collectionItemColor168);
            context.EavesItemsColors.Add(collectionItemColor169);
            context.EavesItemsColors.Add(collectionItemColor170);
            context.EavesItemsColors.Add(collectionItemColor171);
            context.EavesItemsColors.Add(collectionItemColor172);
            context.EavesItemsColors.Add(collectionItemColor173);
            context.EavesItemsColors.Add(collectionItemColor174);
            context.EavesItemsColors.Add(collectionItemColor175);
            context.EavesItemsColors.Add(collectionItemColor176);
            context.EavesItemsColors.Add(collectionItemColor177);
            context.EavesItemsColors.Add(collectionItemColor178);
            context.EavesItemsColors.Add(collectionItemColor179);
            context.EavesItemsColors.Add(collectionItemColor180);
            context.EavesItemsColors.Add(collectionItemColor181);
            context.EavesItemsColors.Add(collectionItemColor182);
            context.EavesItemsColors.Add(collectionItemColor183);
            context.EavesItemsColors.Add(collectionItemColor184);
            context.EavesItemsColors.Add(collectionItemColor185);
            context.EavesItemsColors.Add(collectionItemColor186);
            context.EavesItemsColors.Add(collectionItemColor187);
            context.EavesItemsColors.Add(collectionItemColor188);
            context.EavesItemsColors.Add(collectionItemColor189);
            context.EavesItemsColors.Add(collectionItemColor190);
            context.EavesItemsColors.Add(collectionItemColor191);
            context.EavesItemsColors.Add(collectionItemColor192);
            context.EavesItemsColors.Add(collectionItemColor193);
            context.EavesItemsColors.Add(collectionItemColor194);
            context.EavesItemsColors.Add(collectionItemColor195);
            context.EavesItemsColors.Add(collectionItemColor196);
            context.EavesItemsColors.Add(collectionItemColor197);
            context.EavesItemsColors.Add(collectionItemColor198);
            context.EavesItemsColors.Add(collectionItemColor199);
            context.EavesItemsColors.Add(collectionItemColor200);
            context.EavesItemsColors.Add(collectionItemColor201);
            context.EavesItemsColors.Add(collectionItemColor202);
            context.EavesItemsColors.Add(collectionItemColor203);
            context.EavesItemsColors.Add(collectionItemColor204);
            context.EavesItemsColors.Add(collectionItemColor205);
            context.EavesItemsColors.Add(collectionItemColor206);
            context.EavesItemsColors.Add(collectionItemColor207);
            context.EavesItemsColors.Add(collectionItemColor208);
            context.EavesItemsColors.Add(collectionItemColor209);
            context.EavesItemsColors.Add(collectionItemColor210);
            context.EavesItemsColors.Add(collectionItemColor211);
            context.EavesItemsColors.Add(collectionItemColor212);
            context.EavesItemsColors.Add(collectionItemColor213);
            context.EavesItemsColors.Add(collectionItemColor214);
            context.EavesItemsColors.Add(collectionItemColor215);
            context.EavesItemsColors.Add(collectionItemColor216);
            context.EavesItemsColors.Add(collectionItemColor217);
            context.EavesItemsColors.Add(collectionItemColor218);
            context.EavesItemsColors.Add(collectionItemColor219);
            context.EavesItemsColors.Add(collectionItemColor220);
            context.EavesItemsColors.Add(collectionItemColor221);
            context.EavesItemsColors.Add(collectionItemColor222);
            context.EavesItemsColors.Add(collectionItemColor223);
            context.EavesItemsColors.Add(collectionItemColor224);
            context.EavesItemsColors.Add(collectionItemColor225);
            context.SaveChanges();
            
        }
    }
}
