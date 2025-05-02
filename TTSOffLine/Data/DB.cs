using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTSOffLine.Models;

namespace TTSOffLine.Data
{
    internal class DB
    {
        internal List<WordModel> words = new List<WordModel>()
        {
            new WordModel { Arab = "موز", Eng = "Banana" },
            new WordModel { Arab = "تفاح", Eng = "Apple" },
            new WordModel { Arab = "برتقال", Eng = "Orange" },
            new WordModel { Arab = "عنب", Eng = "Grapes" },
            new WordModel { Arab = "مانجو", Eng = "Mango" },
            new WordModel { Arab = "فراولة", Eng = "Strawberry" },
            new WordModel { Arab = "أناناس", Eng = "Pineapple" },
            new WordModel { Arab = "بطيخ", Eng = "Watermelon" },
            new WordModel { Arab = "شمام", Eng = "Melon" },
            new WordModel { Arab = "كيوي", Eng = "Kiwi" },
            new WordModel { Arab = "رمان", Eng = "Pomegranate" },
            new WordModel { Arab = "خوخ", Eng = "Peach" },
            new WordModel { Arab = "مشمش", Eng = "Apricot" },
            new WordModel { Arab = "كمثرى", Eng = "Pear" },
            new WordModel { Arab = "توت", Eng = "Berry" },
            new WordModel { Arab = "ليمون", Eng = "Lemon" },
            new WordModel { Arab = "جوافة", Eng = "Guava" },
            new WordModel { Arab = "تين", Eng = "Fig" },
            new WordModel { Arab = "تمر", Eng = "Date" },
            new WordModel { Arab = "بابايا", Eng = "Papaya" },
            new WordModel { Arab = "جريب فروت", Eng = "Grapefruit" },
            new WordModel { Arab = "كرز", Eng = "Cherry" },
            new WordModel { Arab = "توت أزرق", Eng = "Blueberry" },
            new WordModel { Arab = "توت أسود", Eng = "Blackberry" },
            new WordModel { Arab = "توت أحمر", Eng = "Raspberry" },
            new WordModel { Arab = "جوز الهند", Eng = "Coconut" },
            new WordModel { Arab = "باسيفلورا", Eng = "Passion Fruit" },
            new WordModel { Arab = "رامبوتان", Eng = "Rambutan" },
            new WordModel { Arab = "ليتشي", Eng = "Lychee" },
            new WordModel { Arab = "دراغون فروت", Eng = "Dragon Fruit" },
            new WordModel { Arab = "نكتارين", Eng = "Nectarine" },
            new WordModel { Arab = "كاكا", Eng = "Persimmon" },
            new WordModel { Arab = "سفرجل", Eng = "Quince" },
            new WordModel { Arab = "كشمش", Eng = "Currant" },
            new WordModel { Arab = "أفوكادو", Eng = "Avocado" },
            new WordModel { Arab = "طماطم", Eng = "Tomato" },
            new WordModel { Arab = "خيار", Eng = "Cucumber" },
            new WordModel { Arab = "جزر", Eng = "Carrot" },
            new WordModel { Arab = "بطاطا", Eng = "Potato" },
            new WordModel { Arab = "بصل", Eng = "Onion" },
            new WordModel { Arab = "ثوم", Eng = "Garlic" },
            new WordModel { Arab = "فلفل", Eng = "Pepper" },
            new WordModel { Arab = "فلفل حار", Eng = "Chili Pepper" },
            new WordModel { Arab = "باذنجان", Eng = "Eggplant" },
            new WordModel { Arab = "كوسا", Eng = "Zucchini" },
            new WordModel { Arab = "قرنبيط", Eng = "Cauliflower" },
            new WordModel { Arab = "بروكلي", Eng = "Broccoli" },
            new WordModel { Arab = "خس", Eng = "Lettuce" },
            new WordModel { Arab = "سبانخ", Eng = "Spinach" },
            new WordModel { Arab = "كرنب", Eng = "Cabbage" },
            new WordModel { Arab = "فجل", Eng = "Radish" },
            new WordModel { Arab = "شمندر", Eng = "Beetroot" },
            new WordModel { Arab = "كرفس", Eng = "Celery" },
            new WordModel { Arab = "بقدونس", Eng = "Parsley" },
            new WordModel { Arab = "كزبرة", Eng = "Coriander" },
            new WordModel { Arab = "نعناع", Eng = "Mint" },
            new WordModel { Arab = "ريحان", Eng = "Basil" },
            new WordModel { Arab = "شبت", Eng = "Dill" },
            new WordModel { Arab = "جرجير", Eng = "Arugula" },
            new WordModel { Arab = "بامية", Eng = "Okra" },
            new WordModel { Arab = "فاصوليا", Eng = "Beans" },
            new WordModel { Arab = "بازلاء", Eng = "Peas" },
            new WordModel { Arab = "عدس", Eng = "Lentils" },
            new WordModel { Arab = "حمص", Eng = "Chickpeas" },
            new WordModel { Arab = "ذرة", Eng = "Corn" },
            new WordModel { Arab = "يقطين", Eng = "Pumpkin" },
            new WordModel { Arab = "خرشوف", Eng = "Artichoke" },
            new WordModel { Arab = "هليون", Eng = "Asparagus" },
            new WordModel { Arab = "زنجبيل", Eng = "Ginger" },
            new WordModel { Arab = "فطر", Eng = "Mushroom" },
            new WordModel { Arab = "زيتون", Eng = "Olive" },
            new WordModel { Arab = "تمر هندي", Eng = "Tamarind" },
            new WordModel { Arab = "كركم", Eng = "Turmeric" },
            new WordModel { Arab = "ليمون حامض", Eng = "Lime" },
            new WordModel { Arab = "بصل أخضر", Eng = "Green Onion" },
            new WordModel { Arab = "فجل أبيض", Eng = "Daikon" },
            new WordModel { Arab = "بطاطا حلوة", Eng = "Sweet Potato" },
            new WordModel { Arab = "كستناء", Eng = "Chestnut" },
            new WordModel { Arab = "جوز", Eng = "Walnut" },
            new WordModel { Arab = "لوز", Eng = "Almond" },
            new WordModel { Arab = "فستق", Eng = "Pistachio" },
            new WordModel { Arab = "بندق", Eng = "Hazelnut" },
            new WordModel { Arab = "كاجو", Eng = "Cashew" },
            new WordModel { Arab = "صنوبر", Eng = "Pine Nut" },
            new WordModel { Arab = "سمسم", Eng = "Sesame" },
            new WordModel { Arab = "حب الرشاد", Eng = "Garden Cress" }
        };
        public List<WordModel> GetAll()
        {
            var list = new List<WordModel>();
            list = words;
            return list;
        }
    }
}