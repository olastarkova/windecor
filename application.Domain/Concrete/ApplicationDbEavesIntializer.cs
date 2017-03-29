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
                Details = "<strong>Металлические карнизы &Oslash;16мм</strong> отлично подойдут для небольших помещений с шириной стены и высотой потолка не более 3х метров. Диаметр трубы 16мм - идеальный выбор для кухни или небольшой жилой комнаты. Разнообразие цветов и видов труб, а также большое количество наконечников, позволит выбрать карниз, подходящий любому стилю интерьера: от классического и кантри до хай-тек. Установка данного типа карнизов может осуществляться как на стеновых, так и на потолочных кронштейнах. По количеству рядов, карнизы &Oslash;16мм могут быть одинарными, двойными или тройными.<p>Все карнизы <strong>польской фабрики Marcin Dekor</strong> проходят специальную обработку и имеют <strong>гальваническое покрытие</strong>. Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии. Кроме того, <strong>гальваническое покрытие</strong> придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</p>",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series2 = new EavesCollection
            {
                Id = 2,
                Name = "19мм",
                Details = "<strong>Кованые металлические карнизы &Oslash;19мм</strong> пользуются большой популярностью, благодаря своим универсальным свойствам. Данный диаметр карниза отлично подойдет как для больших, так и для маленьких комнат с небольшой высотой потолка. Многообразие форм, видов труб и наконечников позволит подобрать карниз для любого стиля интерьера: от классического до хай-тек.<p>Все карнизы <strong> польской фабрики Marcin Dekor </strong> проходят специальную обработку и имеют <strong>гальваническое покрытие</strong>. Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии.Кроме того, <strong>гальваническое покрытие</strong> придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</p>",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series3 = new EavesCollection
            {
                Id = 3,
                Name = "25мм",
                Details = "<strong>Металлические карнизы &Oslash;25мм</strong> лучше всего подойдут для больших помещений с шириной стены и высотой потолка более 3х метров. Если Вы выбираете карниз в просторную гостиную, обратите внимание именно на диаметр труб 25мм, поскольку они достаточно объемны и массивны, чтобы не только прекрасно гармонировать с тяжелыми ночными шторами, но и без проблем выдержать их вес. Разнообразие цветов и видов труб, а также большое количество наконечников позволит выбрать карниз, подходящий любому стилю интерьера: от классического и кантри до хай-тек. По количеству рядов <strong>карнизы &Oslash;25мм</strong> могут быть <strong>одинарными</strong> или <strong>двойными</strong>, причем в качестве второго, дальнего, ряда используется труба диаметром 16мм, т.к. на ней будет располагаться легкая и невесомая тюль.<p>Все карнизы <strong>польской фабрики Marcin Dekor</strong> имеют <strong>гальваническое покрытие</strong>. Данный вид покрытия придает изделию определенный цвет, а также защищает карниз от окисления и коррозии.Кроме того, <strong>гальваническое покрытие</strong> придает изделию дополнительную прочность, износостойкость, декоративные и другие свойства.</p>",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series4 = new EavesCollection
            {
                Id = 4,
                Name = "Квадро",
                Details = "<strong>Металлические карнизы Квадро</strong> это идеальный выбор для тех, кто стремится подчеркнуть эксклюзивность своего интерьера. Трубы этих карнизов имеют форму квадрата 20х20мм. По количеству рядов <strong>карнизы Квадро</strong> могут быть одинарными или двойными.<p>Все карнизы <strong> польской фабрики Marcin Dekor </strong> проходят специальную обработку и имеют <strong>гальваническое покрытие</strong>. Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии.Кроме того, <strong>гальваническое покрытие</strong> придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</p>",
                eavesCategoriesEntity = eavesCategory2,
                eavesVendorsEntity = null
            };
            var series5 = new EavesCollection
            {
                Id = 5,
                Name = "Оникс 19мм",
                Details = "<strong>Металлические карнизы Оникс</strong> это отличное решение для современного интерьера. Необычный графитовый оттенок этих карнизов придаст любому интерьеру неповторимую индивидуальность. По количеству рядов <strong>карнизы Оникс</strong> могут быть одинарными или двойными. В комплект входят тихие кольца с зажимом или крючком.<p>Все карнизы <strong> польской фабрики Marcin Dekor </strong> проходят специальную обработку и имеют <strong>гальваническое покрытие</strong>. Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии.Кроме того, <strong>гальваническое покрытие</strong> придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</p>",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series6 = new EavesCollection
            {
                Id = 6,
                Name = "Оникс 25мм",
                Details = "<strong>Металлические карнизы Оникс</strong> это отличное решение для современного интерьера. Необычный графитовый оттенок этих карнизов придаст любому интерьеру неповторимую индивидуальность. По количеству рядов <strong>карнизы Оникс</strong> могут быть одинарными или двойными. В комплект входят тихие кольца с зажимом или крючком.<p>Все карнизы <strong> польской фабрики Marcin Dekor </strong> проходят специальную обработку и имеют <strong>гальваническое покрытие</strong>. Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии.Кроме того, <strong>гальваническое покрытие</strong> придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</p>",
                eavesCategoriesEntity = eavesCategoty1,
                eavesVendorsEntity = null
            };
            var series7 = new EavesCollection
            {
                Id = 7,
                Name = "Square Line (Сквайер Лайн)",
                Details = "<strong>Металлические карнизы Square Line (Сквайер Лайн)</strong> относятся к <strong>профильным карнизам</strong>. Это значит, что они не имеют колец, а ткань штор крепится к зажимам, которые передвигаются внутри профиля. В отличие от классических карнизов, кронштейны этих карнизов крепятся сверху профиля. Благодаря этому, полотно ткани беспрепятственно можно передвигать по всей длине карниза. По количеству рядов <strong>карнизы Square Line (Сквайер Лайн)</strong> могут быть одинарными, двойными или тройными.<p>Все карнизы <strong> польской фабрики Marcin Dekor </strong> проходят специальную обработку и имеют <strong>гальваническое покрытие</strong>. Данный вид покрытия не только придает изделию определенный цвет, но и защищает его от окисления и коррозии.Кроме того, <strong>гальваническое покрытие</strong> придает карнизу дополнительную прочность, износостойкость, декоративные и другие свойства.</p>",
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
            var pipeColor1 = new PipesColor
            {
                Id = 1,
                pipesEntity = pipe1,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color1
            };
            var pipeColor2 = new PipesColor
            {
                Id = 2,
                pipesEntity = pipe1,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color2
            };
            var pipeColor3 = new PipesColor
            {
                Id = 3,
                pipesEntity = pipe1,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color3
            };
            var pipeColor4 = new PipesColor
            {
                Id = 4,
                pipesEntity = pipe1,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color4
            };
            var pipeColor5 = new PipesColor
            {
                Id = 5,
                pipesEntity = pipe1,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color5
            };
            var pipeColor6 = new PipesColor
            {
                Id = 6,
                pipesEntity = pipe1,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color6
            };
            var pipeColor7 = new PipesColor
            {
                Id = 7,
                pipesEntity = pipe2,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color1
            };
            var pipeColor8 = new PipesColor
            {
                Id = 8,
                pipesEntity = pipe2,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color2
            };
            var pipeColor9 = new PipesColor
            {
                Id = 9,
                pipesEntity = pipe3,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color1
            };
            var pipeColor10 = new PipesColor
            {
                Id = 10,
                pipesEntity = pipe3,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color2
            };
            var pipeColor11 = new PipesColor
            {
                Id = 11,
                pipesEntity = pipe5,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color1
            };
            var pipeColor12 = new PipesColor
            {
                Id = 12,
                pipesEntity = pipe5,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color2
            };
            var pipeColor13 = new PipesColor
            {
                Id = 13,
                pipesEntity = pipe5,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color3
            };
            var pipeColor14 = new PipesColor
            {
                Id = 14,
                pipesEntity = pipe5,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color4
            };
            var pipeColor15 = new PipesColor
            {
                Id = 15,
                pipesEntity = pipe5,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color5
            };
            var pipeColor16 = new PipesColor
            {
                Id = 16,
                pipesEntity = pipe5,
                eavesCollectionEntity = series1,
                eavesColorsEntity = color6
            };
            var pipeColor17 = new PipesColor
            {
                Id = 17,
                pipesEntity = pipe1,
                eavesCollectionEntity = series2,
                eavesColorsEntity = color1
            };
            var pipeColor18 = new PipesColor
            {
                Id = 18,
                pipesEntity = pipe1,
                eavesCollectionEntity = series2,
                eavesColorsEntity = color2
            };
            var pipeColor19 = new PipesColor
            {
                Id = 19,
                pipesEntity = pipe1,
                eavesCollectionEntity = series2,
                eavesColorsEntity = color3
            };
            var pipeColor20 = new PipesColor
            {
                Id = 20,
                pipesEntity = pipe2,
                eavesCollectionEntity = series2,
                eavesColorsEntity = color1
            };
            var pipeColor21 = new PipesColor
            {
                Id = 21,
                pipesEntity = pipe3,
                eavesCollectionEntity = series2,
                eavesColorsEntity = color1
            };
            var pipeColor22 = new PipesColor
            {
                Id = 22,
                pipesEntity = pipe4,
                eavesCollectionEntity = series2,
                eavesColorsEntity = color1
            };
            var pipeColor23 = new PipesColor
            {
                Id = 23,
                pipesEntity = pipe1,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color1
            };
            var pipeColor24 = new PipesColor
            {
                Id = 24,
                pipesEntity = pipe1,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color2
            };
            var pipeColor25 = new PipesColor
            {
                Id = 25,
                pipesEntity = pipe1,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color3
            };
            var pipeColor26 = new PipesColor
            {
                Id = 26,
                pipesEntity = pipe2,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color1
            };
            var pipeColor27 = new PipesColor
            {
                Id = 27,
                pipesEntity = pipe2,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color2
            };
            var pipeColor28 = new PipesColor
            {
                Id = 28,
                pipesEntity = pipe3,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color1
            };
            var pipeColor29 = new PipesColor
            {
                Id = 29,
                pipesEntity = pipe3,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color2
            };
            var pipeColor30 = new PipesColor
            {
                Id = 30,
                pipesEntity = pipe5,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color1
            };
            var pipeColor31 = new PipesColor
            {
                Id = 31,
                pipesEntity = pipe5,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color2
            };
            var pipeColor32 = new PipesColor
            {
                Id = 32,
                pipesEntity = pipe5,
                eavesCollectionEntity = series3,
                eavesColorsEntity = color3
            };
            var pipeColor33 = new PipesColor
            {
                Id = 33,
                pipesEntity = pipe6,
                eavesCollectionEntity = series4,
                eavesColorsEntity = color1
            };
            var pipeColor34 = new PipesColor
            {
                Id = 34,
                pipesEntity = pipe6,
                eavesCollectionEntity = series4,
                eavesColorsEntity = color2
            };
            var pipeColor35 = new PipesColor
            {
                Id = 35,
                pipesEntity = pipe6,
                eavesCollectionEntity = series4,
                eavesColorsEntity = color6
            };
            var pipeColor36 = new PipesColor
            {
                Id = 36,
                pipesEntity = pipe7,
                eavesCollectionEntity = series5,
                eavesColorsEntity = color7
            };
            var pipeColor37 = new PipesColor
            {
                Id = 37,
                pipesEntity = pipe7,
                eavesCollectionEntity = series6,
                eavesColorsEntity = color7
            };
            var pipeColor38 = new PipesColor
            {
                Id = 38,
                pipesEntity = pipe8,
                eavesCollectionEntity = series7,
                eavesColorsEntity = color8
            };
            var pipeColor39 = new PipesColor
            {
                Id = 39,
                pipesEntity = pipe8,
                eavesCollectionEntity = series7,
                eavesColorsEntity = color9
            };
            var pipeColor40 = new PipesColor
            {
                Id = 40,
                pipesEntity = pipe8,
                eavesCollectionEntity = series7,
                eavesColorsEntity = color10
            };
            var pipeColor41 = new PipesColor
            {
                Id = 41,
                pipesEntity = pipe8,
                eavesCollectionEntity = series7,
                eavesColorsEntity = color11
            };
            context.PipesColors.Add(pipeColor1);
            context.PipesColors.Add(pipeColor2);
            context.PipesColors.Add(pipeColor3);
            context.PipesColors.Add(pipeColor4);
            context.PipesColors.Add(pipeColor5);
            context.PipesColors.Add(pipeColor6);
            context.PipesColors.Add(pipeColor7);
            context.PipesColors.Add(pipeColor8);
            context.PipesColors.Add(pipeColor9);
            context.PipesColors.Add(pipeColor10);
            context.PipesColors.Add(pipeColor11);
            context.PipesColors.Add(pipeColor12);
            context.PipesColors.Add(pipeColor13);
            context.PipesColors.Add(pipeColor14);
            context.PipesColors.Add(pipeColor15);
            context.PipesColors.Add(pipeColor16);
            context.PipesColors.Add(pipeColor17);
            context.PipesColors.Add(pipeColor18);
            context.PipesColors.Add(pipeColor19);
            context.PipesColors.Add(pipeColor20);
            context.PipesColors.Add(pipeColor21);
            context.PipesColors.Add(pipeColor22);
            context.PipesColors.Add(pipeColor23);
            context.PipesColors.Add(pipeColor24);
            context.PipesColors.Add(pipeColor25);
            context.PipesColors.Add(pipeColor26);
            context.PipesColors.Add(pipeColor27);
            context.PipesColors.Add(pipeColor28);
            context.PipesColors.Add(pipeColor29);
            context.PipesColors.Add(pipeColor30);
            context.PipesColors.Add(pipeColor31);
            context.PipesColors.Add(pipeColor32);
            context.PipesColors.Add(pipeColor33);
            context.PipesColors.Add(pipeColor34);
            context.PipesColors.Add(pipeColor35);
            context.PipesColors.Add(pipeColor36);
            context.PipesColors.Add(pipeColor37);
            context.PipesColors.Add(pipeColor38);
            context.PipesColors.Add(pipeColor39);
            context.PipesColors.Add(pipeColor40);
            context.PipesColors.Add(pipeColor41);
            context.SaveChanges();
            var pipeSize1 = new PipesSize
            {
                Id = 1,
                Size = 140
            };
            var pipeSize2 = new PipesSize
            {
                Id = 2,
                Size = 160
            };
            var pipeSize3 = new PipesSize
            {
                Id = 3,
                Size = 180
            };
            var pipeSize4 = new PipesSize
            {
                Id = 4,
                Size = 200
            };
            var pipeSize5 = new PipesSize
            {
                Id = 5,
                Size = 240
            };
            var pipeSize6 = new PipesSize
            {
                Id = 6,
                Size = 280
            };
            var pipeSize7 = new PipesSize
            {
                Id = 7,
                Size = 300
            };
            var pipeSize8 = new PipesSize
            {
                Id = 8,
                Size = 320
            };
            var pipeSize9 = new PipesSize
            {
                Id = 9,
                Size = 360
            };
            var pipeSize10= new PipesSize
            {
                Id = 10,
                Size = 400
            };
            var pipeSize11 = new PipesSize
            {
                Id = 11,
                Size = 480
            };
            var pipeSize12 = new PipesSize
            {
                Id = 12,
                Size = 600
            };
            context.PipesSizes.Add(pipeSize1);
            context.PipesSizes.Add(pipeSize2);
            context.PipesSizes.Add(pipeSize3);
            context.PipesSizes.Add(pipeSize4);
            context.PipesSizes.Add(pipeSize5);
            context.PipesSizes.Add(pipeSize6);
            context.PipesSizes.Add(pipeSize7);
            context.PipesSizes.Add(pipeSize8);
            context.PipesSizes.Add(pipeSize9);
            context.PipesSizes.Add(pipeSize10);
            context.PipesSizes.Add(pipeSize11);
            context.PipesSizes.Add(pipeSize12);
            context.SaveChanges();
            var eavesSize1 = new EavesSize
            {
                Id = 1,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize1
            };
            var eavesSize2 = new EavesSize
            {
                Id = 2,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize3 = new EavesSize
            {
                Id = 3,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize4 = new EavesSize
            {
                Id = 4,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize5 = new EavesSize
            {
                Id = 5,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize6 = new EavesSize
            {
                Id = 6,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize6
            };
            var eavesSize7 = new EavesSize
            {
                Id = 7,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize8 = new EavesSize
            {
                Id = 8,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize9 = new EavesSize
            {
                Id = 9,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize10 = new EavesSize
            {
                Id = 10,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1                                                          ,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize11 = new EavesSize
            {
                Id = 11,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize12 = new EavesSize
            {
                Id = 12,
                eavesCollectionEntity = series1,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize13 = new EavesSize
            {
                Id = 13,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize1
            };
            var eavesSize14 = new EavesSize
            {
                Id = 14,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize15 = new EavesSize
            {
                Id = 15,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize16 = new EavesSize
            {
                Id = 16,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize17 = new EavesSize
            {
                Id = 17,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize18 = new EavesSize
            {
                Id = 18,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize6
            };
            var eavesSize19 = new EavesSize
            {
                Id = 19,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize20 = new EavesSize
            {
                Id = 20,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize21 = new EavesSize
            {
                Id = 21,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize22 = new EavesSize
            {
                Id = 22,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize23 = new EavesSize
            {
                Id = 23,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize24 = new EavesSize
            {
                Id = 24,
                eavesCollectionEntity = series1,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize25 = new EavesSize
            {
                Id = 25,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize1
            };
            var eavesSize26 = new EavesSize
            {
                Id = 26,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize27 = new EavesSize
            {
                Id = 27,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize28 = new EavesSize
            {
                Id = 28,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize29 = new EavesSize
            {
                Id = 29,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize30 = new EavesSize
            {
                Id = 30,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize6
            };
            var eavesSize31 = new EavesSize
            {
                Id = 31,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize32 = new EavesSize
            {
                Id = 32,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize33 = new EavesSize
            {
                Id = 33,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize34 = new EavesSize
            {
                Id = 34,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize35 = new EavesSize
            {
                Id = 35,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize36 = new EavesSize
            {
                Id = 36,
                eavesCollectionEntity = series1,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize37 = new EavesSize
            {
                Id = 37,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize1
            };
            var eavesSize38 = new EavesSize
            {
                Id = 38,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize39 = new EavesSize
            {
                Id = 39,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize40 = new EavesSize
            {
                Id = 40,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize41 = new EavesSize
            {
                Id = 41,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize42 = new EavesSize
            {
                Id = 42,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize6
            };
            var eavesSize43 = new EavesSize
            {
                Id = 43,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize44 = new EavesSize
            {
                Id = 44,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize45 = new EavesSize
            {
                Id = 45,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize46 = new EavesSize
            {
                Id = 46,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize47 = new EavesSize
            {
                Id = 47,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize48 = new EavesSize
            {
                Id = 48,
                eavesCollectionEntity = series1,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize49 = new EavesSize
            {
                Id = 49,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize1
            };
            var eavesSize50 = new EavesSize
            {
                Id = 50,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize51 = new EavesSize
            {
                Id = 51,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize52 = new EavesSize
            {
                Id = 52,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize53 = new EavesSize
            {
                Id = 53,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize54 = new EavesSize
            {
                Id = 54,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize6
            };
            var eavesSize55 = new EavesSize
            {
                Id = 55,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize56 = new EavesSize
            {
                Id = 56,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize57 = new EavesSize
            {
                Id = 57,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize58 = new EavesSize
            {
                Id = 58,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize59 = new EavesSize
            {
                Id = 59,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize60 = new EavesSize
            {
                Id = 60,
                eavesCollectionEntity = series2,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize61 = new EavesSize
            {
                Id = 61,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize62 = new EavesSize
            {
                Id = 62,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize63 = new EavesSize
            {
                Id = 63,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize64 = new EavesSize
            {
                Id = 64,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize65 = new EavesSize
            {
                Id = 65,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize66 = new EavesSize
            {
                Id = 66,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize67 = new EavesSize
            {
                Id = 67,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize68 = new EavesSize
            {
                Id = 68,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize69 = new EavesSize
            {
                Id = 69,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize70 = new EavesSize
            {
                Id = 70,
                eavesCollectionEntity = series2,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize71 = new EavesSize
            {
                Id = 71,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize72 = new EavesSize
            {
                Id = 72,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize73 = new EavesSize
            {
                Id = 73,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize74 = new EavesSize
            {
                Id = 74,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize75 = new EavesSize
            {
                Id = 75,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize76 = new EavesSize
            {
                Id = 76,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize77 = new EavesSize
            {
                Id = 77,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize78 = new EavesSize
            {
                Id = 78,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize79 = new EavesSize
            {
                Id = 79,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize80 = new EavesSize
            {
                Id = 80,
                eavesCollectionEntity = series2,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize81 = new EavesSize
            {
                Id = 81,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize82 = new EavesSize
            {
                Id = 82,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize83 = new EavesSize
            {
                Id = 83,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize84 = new EavesSize
            {
                Id = 84,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize85 = new EavesSize
            {
                Id = 85,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize86 = new EavesSize
            {
                Id = 86,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize87 = new EavesSize
            {
                Id = 87,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize88 = new EavesSize
            {
                Id = 88,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize89 = new EavesSize
            {
                Id = 89,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize90 = new EavesSize
            {
                Id = 90,
                eavesCollectionEntity = series2,
                pipesEntity = pipe4,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize91 = new EavesSize
            {
                Id = 91,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize92 = new EavesSize
            {
                Id = 92,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize93 = new EavesSize
            {
                Id = 93,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize94 = new EavesSize
            {
                Id = 94,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize95 = new EavesSize
            {
                Id = 95,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize96 = new EavesSize
            {
                Id = 96,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize97 = new EavesSize
            {
                Id = 97,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize98 = new EavesSize
            {
                Id = 98,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize99 = new EavesSize
            {
                Id = 99,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize100 = new EavesSize
            {
                Id = 100,
                eavesCollectionEntity = series3,
                pipesEntity = pipe1,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize101 = new EavesSize
            {
                Id = 101,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize102 = new EavesSize
            {
                Id = 102,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize103 = new EavesSize
            {
                Id = 103,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize104 = new EavesSize
            {
                Id = 104,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize105 = new EavesSize
            {
                Id = 105,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize106 = new EavesSize
            {
                Id = 106,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize107 = new EavesSize
            {
                Id = 107,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize108 = new EavesSize
            {
                Id = 108,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize109 = new EavesSize
            {
                Id = 109,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize110 = new EavesSize
            {
                Id = 110,
                eavesCollectionEntity = series3,
                pipesEntity = pipe2,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize111 = new EavesSize
            {
                Id = 111,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize112 = new EavesSize
            {
                Id = 112,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize113 = new EavesSize
            {
                Id = 113,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize114 = new EavesSize
            {
                Id = 114,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize115 = new EavesSize
            {
                Id = 115,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize116 = new EavesSize
            {
                Id = 116,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize117 = new EavesSize
            {
                Id = 117,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize118 = new EavesSize
            {
                Id = 118,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize119 = new EavesSize
            {
                Id = 119,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize120 = new EavesSize
            {
                Id = 120,
                eavesCollectionEntity = series3,
                pipesEntity = pipe3,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize121 = new EavesSize
            {
                Id = 121,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize122 = new EavesSize
            {
                Id = 122,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize123 = new EavesSize
            {
                Id = 123,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize124 = new EavesSize
            {
                Id = 124,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize126 = new EavesSize
            {
                Id = 126,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize127 = new EavesSize
            {
                Id = 127,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize128 = new EavesSize
            {
                Id = 128,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize129 = new EavesSize
            {
                Id = 129,
                eavesCollectionEntity = series3,
                pipesEntity = pipe5,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize130 = new EavesSize
            {
                Id = 130,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize1
            };
            var eavesSize131 = new EavesSize
            {
                Id = 131,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize132 = new EavesSize
            {
                Id = 132,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize133 = new EavesSize
            {
                Id = 133,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize134 = new EavesSize
            {
                Id = 134,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize135 = new EavesSize
            {
                Id = 135,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize6
            };
            var eavesSize136 = new EavesSize
            {
                Id = 136,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize137 = new EavesSize
            {
                Id = 137,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize138 = new EavesSize
            {
                Id = 138,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize139 = new EavesSize
            {
                Id = 139,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize140 = new EavesSize
            {
                Id = 140,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize141 = new EavesSize
            {
                Id = 141,
                eavesCollectionEntity = series4,
                pipesEntity = pipe6,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize142 = new EavesSize
            {
                Id = 142,
                eavesCollectionEntity = series5,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize143 = new EavesSize
            {
                Id = 143,
                eavesCollectionEntity = series5,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize144 = new EavesSize
            {
                Id = 144,
                eavesCollectionEntity = series5,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize145 = new EavesSize
            {
                Id = 145,
                eavesCollectionEntity = series5,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize146 = new EavesSize
            {
                Id = 146,
                eavesCollectionEntity = series5,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize147 = new EavesSize
            {
                Id = 147,
                eavesCollectionEntity = series5,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize148 = new EavesSize
            {
                Id = 148,
                eavesCollectionEntity = series6,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize3
            };
            var eavesSize161 = new EavesSize
            {
                Id = 161,
                eavesCollectionEntity = series6,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize149 = new EavesSize
            {
                Id = 149,
                eavesCollectionEntity = series6,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize150 = new EavesSize
            {
                Id = 150,
                eavesCollectionEntity = series6,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize9
            };
            var eavesSize151 = new EavesSize
            {
                Id = 151,
                eavesCollectionEntity = series6,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize152 = new EavesSize
            {
                Id = 152,
                eavesCollectionEntity = series6,
                pipesEntity = pipe7,
                pipesSizeEntity = pipeSize12
            };
            var eavesSize153 = new EavesSize
            {
                Id = 153,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize2
            };
            var eavesSize154 = new EavesSize
            {
                Id = 154,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize4
            };
            var eavesSize155 = new EavesSize
            {
                Id = 155,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize5
            };
            var eavesSize156 = new EavesSize
            {
                Id = 156,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize7
            };
            var eavesSize157 = new EavesSize
            {
                Id = 157,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize8
            };
            var eavesSize158 = new EavesSize
            {
                Id = 158,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize10
            };
            var eavesSize159 = new EavesSize
            {
                Id = 159,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize11
            };
            var eavesSize160 = new EavesSize
            {
                Id = 160,
                eavesCollectionEntity = series7,
                pipesEntity = pipe8,
                pipesSizeEntity = pipeSize12
            };
            context.EavesSizes.Add(eavesSize1);
            context.EavesSizes.Add(eavesSize2);
            context.EavesSizes.Add(eavesSize3);
            context.EavesSizes.Add(eavesSize4);
            context.EavesSizes.Add(eavesSize5);
            context.EavesSizes.Add(eavesSize6);
            context.EavesSizes.Add(eavesSize7);
            context.EavesSizes.Add(eavesSize8);
            context.EavesSizes.Add(eavesSize9);
            context.EavesSizes.Add(eavesSize10);
            context.EavesSizes.Add(eavesSize11);
            context.EavesSizes.Add(eavesSize12);
            context.EavesSizes.Add(eavesSize13);
            context.EavesSizes.Add(eavesSize14);
            context.EavesSizes.Add(eavesSize15);
            context.EavesSizes.Add(eavesSize16);
            context.EavesSizes.Add(eavesSize17);
            context.EavesSizes.Add(eavesSize18);
            context.EavesSizes.Add(eavesSize19);
            context.EavesSizes.Add(eavesSize20);
            context.EavesSizes.Add(eavesSize21);
            context.EavesSizes.Add(eavesSize22);
            context.EavesSizes.Add(eavesSize23);
            context.EavesSizes.Add(eavesSize24);
            context.EavesSizes.Add(eavesSize25);
            context.EavesSizes.Add(eavesSize26);
            context.EavesSizes.Add(eavesSize27);
            context.EavesSizes.Add(eavesSize28);
            context.EavesSizes.Add(eavesSize29);
            context.EavesSizes.Add(eavesSize30);
            context.EavesSizes.Add(eavesSize31);
            context.EavesSizes.Add(eavesSize32);
            context.EavesSizes.Add(eavesSize33);
            context.EavesSizes.Add(eavesSize34);
            context.EavesSizes.Add(eavesSize35);
            context.EavesSizes.Add(eavesSize36);
            context.EavesSizes.Add(eavesSize37);
            context.EavesSizes.Add(eavesSize38);
            context.EavesSizes.Add(eavesSize39);
            context.EavesSizes.Add(eavesSize40);
            context.EavesSizes.Add(eavesSize41);
            context.EavesSizes.Add(eavesSize42);
            context.EavesSizes.Add(eavesSize43);
            context.EavesSizes.Add(eavesSize44);
            context.EavesSizes.Add(eavesSize45);
            context.EavesSizes.Add(eavesSize46);
            context.EavesSizes.Add(eavesSize47);
            context.EavesSizes.Add(eavesSize48);
            context.EavesSizes.Add(eavesSize49);
            context.EavesSizes.Add(eavesSize50);
            context.EavesSizes.Add(eavesSize51);
            context.EavesSizes.Add(eavesSize52);
            context.EavesSizes.Add(eavesSize53);
            context.EavesSizes.Add(eavesSize54);
            context.EavesSizes.Add(eavesSize55);
            context.EavesSizes.Add(eavesSize56);
            context.EavesSizes.Add(eavesSize57);
            context.EavesSizes.Add(eavesSize58);
            context.EavesSizes.Add(eavesSize59);
            context.EavesSizes.Add(eavesSize60);
            context.EavesSizes.Add(eavesSize61);
            context.EavesSizes.Add(eavesSize62);
            context.EavesSizes.Add(eavesSize63);
            context.EavesSizes.Add(eavesSize64);
            context.EavesSizes.Add(eavesSize65);
            context.EavesSizes.Add(eavesSize66);
            context.EavesSizes.Add(eavesSize67);
            context.EavesSizes.Add(eavesSize68);
            context.EavesSizes.Add(eavesSize69);
            context.EavesSizes.Add(eavesSize70);
            context.EavesSizes.Add(eavesSize71);
            context.EavesSizes.Add(eavesSize72);
            context.EavesSizes.Add(eavesSize73);
            context.EavesSizes.Add(eavesSize74);
            context.EavesSizes.Add(eavesSize75);
            context.EavesSizes.Add(eavesSize76);
            context.EavesSizes.Add(eavesSize77);
            context.EavesSizes.Add(eavesSize78);
            context.EavesSizes.Add(eavesSize79);
            context.EavesSizes.Add(eavesSize80);
            context.EavesSizes.Add(eavesSize81);
            context.EavesSizes.Add(eavesSize82);
            context.EavesSizes.Add(eavesSize83);
            context.EavesSizes.Add(eavesSize84);
            context.EavesSizes.Add(eavesSize85);
            context.EavesSizes.Add(eavesSize86);
            context.EavesSizes.Add(eavesSize87);
            context.EavesSizes.Add(eavesSize88);
            context.EavesSizes.Add(eavesSize89);
            context.EavesSizes.Add(eavesSize90);
            context.EavesSizes.Add(eavesSize91);
            context.EavesSizes.Add(eavesSize92);
            context.EavesSizes.Add(eavesSize93);
            context.EavesSizes.Add(eavesSize94);
            context.EavesSizes.Add(eavesSize95);
            context.EavesSizes.Add(eavesSize96);
            context.EavesSizes.Add(eavesSize97);
            context.EavesSizes.Add(eavesSize98);
            context.EavesSizes.Add(eavesSize99);
            context.EavesSizes.Add(eavesSize100);
            context.EavesSizes.Add(eavesSize101);
            context.EavesSizes.Add(eavesSize102);
            context.EavesSizes.Add(eavesSize103);
            context.EavesSizes.Add(eavesSize104);
            context.EavesSizes.Add(eavesSize105);
            context.EavesSizes.Add(eavesSize106);
            context.EavesSizes.Add(eavesSize107);
            context.EavesSizes.Add(eavesSize108);
            context.EavesSizes.Add(eavesSize109);
            context.EavesSizes.Add(eavesSize110);
            context.EavesSizes.Add(eavesSize111);
            context.EavesSizes.Add(eavesSize112);
            context.EavesSizes.Add(eavesSize113);
            context.EavesSizes.Add(eavesSize114);
            context.EavesSizes.Add(eavesSize115);
            context.EavesSizes.Add(eavesSize116);
            context.EavesSizes.Add(eavesSize117);
            context.EavesSizes.Add(eavesSize118);
            context.EavesSizes.Add(eavesSize119);
            context.EavesSizes.Add(eavesSize120);
            context.EavesSizes.Add(eavesSize121);
            context.EavesSizes.Add(eavesSize122);
            context.EavesSizes.Add(eavesSize123);
            context.EavesSizes.Add(eavesSize124);
            context.EavesSizes.Add(eavesSize126);
            context.EavesSizes.Add(eavesSize127);
            context.EavesSizes.Add(eavesSize128);
            context.EavesSizes.Add(eavesSize129);
            context.EavesSizes.Add(eavesSize130);
            context.EavesSizes.Add(eavesSize131);
            context.EavesSizes.Add(eavesSize132);
            context.EavesSizes.Add(eavesSize133);
            context.EavesSizes.Add(eavesSize134);
            context.EavesSizes.Add(eavesSize135);
            context.EavesSizes.Add(eavesSize136);
            context.EavesSizes.Add(eavesSize137);
            context.EavesSizes.Add(eavesSize138);
            context.EavesSizes.Add(eavesSize139);
            context.EavesSizes.Add(eavesSize140);
            context.EavesSizes.Add(eavesSize141);
            context.EavesSizes.Add(eavesSize142);
            context.EavesSizes.Add(eavesSize143);
            context.EavesSizes.Add(eavesSize144);
            context.EavesSizes.Add(eavesSize145);
            context.EavesSizes.Add(eavesSize146);
            context.EavesSizes.Add(eavesSize147);
            context.EavesSizes.Add(eavesSize148);
            context.EavesSizes.Add(eavesSize149);
            context.EavesSizes.Add(eavesSize150);
            context.EavesSizes.Add(eavesSize151);
            context.EavesSizes.Add(eavesSize152);
            context.EavesSizes.Add(eavesSize153);
            context.EavesSizes.Add(eavesSize154);
            context.EavesSizes.Add(eavesSize155);
            context.EavesSizes.Add(eavesSize156);
            context.EavesSizes.Add(eavesSize157);
            context.EavesSizes.Add(eavesSize158);
            context.EavesSizes.Add(eavesSize159);
            context.EavesSizes.Add(eavesSize160);
            context.EavesSizes.Add(eavesSize161);
            context.SaveChanges();
            var eaveType1 = new EavesType
            {
                Id = 1,
                Type = "Одинарный"
            };
             var eaveType2 = new EavesType
            {
                Id = 2,
                Type = "Двойной"
            };
            var eaveType3 = new EavesType
            {
                Id = 3,
                Type = "Тройной"
            };
            context.EavesTypes.Add(eaveType1);
            context.EavesTypes.Add(eaveType2);
            context.EavesTypes.Add(eaveType3);
            context.SaveChanges();
            var eaveCollectionType1 = new EavesCollectionType
            {
                Id = 1,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color1
               
            };
            var eaveCollectionType2 = new EavesCollectionType
            {
                Id = 2,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color2

            };
            var eaveCollectionType3 = new EavesCollectionType
            {
                Id = 3,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color3

            };
            var eaveCollectionType4 = new EavesCollectionType
            {
                Id = 4,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color4

            };
            var eaveCollectionType5 = new EavesCollectionType
            {
                Id = 5,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color5

            };
            var eaveCollectionType6 = new EavesCollectionType
            {
                Id = 6,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color6

            };
            var eaveCollectionType7 = new EavesCollectionType
            {
                Id = 7,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color1
            };
            var eaveCollectionType8 = new EavesCollectionType
            {
                Id = 8,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color2
            };
            var eaveCollectionType9 = new EavesCollectionType
            {
                Id = 9,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color3
            };
            var eaveCollectionType10 = new EavesCollectionType
            {
                Id = 10,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color4
            };
            var eaveCollectionType11 = new EavesCollectionType
            {
                Id = 11,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color5
            };
            var eaveCollectionType12 = new EavesCollectionType
            {
                Id = 12,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color6
            };
            var eaveCollectionType13 = new EavesCollectionType
            {
                Id = 13,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType3,
                eavesColorsEntity = color1
            };
            var eaveCollectionType14 = new EavesCollectionType
            {
                Id = 14,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType3,
                eavesColorsEntity = color2
            };
            var eaveCollectionType15 = new EavesCollectionType
            {
                Id = 15,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType3,
                eavesColorsEntity = color3
            };
            var eaveCollectionType16 = new EavesCollectionType
            {
                Id = 16,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color1
            };
            var eaveCollectionType17 = new EavesCollectionType
            {
                Id = 17,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color2

            };
            var eaveCollectionType18 = new EavesCollectionType
            {
                Id = 18,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color3

            };
            var eaveCollectionType19 = new EavesCollectionType
            {
                Id = 19,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color1
            };
            var eaveCollectionType20 = new EavesCollectionType
            {
                Id = 20,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color2
            };
            var eaveCollectionType21 = new EavesCollectionType
            {
                Id = 21,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color3
            };
            var eaveCollectionType22 = new EavesCollectionType
            {
                Id = 22,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color1
            };
            var eaveCollectionType23 = new EavesCollectionType
            {
                Id = 23,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color2
            };
            var eaveCollectionType24 = new EavesCollectionType
            {
                Id = 24,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color3
            };
            var eaveCollectionType25 = new EavesCollectionType
            {
                Id = 25,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color1
            };
            var eaveCollectionType26 = new EavesCollectionType
            {
                Id = 26,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color2
            };
            var eaveCollectionType27 = new EavesCollectionType
            {
                Id = 27,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color3
            };
            var eaveCollectionType28 = new EavesCollectionType
            {
                Id = 28,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color1
            };
            var eaveCollectionType29 = new EavesCollectionType
            {
                Id = 29,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color2
            };
            var eaveCollectionType30 = new EavesCollectionType
            {
                Id =30,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color3
            };
            var eaveCollectionType31 = new EavesCollectionType
            {
                Id = 31,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color1
            };
            var eaveCollectionType32 = new EavesCollectionType
            {
                Id = 32,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color2
            };
            var eaveCollectionType33 = new EavesCollectionType
            {
                Id = 33,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color3
            };
            var eaveCollectionType34 = new EavesCollectionType
            {
                Id = 34,
                eavesCollectionEntity = series5,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color7
            };
            var eaveCollectionType35 = new EavesCollectionType
            {
                Id = 35,
                eavesCollectionEntity = series5,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color7
            };
            var eaveCollectionType36 = new EavesCollectionType
            {
                Id = 36,
                eavesCollectionEntity = series6,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color7
            };
            var eaveCollectionType37 = new EavesCollectionType
            {
                Id = 37,
                eavesCollectionEntity = series6,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color7
            };
            var eaveCollectionType38 = new EavesCollectionType
            {
                Id = 38,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color8
            };
            var eaveCollectionType39 = new EavesCollectionType
            {
                Id = 39,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color9
            };
            var eaveCollectionType40 = new EavesCollectionType
            {
                Id = 40,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color10
            };
            var eaveCollectionType41 = new EavesCollectionType
            {
                Id = 41,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType1,
                eavesColorsEntity = color11
            };
            var eaveCollectionType42 = new EavesCollectionType
            {
                Id = 42,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color8

            };
            var eaveCollectionType43 = new EavesCollectionType
            {
                Id = 43,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color9

            };
            var eaveCollectionType44 = new EavesCollectionType
            {
                Id = 44,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color10

            };
            var eaveCollectionType45 = new EavesCollectionType
            {
                Id = 45,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType2,
                eavesColorsEntity = color11

            };
            var eaveCollectionType46 = new EavesCollectionType
            {
                Id = 46,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType3,
                eavesColorsEntity = color8
            };
            var eaveCollectionType47 = new EavesCollectionType
            {
                Id = 47,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType3,
                eavesColorsEntity = color9
            };
            var eaveCollectionType48 = new EavesCollectionType
            {
                Id = 48,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType3,
                eavesColorsEntity = color10
            };
            var eaveCollectionType49 = new EavesCollectionType
            {
                Id = 49,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType3,
                eavesColorsEntity = color11
            };
            context.EavesCollectionTypes.Add(eaveCollectionType1);
            context.EavesCollectionTypes.Add(eaveCollectionType2);
            context.EavesCollectionTypes.Add(eaveCollectionType3);
            context.EavesCollectionTypes.Add(eaveCollectionType4);
            context.EavesCollectionTypes.Add(eaveCollectionType5);
            context.EavesCollectionTypes.Add(eaveCollectionType6);
            context.EavesCollectionTypes.Add(eaveCollectionType7);
            context.EavesCollectionTypes.Add(eaveCollectionType8);
            context.EavesCollectionTypes.Add(eaveCollectionType9);
            context.EavesCollectionTypes.Add(eaveCollectionType10);
            context.EavesCollectionTypes.Add(eaveCollectionType11);
            context.EavesCollectionTypes.Add(eaveCollectionType12);
            context.EavesCollectionTypes.Add(eaveCollectionType13);
            context.EavesCollectionTypes.Add(eaveCollectionType14);
            context.EavesCollectionTypes.Add(eaveCollectionType15);
            context.EavesCollectionTypes.Add(eaveCollectionType16);
            context.EavesCollectionTypes.Add(eaveCollectionType17);
            context.EavesCollectionTypes.Add(eaveCollectionType18);
            context.EavesCollectionTypes.Add(eaveCollectionType19);
            context.EavesCollectionTypes.Add(eaveCollectionType20);
            context.EavesCollectionTypes.Add(eaveCollectionType21);
            context.EavesCollectionTypes.Add(eaveCollectionType22);
            context.EavesCollectionTypes.Add(eaveCollectionType23);
            context.EavesCollectionTypes.Add(eaveCollectionType24);
            context.EavesCollectionTypes.Add(eaveCollectionType25);
            context.EavesCollectionTypes.Add(eaveCollectionType26);
            context.EavesCollectionTypes.Add(eaveCollectionType27);
            context.EavesCollectionTypes.Add(eaveCollectionType28);
            context.EavesCollectionTypes.Add(eaveCollectionType29);
            context.EavesCollectionTypes.Add(eaveCollectionType30);
            context.EavesCollectionTypes.Add(eaveCollectionType31);
            context.EavesCollectionTypes.Add(eaveCollectionType32);
            context.EavesCollectionTypes.Add(eaveCollectionType33);
            context.EavesCollectionTypes.Add(eaveCollectionType34);
            context.EavesCollectionTypes.Add(eaveCollectionType35);
            context.EavesCollectionTypes.Add(eaveCollectionType36);
            context.EavesCollectionTypes.Add(eaveCollectionType37);
            context.EavesCollectionTypes.Add(eaveCollectionType38);
            context.EavesCollectionTypes.Add(eaveCollectionType39);
            context.EavesCollectionTypes.Add(eaveCollectionType40);
            context.EavesCollectionTypes.Add(eaveCollectionType41);
            context.EavesCollectionTypes.Add(eaveCollectionType42);
            context.EavesCollectionTypes.Add(eaveCollectionType43);
            context.EavesCollectionTypes.Add(eaveCollectionType44);
            context.EavesCollectionTypes.Add(eaveCollectionType45);
            context.EavesCollectionTypes.Add(eaveCollectionType46);
            context.EavesCollectionTypes.Add(eaveCollectionType47);
            context.EavesCollectionTypes.Add(eaveCollectionType48);
            context.EavesCollectionTypes.Add(eaveCollectionType49);
            context.SaveChanges();
            var fastening1 = new EavesFastening
            {
                Id = 1,
                Name = "Стеновое"
            };
            var fastening2 = new EavesFastening
            {
                Id = 2,
                Name = "Потолочное"

            };
            var fastening3 = new EavesFastening
            {
                Id = 3,
                Name = "Боковое"
            };
            context.EavesFastenings.Add(fastening1);
            context.EavesFastenings.Add(fastening2);
            context.EavesFastenings.Add(fastening3);
            context.SaveChanges();
            var collectionFastening1 = new EavesCollectionFastenings
            {
                Id = 1,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening2 = new EavesCollectionFastenings
            {
                Id = 2,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening2
            };
            var collectionFastening3 = new EavesCollectionFastenings
            {
                Id = 3,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening4 = new EavesCollectionFastenings
            {
                Id = 4,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening2
            };
            var collectionFastening5 = new EavesCollectionFastenings
            {
                Id = 5,
                eavesCollectionEntity = series1,
                eavesTypesEntity = eaveType3,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening6 = new EavesCollectionFastenings
            {
                Id = 6,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening7 = new EavesCollectionFastenings
            {
                Id = 7,
                eavesCollectionEntity = series2,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening8 = new EavesCollectionFastenings
            {
                Id = 8,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening9 = new EavesCollectionFastenings
            {
                Id = 9,
                eavesCollectionEntity = series3,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening10 = new EavesCollectionFastenings
            {
                Id = 10,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening11 = new EavesCollectionFastenings
            {
                Id = 11,
                eavesCollectionEntity = series4,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening12 = new EavesCollectionFastenings
            {
                Id = 12,
                eavesCollectionEntity = series5,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening13 = new EavesCollectionFastenings
            {
                Id = 13,
                eavesCollectionEntity = series5,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening14 = new EavesCollectionFastenings
            {
                Id = 14,
                eavesCollectionEntity = series6,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening15 = new EavesCollectionFastenings
            {
                Id = 15,
                eavesCollectionEntity = series6,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening16 = new EavesCollectionFastenings
            {
                Id = 16,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType1,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening17 = new EavesCollectionFastenings
            {
                Id = 17,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType2,
                eavesFasteningsEntity = fastening1
            };
            var collectionFastening18 = new EavesCollectionFastenings
            {
                Id = 18,
                eavesCollectionEntity = series7,
                eavesTypesEntity = eaveType3,
                eavesFasteningsEntity = fastening1
            };
            context.EavesCollectionFastenings.Add(collectionFastening1);
            context.EavesCollectionFastenings.Add(collectionFastening2);
            context.EavesCollectionFastenings.Add(collectionFastening3);
            context.EavesCollectionFastenings.Add(collectionFastening4);
            context.EavesCollectionFastenings.Add(collectionFastening5);
            context.EavesCollectionFastenings.Add(collectionFastening6);
            context.EavesCollectionFastenings.Add(collectionFastening7);
            context.EavesCollectionFastenings.Add(collectionFastening8);
            context.EavesCollectionFastenings.Add(collectionFastening9);
            context.EavesCollectionFastenings.Add(collectionFastening10);
            context.EavesCollectionFastenings.Add(collectionFastening11);
            context.EavesCollectionFastenings.Add(collectionFastening12);
            context.EavesCollectionFastenings.Add(collectionFastening13);
            context.EavesCollectionFastenings.Add(collectionFastening14);
            context.EavesCollectionFastenings.Add(collectionFastening15);
            context.EavesCollectionFastenings.Add(collectionFastening16);
            context.EavesCollectionFastenings.Add(collectionFastening17);
            context.EavesCollectionFastenings.Add(collectionFastening18);
            context.SaveChanges();
            var collectionFasteningColor1 = new EavesCollectionFasteningsByColor
            {
                Id = 1,
                eavesCollectionFasteningsEntity = collectionFastening1,
                eavesColors = color1
            };
            var collectionFasteningColor2 = new EavesCollectionFasteningsByColor
            {
                Id = 2,
                eavesCollectionFasteningsEntity = collectionFastening1,
                eavesColors = color2
            };
            var collectionFasteningColor3 = new EavesCollectionFasteningsByColor
            {
                Id = 3,
                eavesCollectionFasteningsEntity = collectionFastening1,
                eavesColors = color3
            };
            var collectionFasteningColor4 = new EavesCollectionFasteningsByColor
            {
                Id = 4,
                eavesCollectionFasteningsEntity = collectionFastening1,
                eavesColors = color4
            };
            var collectionFasteningColor5 = new EavesCollectionFasteningsByColor
            {
                Id = 5,
                eavesCollectionFasteningsEntity = collectionFastening1,
                eavesColors = color5
            };
            var collectionFasteningColor6 = new EavesCollectionFasteningsByColor
            {
                Id = 6,
                eavesCollectionFasteningsEntity = collectionFastening1,
                eavesColors = color6
            };
            var collectionFasteningColor7 = new EavesCollectionFasteningsByColor
            {
                Id = 7,
                eavesCollectionFasteningsEntity = collectionFastening2,
                eavesColors = color1
            };
            var collectionFasteningColor8 = new EavesCollectionFasteningsByColor
            {
                Id = 8,
                eavesCollectionFasteningsEntity = collectionFastening2,
                eavesColors = color2
            };
            var collectionFasteningColor9 = new EavesCollectionFasteningsByColor
            {
                Id = 9,
                eavesCollectionFasteningsEntity = collectionFastening2,
                eavesColors = color3
            };
            var collectionFasteningColor10 = new EavesCollectionFasteningsByColor
            {
                Id = 10,
                eavesCollectionFasteningsEntity = collectionFastening3,
                eavesColors = color1
            };
            var collectionFasteningColor11 = new EavesCollectionFasteningsByColor
            {
                Id = 11,
                eavesCollectionFasteningsEntity = collectionFastening3,
                eavesColors = color2
            };
            var collectionFasteningColor12 = new EavesCollectionFasteningsByColor
            {
                Id = 12,
                eavesCollectionFasteningsEntity = collectionFastening3,
                eavesColors = color3
            };
            var collectionFasteningColor13 = new EavesCollectionFasteningsByColor
            {
                Id = 13,
                eavesCollectionFasteningsEntity = collectionFastening3,
                eavesColors = color4
            };
            var collectionFasteningColor14 = new EavesCollectionFasteningsByColor
            {
                Id = 14,
                eavesCollectionFasteningsEntity = collectionFastening3,
                eavesColors = color5
            };
            var collectionFasteningColor15 = new EavesCollectionFasteningsByColor
            {
                Id = 15,
                eavesCollectionFasteningsEntity = collectionFastening3,
                eavesColors = color6
            };
            var collectionFasteningColor16 = new EavesCollectionFasteningsByColor
            {
                Id = 16,
                eavesCollectionFasteningsEntity = collectionFastening4,
                eavesColors = color1
            };
            var collectionFasteningColor17 = new EavesCollectionFasteningsByColor
            {
                Id = 17,
                eavesCollectionFasteningsEntity = collectionFastening4,
                eavesColors = color2
            };
            var collectionFasteningColor18 = new EavesCollectionFasteningsByColor
            {
                Id = 18,
                eavesCollectionFasteningsEntity = collectionFastening4,
                eavesColors = color3
            };
            var collectionFasteningColor19 = new EavesCollectionFasteningsByColor
            {
                Id = 19,
                eavesCollectionFasteningsEntity = collectionFastening5,
                eavesColors = color1
            };
            var collectionFasteningColor20 = new EavesCollectionFasteningsByColor
            {
                Id = 20,
                eavesCollectionFasteningsEntity = collectionFastening5,
                eavesColors = color2
            };
            var collectionFasteningColor21 = new EavesCollectionFasteningsByColor
            {
                Id = 21,
                eavesCollectionFasteningsEntity = collectionFastening5,
                eavesColors = color3
            };
            var collectionFasteningColor22 = new EavesCollectionFasteningsByColor
            {
                Id = 22,
                eavesCollectionFasteningsEntity = collectionFastening6,
                eavesColors = color1
            };
            var collectionFasteningColor23 = new EavesCollectionFasteningsByColor
            {
                Id = 23,
                eavesCollectionFasteningsEntity = collectionFastening6,
                eavesColors = color2
            };
            var collectionFasteningColor24 = new EavesCollectionFasteningsByColor
            {
                Id = 24,
                eavesCollectionFasteningsEntity = collectionFastening6,
                eavesColors = color3
            };
            var collectionFasteningColor25 = new EavesCollectionFasteningsByColor
            {
                Id = 25,
                eavesCollectionFasteningsEntity = collectionFastening7,
                eavesColors = color1
            };
            var collectionFasteningColor26 = new EavesCollectionFasteningsByColor
            {
                Id = 26,
                eavesCollectionFasteningsEntity = collectionFastening7,
                eavesColors = color2
            };
            var collectionFasteningColor28 = new EavesCollectionFasteningsByColor
            {
                Id = 28,
                eavesCollectionFasteningsEntity = collectionFastening7,
                eavesColors = color3
            };
            var collectionFasteningColor29 = new EavesCollectionFasteningsByColor
            {
                Id = 29,
                eavesCollectionFasteningsEntity = collectionFastening8,
                eavesColors = color1
            };
            var collectionFasteningColor30 = new EavesCollectionFasteningsByColor
            {
                Id = 30,
                eavesCollectionFasteningsEntity = collectionFastening8,
                eavesColors = color2
            };
            var collectionFasteningColor31 = new EavesCollectionFasteningsByColor
            {
                Id = 31,
                eavesCollectionFasteningsEntity = collectionFastening8,
                eavesColors = color3
            };
            var collectionFasteningColor32 = new EavesCollectionFasteningsByColor
            {
                Id = 32,
                eavesCollectionFasteningsEntity = collectionFastening9,
                eavesColors = color1
            };
            var collectionFasteningColor33 = new EavesCollectionFasteningsByColor
            {
                Id = 33,
                eavesCollectionFasteningsEntity = collectionFastening9,
                eavesColors = color2
            };
            var collectionFasteningColor34 = new EavesCollectionFasteningsByColor
            {
                Id = 34,
                eavesCollectionFasteningsEntity = collectionFastening9,
                eavesColors = color3
            };
            var collectionFasteningColor35 = new EavesCollectionFasteningsByColor
            {
                Id = 35,
                eavesCollectionFasteningsEntity = collectionFastening10,
                eavesColors = color1
            };
            var collectionFasteningColor36 = new EavesCollectionFasteningsByColor
            {
                Id = 36,
                eavesCollectionFasteningsEntity = collectionFastening10,
                eavesColors = color2
            };
            var collectionFasteningColor37 = new EavesCollectionFasteningsByColor
            {
                Id = 37,
                eavesCollectionFasteningsEntity = collectionFastening10,
                eavesColors = color3
            };
            var collectionFasteningColor38 = new EavesCollectionFasteningsByColor
            {
                Id = 38,
                eavesCollectionFasteningsEntity = collectionFastening11,
                eavesColors = color1
            };
            var collectionFasteningColor39 = new EavesCollectionFasteningsByColor
            {
                Id = 39,
                eavesCollectionFasteningsEntity = collectionFastening11,
                eavesColors = color2
            };
            var collectionFasteningColor40 = new EavesCollectionFasteningsByColor
            {
                Id = 40,
                eavesCollectionFasteningsEntity = collectionFastening11,
                eavesColors = color3
            };
            var collectionFasteningColor41 = new EavesCollectionFasteningsByColor
            {
                Id = 41,
                eavesCollectionFasteningsEntity = collectionFastening12,
                eavesColors = color7
            };
            var collectionFasteningColor42 = new EavesCollectionFasteningsByColor
            {
                Id = 42,
                eavesCollectionFasteningsEntity = collectionFastening13,
                eavesColors = color7
            };
            var collectionFasteningColor43 = new EavesCollectionFasteningsByColor
            {
                Id = 43,
                eavesCollectionFasteningsEntity = collectionFastening14,
                eavesColors = color7
            };
            var collectionFasteningColor44 = new EavesCollectionFasteningsByColor
            {
                Id = 44,
                eavesCollectionFasteningsEntity = collectionFastening15,
                eavesColors = color7
            };
            var collectionFasteningColor45 = new EavesCollectionFasteningsByColor
            {
                Id = 45,
                eavesCollectionFasteningsEntity = collectionFastening16,
                eavesColors = color8
            };
            var collectionFasteningColor46 = new EavesCollectionFasteningsByColor
            {
                Id = 46,
                eavesCollectionFasteningsEntity = collectionFastening16,
                eavesColors = color9
            };
            var collectionFasteningColor47 = new EavesCollectionFasteningsByColor
            {
                Id = 47,
                eavesCollectionFasteningsEntity = collectionFastening16,
                eavesColors = color10
            };
            var collectionFasteningColor48 = new EavesCollectionFasteningsByColor
            {
                Id = 48,
                eavesCollectionFasteningsEntity = collectionFastening16,
                eavesColors = color11
            };
            var collectionFasteningColor49 = new EavesCollectionFasteningsByColor
            {
                Id = 49,
                eavesCollectionFasteningsEntity = collectionFastening17,
                eavesColors = color8
            };
            var collectionFasteningColor50 = new EavesCollectionFasteningsByColor
            {
                Id = 50,
                eavesCollectionFasteningsEntity = collectionFastening17,
                eavesColors = color9
            };
            var collectionFasteningColor51 = new EavesCollectionFasteningsByColor
            {
                Id = 51,
                eavesCollectionFasteningsEntity = collectionFastening17,
                eavesColors = color10
            };
            var collectionFasteningColor52 = new EavesCollectionFasteningsByColor
            {
                Id = 52,
                eavesCollectionFasteningsEntity = collectionFastening17,
                eavesColors = color11
            };
            var collectionFasteningColor53 = new EavesCollectionFasteningsByColor
            {
                Id = 53,
                eavesCollectionFasteningsEntity = collectionFastening18,
                eavesColors = color8
            };
            var collectionFasteningColor54 = new EavesCollectionFasteningsByColor
            {
                Id = 54,
                eavesCollectionFasteningsEntity = collectionFastening18,
                eavesColors = color9
            };
            var collectionFasteningColor55 = new EavesCollectionFasteningsByColor
            {
                Id = 55,
                eavesCollectionFasteningsEntity = collectionFastening18,
                eavesColors = color10
            };
            var collectionFasteningColor56 = new EavesCollectionFasteningsByColor
            {
                Id = 56,
                eavesCollectionFasteningsEntity = collectionFastening18,
                eavesColors = color11
            };
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor1);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor2);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor3);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor4);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor5);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor6);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor7);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor8);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor9);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor10);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor11);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor12);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor13);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor14);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor15);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor16);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor17);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor18);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor19);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor20);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor21);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor22);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor23);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor24);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor25);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor26);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor28);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor29);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor30);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor31);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor32);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor33);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor34);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor35);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor36);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor37);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor38);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor39);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor40);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor41);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor42);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor43);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor44);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor45);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor46);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor47);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor48);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor49);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor50);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor51);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor52);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor53);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor54);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor55);
            context.EavesCollectionFasteningsByColors.Add(collectionFasteningColor56);
            context.SaveChanges();
            var ring1 = new Ring
            {
                Id = 1,
                RingName = "Обычное с зажимом"
            };
            var ring2 = new Ring
            {
                Id = 2,
                RingName = "Обычное с крючком"
            };
            var ring3 = new Ring
            {
                Id = 3,
                RingName = "Обычное"
            };
            var ring4 = new Ring
            {
                Id = 4,
                RingName = "Тихое округлое с зажимом"
            };
            var ring5 = new Ring
            {
                Id = 5,
                RingName = "Тихое округлое с крючком"
            };
            var ring6 = new Ring
            {
                Id = 6,
                RingName = "Тихое округлое"
            };
            var ring7 = new Ring
            {
                Id = 7,
                RingName = "Тихое плоское с зажимом"
            };
            var ring8 = new Ring
            {
                Id = 8,
                RingName = "Тихое плоское с крючком"
            };
            var ring9 = new Ring
            {
                Id = 9,
                RingName = "Тихое плоское"
            };
            var ring10 = new Ring
            {
                Id = 10,
                RingName = "Обычное Квадро с зажимом"
            };
            var ring11 = new Ring
            {
                Id = 11,
                RingName = "Обычное Квадро с крючком"
            };
            var ring12 = new Ring
            {
                Id = 12,
                RingName = "Обычное Квадро"
            };
            var ring13 = new Ring
            {
                Id = 13,
                RingName = "Тихое Квадро с зажимом"
            };
            var ring14 = new Ring
            {
                Id = 14,
                RingName = "Тихое Квадро с крючком"
            };
            var ring15 = new Ring
            {
                Id = 15,
                RingName = "Тихое Квадро"
            };
            var ring16 = new Ring
            {
                Id = 16,
                RingName = "Тихое плосткое Оникс с зажимом"
            };
            var ring17 = new Ring
            {
                Id = 17,
                RingName = "Тихое плоское Оникс с крючком"
            };
            var ring18 = new Ring
            {
                Id = 18,
                RingName = "Тихое плоское Оникс"
            };
            var ring19 = new Ring
            {
                Id = 19,
                RingName = "Без колец"
            };
            var ring20 = new Ring
            {
                Id = 20,
                RingName = "Зажим профильный"
            };
            var ring21 = new Ring
            {
                Id = 21,
                RingName = "Крючок профильный"
            };
            context.Rings.Add(ring1);
            context.Rings.Add(ring2);
            context.Rings.Add(ring3);
            context.Rings.Add(ring4);
            context.Rings.Add(ring5);
            context.Rings.Add(ring6);
            context.Rings.Add(ring7);
            context.Rings.Add(ring8);
            context.Rings.Add(ring9);
            context.Rings.Add(ring10);
            context.Rings.Add(ring11);
            context.Rings.Add(ring12);
            context.Rings.Add(ring13);
            context.Rings.Add(ring14);
            context.Rings.Add(ring15);
            context.Rings.Add(ring16);
            context.Rings.Add(ring17);
            context.Rings.Add(ring17);
            context.Rings.Add(ring18);
            context.Rings.Add(ring19);
            context.Rings.Add(ring20);
            context.Rings.Add(ring21);
            context.SaveChanges();
            var collectionRing1 = new EavesCollectionRing
            {
                Id = 1,
                eavesCollectionEntity = series1,
                ringsEntity = ring1,
                eavesColorsEntity = color1
            };
            var collectionRing2 = new EavesCollectionRing
            {
                Id = 2,
                eavesCollectionEntity = series1,
                ringsEntity = ring1,
                eavesColorsEntity = color2
            };
            var collectionRing3 = new EavesCollectionRing
            {
                Id = 3,
                eavesCollectionEntity = series1,
                ringsEntity = ring1,
                eavesColorsEntity = color3
            };
            var collectionRing4 = new EavesCollectionRing
            {
                Id = 4,
                eavesCollectionEntity = series1,
                ringsEntity = ring1,
                eavesColorsEntity = color4
            };
            var collectionRing5 = new EavesCollectionRing
            {
                Id = 5,
                eavesCollectionEntity = series1,
                ringsEntity = ring1,
                eavesColorsEntity = color5
            };
            var collectionRing6 = new EavesCollectionRing
            {
                Id = 6,
                eavesCollectionEntity = series1,
                ringsEntity = ring1,
                eavesColorsEntity = color6
            };
            var collectionRing7 = new EavesCollectionRing
            {
                Id = 7,
                eavesCollectionEntity = series1,
                ringsEntity = ring2,
                eavesColorsEntity = color1
            };
            var collectionRing8 = new EavesCollectionRing
            {
                Id = 8,
                eavesCollectionEntity = series1,
                ringsEntity = ring2,
                eavesColorsEntity = color2
            };
            var collectionRing9 = new EavesCollectionRing
            {
                Id = 9,
                eavesCollectionEntity = series1,
                ringsEntity = ring2,
                eavesColorsEntity = color3
            };
            var collectionRing10 = new EavesCollectionRing
            {
                Id = 10,
                eavesCollectionEntity = series1,
                ringsEntity = ring2,
                eavesColorsEntity = color4
            };
            var collectionRing11 = new EavesCollectionRing
            {
                Id = 11,
                eavesCollectionEntity = series1,
                ringsEntity = ring2,
                eavesColorsEntity = color5
            };
            var collectionRing12 = new EavesCollectionRing
            {
                Id = 12,
                eavesCollectionEntity = series1,
                ringsEntity = ring2,
                eavesColorsEntity = color6
            };
            var collectionRing13 = new EavesCollectionRing
            {
                Id = 13,
                eavesCollectionEntity = series1,
                ringsEntity = ring3,
                eavesColorsEntity = color1
            };
            var collectionRing14 = new EavesCollectionRing
            {
                Id = 14,
                eavesCollectionEntity = series1,
                ringsEntity = ring3,
                eavesColorsEntity = color2
            };
            var collectionRing15= new EavesCollectionRing
            {
                Id = 15,
                eavesCollectionEntity = series1,
                ringsEntity = ring3,
                eavesColorsEntity = color3
            };
            var collectionRing16 = new EavesCollectionRing
            {
                Id = 16,
                eavesCollectionEntity = series1,
                ringsEntity = ring3,
                eavesColorsEntity = color4
            };
            var collectionRing17 = new EavesCollectionRing
            {
                Id = 17,
                eavesCollectionEntity = series1,
                ringsEntity = ring3,
                eavesColorsEntity = color5
            };
            var collectionRing18 = new EavesCollectionRing
            {
                Id = 18,
                eavesCollectionEntity = series1,
                ringsEntity = ring3,
                eavesColorsEntity = color6
            };
            var collectionRing19 = new EavesCollectionRing
            {
                Id = 19,
                eavesCollectionEntity = series1,
                ringsEntity = ring4,
                eavesColorsEntity = color1
            };
            var collectionRing20 = new EavesCollectionRing
            {
                Id = 20,
                eavesCollectionEntity = series1,
                ringsEntity = ring4,
                eavesColorsEntity = color2
            };
            var collectionRing21 = new EavesCollectionRing
            {
                Id = 21,
                eavesCollectionEntity = series1,
                ringsEntity = ring4,
                eavesColorsEntity = color3
            };
            var collectionRing22 = new EavesCollectionRing
            {
                Id = 22,
                eavesCollectionEntity = series1,
                ringsEntity = ring5,
                eavesColorsEntity = color1
            };
            var collectionRing23 = new EavesCollectionRing
            {
                Id = 23,
                eavesCollectionEntity = series1,
                ringsEntity = ring5,
                eavesColorsEntity = color2
            };
            var collectionRing24 = new EavesCollectionRing
            {
                Id = 24,
                eavesCollectionEntity = series1,
                ringsEntity = ring5,
                eavesColorsEntity = color3
            };
            var collectionRing25 = new EavesCollectionRing
            {
                Id = 25,
                eavesCollectionEntity = series1,
                ringsEntity = ring6,
                eavesColorsEntity = color1
            };
            var collectionRing26 = new EavesCollectionRing
            {
                Id = 26,
                eavesCollectionEntity = series1,
                ringsEntity = ring6,
                eavesColorsEntity = color2
            };
            var collectionRing27 = new EavesCollectionRing
            {
                Id = 27,
                eavesCollectionEntity = series1,
                ringsEntity = ring6,
                eavesColorsEntity = color3
            };
            var collectionRing28 = new EavesCollectionRing
            {
                Id = 28,
                eavesCollectionEntity = series1,
                ringsEntity = ring7,
                eavesColorsEntity = color1
            };
            var collectionRing29 = new EavesCollectionRing
            {
                Id = 29,
                eavesCollectionEntity = series1,
                ringsEntity = ring7,
                eavesColorsEntity = color2
            };
            var collectionRing30 = new EavesCollectionRing
            {
                Id = 30,
                eavesCollectionEntity = series1,
                ringsEntity = ring8,
                eavesColorsEntity = color1
            };
            var collectionRing31 = new EavesCollectionRing
            {
                Id = 31,
                eavesCollectionEntity = series1,
                ringsEntity = ring8,
                eavesColorsEntity = color2
            };
            var collectionRing32 = new EavesCollectionRing
            {
                Id = 32,
                eavesCollectionEntity = series1,
                ringsEntity = ring9,
                eavesColorsEntity = color1
            };
            var collectionRing33 = new EavesCollectionRing
            {
                Id = 33,
                eavesCollectionEntity = series1,
                ringsEntity = ring9,
                eavesColorsEntity = color2
            };
            var collectionRing34 = new EavesCollectionRing
            {
                Id = 34,
                eavesCollectionEntity = series2,
                ringsEntity = ring1,
                eavesColorsEntity = color1
            };
            var collectionRing35 = new EavesCollectionRing
            {
                Id = 35,
                eavesCollectionEntity = series2,
                ringsEntity = ring1,
                eavesColorsEntity = color2
            };
            var collectionRing36 = new EavesCollectionRing
            {
                Id = 36,
                eavesCollectionEntity = series2,
                ringsEntity = ring1,
                eavesColorsEntity = color3
            };
            var collectionRing37 = new EavesCollectionRing
            {
                Id = 37,
                eavesCollectionEntity = series2,
                ringsEntity = ring2,
                eavesColorsEntity = color1
            };
            var collectionRing38 = new EavesCollectionRing
            {
                Id = 38,
                eavesCollectionEntity = series2,
                ringsEntity = ring2,
                eavesColorsEntity = color2
            };
            var collectionRing39 = new EavesCollectionRing
            {
                Id = 39,
                eavesCollectionEntity = series2,
                ringsEntity = ring2,
                eavesColorsEntity = color3
            };
            var collectionRing40 = new EavesCollectionRing
            {
                Id = 40,
                eavesCollectionEntity = series2,
                ringsEntity = ring3,
                eavesColorsEntity = color1
            };
            var collectionRing41 = new EavesCollectionRing
            {
                Id = 41,
                eavesCollectionEntity = series2,
                ringsEntity = ring3,
                eavesColorsEntity = color2
            };
            var collectionRing42 = new EavesCollectionRing
            {
                Id = 42,
                eavesCollectionEntity = series2,
                ringsEntity = ring3,
                eavesColorsEntity = color3
            };
            var collectionRing43 = new EavesCollectionRing
            {
                Id = 43,
                eavesCollectionEntity = series2,
                ringsEntity = ring4,
                eavesColorsEntity = color1
            };
            var collectionRing44 = new EavesCollectionRing
            {
                Id = 44,
                eavesCollectionEntity = series2,
                ringsEntity = ring4,
                eavesColorsEntity = color2
            };
            var collectionRing45 = new EavesCollectionRing
            {
                Id = 45,
                eavesCollectionEntity = series2,
                ringsEntity = ring4,
                eavesColorsEntity = color3
            };
            var collectionRing46 = new EavesCollectionRing
            {
                Id = 46,
                eavesCollectionEntity = series2,
                ringsEntity = ring5,
                eavesColorsEntity = color1
            };
            var collectionRing47 = new EavesCollectionRing
            {
                Id = 47,
                eavesCollectionEntity = series2,
                ringsEntity = ring5,
                eavesColorsEntity = color2
            };
            var collectionRing48 = new EavesCollectionRing
            {
                Id = 48,
                eavesCollectionEntity = series2,
                ringsEntity = ring5,
                eavesColorsEntity = color3
            };
            var collectionRing49 = new EavesCollectionRing
            {
                Id = 49,
                eavesCollectionEntity = series2,
                ringsEntity = ring6,
                eavesColorsEntity = color1
            };
            var collectionRing50 = new EavesCollectionRing
            {
                Id = 50,
                eavesCollectionEntity = series2,
                ringsEntity = ring6,
                eavesColorsEntity = color2
            };
            var collectionRing51 = new EavesCollectionRing
            {
                Id = 51,
                eavesCollectionEntity = series2,
                ringsEntity = ring6,
                eavesColorsEntity = color3
            };
            var collectionRing52 = new EavesCollectionRing
            {
                Id = 52,
                eavesCollectionEntity = series2,
                ringsEntity = ring7,
                eavesColorsEntity = color3
            };
            var collectionRing53 = new EavesCollectionRing
            {
                Id = 53,
                eavesCollectionEntity = series2,
                ringsEntity = ring8,
                eavesColorsEntity = color3
            };
            var collectionRing54 = new EavesCollectionRing
            {
                Id = 54,
                eavesCollectionEntity = series2,
                ringsEntity = ring9,
                eavesColorsEntity = color3
            };
            var collectionRing55 = new EavesCollectionRing
            {
                Id = 55,
                eavesCollectionEntity = series3,
                ringsEntity = ring1,
                eavesColorsEntity = color1
            };
            var collectionRing56 = new EavesCollectionRing
            {
                Id = 56,
                eavesCollectionEntity = series3,
                ringsEntity = ring1,
                eavesColorsEntity = color2
            };
            var collectionRing57 = new EavesCollectionRing
            {
                Id = 57,
                eavesCollectionEntity = series3,
                ringsEntity = ring1,
                eavesColorsEntity = color3
            };
            var collectionRing58 = new EavesCollectionRing
            {
                Id = 58,
                eavesCollectionEntity = series3,
                ringsEntity = ring2,
                eavesColorsEntity = color1
            };
            var collectionRing59 = new EavesCollectionRing
            {
                Id = 59,
                eavesCollectionEntity = series3,
                ringsEntity = ring2,
                eavesColorsEntity = color2
            };
            var collectionRing60 = new EavesCollectionRing
            {
                Id = 60,
                eavesCollectionEntity = series3,
                ringsEntity = ring2,
                eavesColorsEntity = color3
            };
            var collectionRing61 = new EavesCollectionRing
            {
                Id = 61,
                eavesCollectionEntity = series3,
                ringsEntity = ring3,
                eavesColorsEntity = color1
            };
            var collectionRing62 = new EavesCollectionRing
            {
                Id = 62,
                eavesCollectionEntity = series3,
                ringsEntity = ring3,
                eavesColorsEntity = color2
            };
            var collectionRing63 = new EavesCollectionRing
            {
                Id = 63,
                eavesCollectionEntity = series3,
                ringsEntity = ring3,
                eavesColorsEntity = color3
            };
            var collectionRing64 = new EavesCollectionRing
            {
                Id = 64,
                eavesCollectionEntity = series3,
                ringsEntity = ring4,
                eavesColorsEntity = color1
            };
            var collectionRing65 = new EavesCollectionRing
            {
                Id = 65,
                eavesCollectionEntity = series3,
                ringsEntity = ring4,
                eavesColorsEntity = color2
            };
            var collectionRing66 = new EavesCollectionRing
            {
                Id = 66,
                eavesCollectionEntity = series3,
                ringsEntity = ring4,
                eavesColorsEntity = color3
            };
            var collectionRing67 = new EavesCollectionRing
            {
                Id = 67,
                eavesCollectionEntity = series3,
                ringsEntity = ring5,
                eavesColorsEntity = color1
            };
            var collectionRing68 = new EavesCollectionRing
            {
                Id = 68,
                eavesCollectionEntity = series3,
                ringsEntity = ring5,
                eavesColorsEntity = color2
            };
            var collectionRing69 = new EavesCollectionRing
            {
                Id = 69,
                eavesCollectionEntity = series3,
                ringsEntity = ring5,
                eavesColorsEntity = color3
            };
            var collectionRing70 = new EavesCollectionRing
            {
                Id = 70,
                eavesCollectionEntity = series3,
                ringsEntity = ring6,
                eavesColorsEntity = color1
            };
            var collectionRing71 = new EavesCollectionRing
            {
                Id = 71,
                eavesCollectionEntity = series3,
                ringsEntity = ring6,
                eavesColorsEntity = color2
            };
            var collectionRing72 = new EavesCollectionRing
            {
                Id = 72,
                eavesCollectionEntity = series3,
                ringsEntity = ring6,
                eavesColorsEntity = color3
            };
            var collectionRing73 = new EavesCollectionRing
            {
                Id = 73,
                eavesCollectionEntity = series4,
                ringsEntity = ring13,
                eavesColorsEntity = color1
            };
            var collectionRing74 = new EavesCollectionRing
            {
                Id = 74,
                eavesCollectionEntity = series4,
                ringsEntity = ring13,
                eavesColorsEntity = color2
            };
            var collectionRing75 = new EavesCollectionRing
            {
                Id = 75,
                eavesCollectionEntity = series4,
                ringsEntity = ring13,
                eavesColorsEntity = color3
            };
            var collectionRing76 = new EavesCollectionRing
            {
                Id = 76,
                eavesCollectionEntity = series4,
                ringsEntity = ring14,
                eavesColorsEntity = color1
            };
            var collectionRing77 = new EavesCollectionRing
            {
                Id = 77,
                eavesCollectionEntity = series4,
                ringsEntity = ring14,
                eavesColorsEntity = color2
            };
            var collectionRing78 = new EavesCollectionRing
            {
                Id = 78,
                eavesCollectionEntity = series4,
                ringsEntity = ring14,
                eavesColorsEntity = color3
            };
            var collectionRing79 = new EavesCollectionRing
            {
                Id = 79,
                eavesCollectionEntity = series4,
                ringsEntity = ring15,
                eavesColorsEntity = color1
            };
            var collectionRing80 = new EavesCollectionRing
            {
                Id = 80,
                eavesCollectionEntity = series4,
                ringsEntity = ring15,
                eavesColorsEntity = color2
            };
            var collectionRing81 = new EavesCollectionRing
            {
                Id = 81,
                eavesCollectionEntity = series4,
                ringsEntity = ring15,
                eavesColorsEntity = color3
            };
            var collectionRing82 = new EavesCollectionRing
            {
                Id = 82,
                eavesCollectionEntity = series5,
                ringsEntity = ring16,
                eavesColorsEntity = color7
            };
            var collectionRing83 = new EavesCollectionRing
            {
                Id = 83,
                eavesCollectionEntity = series5,
                ringsEntity = ring17,
                eavesColorsEntity = color7
            };
            var collectionRing84 = new EavesCollectionRing
            {
                Id = 84,
                eavesCollectionEntity = series5,
                ringsEntity = ring18,
                eavesColorsEntity = color7
            };
            var collectionRing85 = new EavesCollectionRing
            {
                Id = 85,
                eavesCollectionEntity = series6,
                ringsEntity = ring16,
                eavesColorsEntity = color7
            };
            var collectionRing86 = new EavesCollectionRing
            {
                Id = 86,
                eavesCollectionEntity = series6,
                ringsEntity = ring17,
                eavesColorsEntity = color7
            };
            var collectionRing87 = new EavesCollectionRing
            {
                Id = 87,
                eavesCollectionEntity = series6,
                ringsEntity = ring18,
                eavesColorsEntity = color7
            };
            var collectionRing88 = new EavesCollectionRing
            {
                Id = 88,
                eavesCollectionEntity = series1,
                ringsEntity = ring19,
                eavesColorsEntity = color1
            };
            var collectionRing89 = new EavesCollectionRing
            {
                Id = 89,
                eavesCollectionEntity = series1,
                ringsEntity = ring19,
                eavesColorsEntity = color2
            };
            var collectionRing90 = new EavesCollectionRing
            {
                Id = 90,
                eavesCollectionEntity = series1,
                ringsEntity = ring19,
                eavesColorsEntity = color3
            };
            var collectionRing91 = new EavesCollectionRing
            {
                Id = 91,
                eavesCollectionEntity = series1,
                ringsEntity = ring19,
                eavesColorsEntity = color4
            };
            var collectionRing92 = new EavesCollectionRing
            {
                Id = 92,
                eavesCollectionEntity = series1,
                ringsEntity = ring19,
                eavesColorsEntity = color5
            };
            var collectionRing93 = new EavesCollectionRing
            {
                Id = 93,
                eavesCollectionEntity = series1,
                ringsEntity = ring19,
                eavesColorsEntity = color6
            };
            var collectionRing94 = new EavesCollectionRing
            {
                Id = 94,
                eavesCollectionEntity = series2,
                ringsEntity = ring19,
                eavesColorsEntity = color1
            };
            var collectionRing95 = new EavesCollectionRing
            {
                Id = 95,
                eavesCollectionEntity = series2,
                ringsEntity = ring19,
                eavesColorsEntity = color2
            };
            var collectionRing96 = new EavesCollectionRing
            {
                Id = 96,
                eavesCollectionEntity = series2,
                ringsEntity = ring19,
                eavesColorsEntity = color3
            };
            var collectionRing97 = new EavesCollectionRing
            {
                Id = 97,
                eavesCollectionEntity = series3,
                ringsEntity = ring19,
                eavesColorsEntity = color1
            };
            var collectionRing98 = new EavesCollectionRing
            {
                Id = 98,
                eavesCollectionEntity = series3,
                ringsEntity = ring19,
                eavesColorsEntity = color2
            };
            var collectionRing99 = new EavesCollectionRing
            {
                Id = 99,
                eavesCollectionEntity = series3,
                ringsEntity = ring19,
                eavesColorsEntity = color3
            };
            var collectionRing100 = new EavesCollectionRing
            {
                Id = 100,
                eavesCollectionEntity = series4,
                ringsEntity = ring19,
                eavesColorsEntity = color1
            };
            var collectionRing101 = new EavesCollectionRing
            {
                Id = 101,
                eavesCollectionEntity = series4,
                ringsEntity = ring19,
                eavesColorsEntity = color2
            };
            var collectionRing102 = new EavesCollectionRing
            {
                Id = 102,
                eavesCollectionEntity = series4,
                ringsEntity = ring19,
                eavesColorsEntity = color3
            };
            var collectionRing103 = new EavesCollectionRing
            {
                Id = 103,
                eavesCollectionEntity = series5,
                ringsEntity = ring19,
                eavesColorsEntity = color7
            };
            var collectionRing104 = new EavesCollectionRing
            {
                Id = 104,
                eavesCollectionEntity = series6,
                ringsEntity = ring19,
                eavesColorsEntity = color7
            };
            var collectionRing105 = new EavesCollectionRing
            {
                Id = 105,
                eavesCollectionEntity = series7,
                ringsEntity = ring20,
                eavesColorsEntity = color8
            };
            var collectionRing106 = new EavesCollectionRing
            {
                Id = 106,
                eavesCollectionEntity = series7,
                ringsEntity = ring20,
                eavesColorsEntity = color9
            };
            var collectionRing107 = new EavesCollectionRing
            {
                Id = 107,
                eavesCollectionEntity = series7,
                ringsEntity = ring20,
                eavesColorsEntity = color10
            };
            var collectionRing108 = new EavesCollectionRing
            {
                Id = 108,
                eavesCollectionEntity = series7,
                ringsEntity = ring20,
                eavesColorsEntity = color11
            };
            var collectionRing109 = new EavesCollectionRing
            {
                Id = 109,
                eavesCollectionEntity = series7,
                ringsEntity = ring21,
                eavesColorsEntity = color8
            };
            var collectionRing110 = new EavesCollectionRing
            {
                Id = 110,
                eavesCollectionEntity = series7,
                ringsEntity = ring21,
                eavesColorsEntity = color9
            };
            var collectionRing111 = new EavesCollectionRing
            {
                Id = 111,
                eavesCollectionEntity = series7,
                ringsEntity = ring21,
                eavesColorsEntity = color10
            };
            var collectionRing112 = new EavesCollectionRing
            {
                Id = 112,
                eavesCollectionEntity = series7,
                ringsEntity = ring21,
                eavesColorsEntity = color11
            };
            var collectionRing113 = new EavesCollectionRing
            {
                Id = 113,
                eavesCollectionEntity = series7,
                ringsEntity = ring19,
                eavesColorsEntity = color8
            };
            var collectionRing114 = new EavesCollectionRing
            {
                Id = 114,
                eavesCollectionEntity = series7,
                ringsEntity = ring19,
                eavesColorsEntity = color9
            };
            var collectionRing115 = new EavesCollectionRing
            {
                Id = 115,
                eavesCollectionEntity = series7,
                ringsEntity = ring19,
                eavesColorsEntity = color10
            };
            var collectionRing116 = new EavesCollectionRing
            {
                Id = 116,
                eavesCollectionEntity = series7,
                ringsEntity = ring19,
                eavesColorsEntity = color11
            };
            context.EavesCollectionRings.Add(collectionRing1);
            context.EavesCollectionRings.Add(collectionRing2);
            context.EavesCollectionRings.Add(collectionRing3);
            context.EavesCollectionRings.Add(collectionRing4);
            context.EavesCollectionRings.Add(collectionRing5);
            context.EavesCollectionRings.Add(collectionRing6);
            context.EavesCollectionRings.Add(collectionRing7);
            context.EavesCollectionRings.Add(collectionRing8);
            context.EavesCollectionRings.Add(collectionRing9);
            context.EavesCollectionRings.Add(collectionRing10);
            context.EavesCollectionRings.Add(collectionRing11);
            context.EavesCollectionRings.Add(collectionRing12);
            context.EavesCollectionRings.Add(collectionRing13);
            context.EavesCollectionRings.Add(collectionRing14);
            context.EavesCollectionRings.Add(collectionRing15);
            context.EavesCollectionRings.Add(collectionRing16);
            context.EavesCollectionRings.Add(collectionRing17);
            context.EavesCollectionRings.Add(collectionRing18);
            context.EavesCollectionRings.Add(collectionRing19);
            context.EavesCollectionRings.Add(collectionRing20);
            context.EavesCollectionRings.Add(collectionRing21);
            context.EavesCollectionRings.Add(collectionRing22);
            context.EavesCollectionRings.Add(collectionRing23);
            context.EavesCollectionRings.Add(collectionRing24);
            context.EavesCollectionRings.Add(collectionRing25);
            context.EavesCollectionRings.Add(collectionRing26);
            context.EavesCollectionRings.Add(collectionRing27);
            context.EavesCollectionRings.Add(collectionRing28);
            context.EavesCollectionRings.Add(collectionRing29);
            context.EavesCollectionRings.Add(collectionRing30);
            context.EavesCollectionRings.Add(collectionRing31);
            context.EavesCollectionRings.Add(collectionRing32);
            context.EavesCollectionRings.Add(collectionRing33);
            context.EavesCollectionRings.Add(collectionRing34);
            context.EavesCollectionRings.Add(collectionRing35);
            context.EavesCollectionRings.Add(collectionRing36);
            context.EavesCollectionRings.Add(collectionRing37);
            context.EavesCollectionRings.Add(collectionRing38);
            context.EavesCollectionRings.Add(collectionRing39);
            context.EavesCollectionRings.Add(collectionRing40);
            context.EavesCollectionRings.Add(collectionRing41);
            context.EavesCollectionRings.Add(collectionRing42);
            context.EavesCollectionRings.Add(collectionRing43);
            context.EavesCollectionRings.Add(collectionRing44);
            context.EavesCollectionRings.Add(collectionRing45);
            context.EavesCollectionRings.Add(collectionRing46);
            context.EavesCollectionRings.Add(collectionRing47);
            context.EavesCollectionRings.Add(collectionRing48);
            context.EavesCollectionRings.Add(collectionRing49);
            context.EavesCollectionRings.Add(collectionRing50);
            context.EavesCollectionRings.Add(collectionRing51);
            context.EavesCollectionRings.Add(collectionRing52);
            context.EavesCollectionRings.Add(collectionRing53);
            context.EavesCollectionRings.Add(collectionRing54);
            context.EavesCollectionRings.Add(collectionRing55);
            context.EavesCollectionRings.Add(collectionRing56);
            context.EavesCollectionRings.Add(collectionRing57);
            context.EavesCollectionRings.Add(collectionRing58);
            context.EavesCollectionRings.Add(collectionRing59);
            context.EavesCollectionRings.Add(collectionRing60);
            context.EavesCollectionRings.Add(collectionRing61);
            context.EavesCollectionRings.Add(collectionRing62);
            context.EavesCollectionRings.Add(collectionRing63);
            context.EavesCollectionRings.Add(collectionRing64);
            context.EavesCollectionRings.Add(collectionRing65);
            context.EavesCollectionRings.Add(collectionRing66);
            context.EavesCollectionRings.Add(collectionRing67);
            context.EavesCollectionRings.Add(collectionRing68);
            context.EavesCollectionRings.Add(collectionRing69);
            context.EavesCollectionRings.Add(collectionRing70);
            context.EavesCollectionRings.Add(collectionRing71);
            context.EavesCollectionRings.Add(collectionRing72);
            context.EavesCollectionRings.Add(collectionRing73);
            context.EavesCollectionRings.Add(collectionRing74);
            context.EavesCollectionRings.Add(collectionRing75);
            context.EavesCollectionRings.Add(collectionRing76);
            context.EavesCollectionRings.Add(collectionRing77);
            context.EavesCollectionRings.Add(collectionRing78);
            context.EavesCollectionRings.Add(collectionRing79);
            context.EavesCollectionRings.Add(collectionRing80);
            context.EavesCollectionRings.Add(collectionRing81);
            context.EavesCollectionRings.Add(collectionRing82);
            context.EavesCollectionRings.Add(collectionRing83);
            context.EavesCollectionRings.Add(collectionRing84);
            context.EavesCollectionRings.Add(collectionRing85);
            context.EavesCollectionRings.Add(collectionRing86);
            context.EavesCollectionRings.Add(collectionRing87);
            context.EavesCollectionRings.Add(collectionRing88);
            context.EavesCollectionRings.Add(collectionRing89);
            context.EavesCollectionRings.Add(collectionRing90);
            context.EavesCollectionRings.Add(collectionRing91);
            context.EavesCollectionRings.Add(collectionRing92);
            context.EavesCollectionRings.Add(collectionRing93);
            context.EavesCollectionRings.Add(collectionRing94);
            context.EavesCollectionRings.Add(collectionRing95);
            context.EavesCollectionRings.Add(collectionRing96);
            context.EavesCollectionRings.Add(collectionRing97);
            context.EavesCollectionRings.Add(collectionRing98);
            context.EavesCollectionRings.Add(collectionRing99);
            context.EavesCollectionRings.Add(collectionRing100);
            context.EavesCollectionRings.Add(collectionRing101);
            context.EavesCollectionRings.Add(collectionRing102);
            context.EavesCollectionRings.Add(collectionRing103);
            context.EavesCollectionRings.Add(collectionRing104);
            context.EavesCollectionRings.Add(collectionRing105);
            context.EavesCollectionRings.Add(collectionRing106);
            context.EavesCollectionRings.Add(collectionRing107);
            context.EavesCollectionRings.Add(collectionRing108);
            context.EavesCollectionRings.Add(collectionRing109);
            context.EavesCollectionRings.Add(collectionRing110);
            context.EavesCollectionRings.Add(collectionRing111);
            context.EavesCollectionRings.Add(collectionRing112);
            context.EavesCollectionRings.Add(collectionRing113);
            context.EavesCollectionRings.Add(collectionRing114);
            context.EavesCollectionRings.Add(collectionRing115);
            context.EavesCollectionRings.Add(collectionRing116);
            context.SaveChanges();
        }
    }
}
