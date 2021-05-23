using AdamBednarzLab4ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab4ZadDom.Controllers
{
    public class HomeController : Controller
    {
        // lista modeli grup krwi
        List<BloodViewModel> primaryBloodTypes;
        // lista modeli koloru oczu
        List<EyesViewModel> primaryEyesColors;
        // lista modeli znaków zodiaku
        List<ZodiacViewModel> primaryZodiacSigns;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            // tworzenie modeli w listach
            CreateBloodTypes();
            CreateEyesColor();
            CreateZodiacSigns();
        }

        /// <summary>
        /// Funkcja, która tworzy obiekty ViewModel grup krwi
        /// </summary>
        public void CreateBloodTypes()
        {
            // opisy każdej grupy krwi
            string descA = "Grupa A wykształciła się w momencie, gdy człowiek przeszedł z trybu koczowniczego na tryb osiadły i zajął się rolnictwem. " +
                "Mówi się o większej odporności na wirusy osób z tą grupą krwi. Dieta powinna się składać z przewagą pokarmu roślinnego.";
            string descB = "Grupa B wykształciła się w Himalajach, czyli w trudnych warunkach atmosferycznych. Osoby te posiadają silny układ immunologiczny. " +
                "Ich dieta powinna bardziej opierać się na pokarmie mięsnym.";
            string descAB = "Grupa AB jest to najmłodsza grupa krwi, powiązana w grupami A i B. Osoby cechują się wyższą siłą fizyczną. Ich dieta powinna być różnorodna.";
            string descO = "Grupa O jest to najstarsza grupa krwi. Osoby te posiadają silny układ odpornościowy. W diecie powinno sie znaleźć białko zwierzęce.";
            // stworzenie listy wraz ze stworzeniem modeli
            primaryBloodTypes = new List<BloodViewModel>
            {
                new BloodViewModel("A", descA, 32, 6),
                new BloodViewModel("B", descB, 15, 2),
                new BloodViewModel("AB", descAB, 7, 1),
                new BloodViewModel("O", descO, 31, 6)
            };
        }

        /// <summary>
        /// Funkcja, która tworzy obiekty ViewModel koloru oczu
        /// </summary>
        public void CreateEyesColor()
        {
            // opisy każdego koloru oczu
            string descBlue = "Mówi się, że pojawiły się na skutek mutacji około 10 tysięcy lat temu. Mają małą ilość melaniny w podścielisku tęczówki. " +
                "Najpowszechniejsze są w Europie, USA, Kanadzie i Australii.";
            string descGreen = "Mała lub umiarkowana zawartość melaniny. Kolor zielony powstaje z połączenia oczu niebieskich z domieszką ciemnego pigmentu. " +
                "Najczęściej można je spotkać w Irlandii, Europie Połnocnej oraz USA u osób pochodzenia celtyckiego, germańskiego.";
            string descBrown = "Duża zawartość eumelaniny (jedna z form melaniny, ciemny pigment) w podścielisku tęczówki. Jest najczęściej występującą barwą oczu. " +
                "Szczególnie dominuje wśród mieszkańców Ameryki Południowej, Afryki i Azji.";
            string descGray = "Większa zawartość melaniny w tylnej części tęczówki i niewielka w części przedniej. Wypadkowa niebieskiej i zielonej barwy. " +
                "Najczęściej występuje w Europie Wschodniej, północnych Bałkanach i niektórych rejonach Azji.";
            // stworzenie listy wraz ze stworzeniem modeli
            primaryEyesColors = new List<EyesViewModel>
            {
                new EyesViewModel("Niebieski", 7, descBlue),
                new EyesViewModel("Zielony", 1, descGreen),
                new EyesViewModel("Brązowy", 90, descBrown),
                new EyesViewModel("Szary", 2, descGray)
            };
        }

        /// <summary>
        /// Funkcja, która tworzy obiekty ViewModel znaków zodiaku
        /// </summary>
        public void CreateZodiacSigns()
        {
            // opisy każdego znaku zodiaku
            string descAries = "Pierwszy znak zodiaku. Planeta Mars, żywioł ogień. Osoby spod znaku Barana uznaje się za żywiołowe, niecierpliwe.";
            string descTaurus = "Planeta Wenus, żywioł ziemia. Osoby spod tego znaku są wytrwałe i cierpliwe.";
            string descGemini = "Planeta Merkury, żywioł powietrze. Są to osoby pomysłowe i ciekawskie.";
            string descCancer = "Ciało niebieskie Księżyc, żywioł woda. Osoby opiekuńcze i empatyczne.";
            string descLeo = "Gwiazda Słońce, żywioł ogień. Osoby cechują się pewnością siebie, dobrą organizacją.";
            string descVirgo = "Planeta Merkury, żywioł ziemia. Panny cechują się przenikliwośćią i dokładnością.";
            string descLibra = "Planeta Wenus, żywioł powietrze. Waga jest taktowna, towarzyska.";
            string descScorpio = "Planeta karłowata Pluton, żywioł woda. Osoby te są zaradne i pamiętliwe.";
            string descSagittarius = "Planeta Jowisz, żywioł ogień. Są to osoby spontaniczne i bezpośrednie.";
            string descCapricorn = "Planeta Saturn, żywioł ziemia. Osoby spod tego znaku są zdyscyplinowane i dojrzałe.";
            string descAquarius = "Planeta Uran, żywioł powietrze. Wodniki są dalekowzrocznymi indywidualistami.";
            string descPisces = "Planeta Neptun, żywioł woda. Osoby kierujące się intuicją, lojalne i  empatyczne.";
            // stworzenie listy wraz ze stworzeniem modeli
            primaryZodiacSigns = new List<ZodiacViewModel>
            {
                new ZodiacViewModel("Baran", "21 marca - 19 kwietnia", descAries, "~/Aries.png"),
                new ZodiacViewModel("Byk", "20 kwietnia - 20 maja", descTaurus, "~/Taurus.png"),
                new ZodiacViewModel("Bliźnięta", "21 maja - 20 czerwca", descGemini, "~/Gemini.png"),
                new ZodiacViewModel("Rak", "21 czerwca - 22 lipca", descCancer, "~/Cancer.png"),
                new ZodiacViewModel("Lew", "23 lipca - 22 sierpnia", descLeo, "~/Leo.png"),
                new ZodiacViewModel("Panna", "23 sierpnia - 22 września", descVirgo, "~/Virgo.png"),
                new ZodiacViewModel("Waga", "23 września - 22 października", descLibra, "~/Libra.png"),
                new ZodiacViewModel("Skorpion", "23 października - 21 listopada", descScorpio, "~/Scorpio.png"),
                new ZodiacViewModel("Strzelec", "22 listopada - 21 grudnia", descSagittarius, "~/Sagittarius.png"),
                new ZodiacViewModel("Koziorożec", "22 grudnia - 19 stycznia", descCapricorn, "~/Capricorn.png"),
                new ZodiacViewModel("Wodnik", "20 stycznia - 18 lutego", descAquarius, "~/Aquarius.png"),
                new ZodiacViewModel("Ryby", "19 lutego - 20 marca", descPisces, "~/Pisces.png")
            };
        }

        /// <summary>
        /// Funkcja wyśwetla głowną stronę z odnośnikami do innych stron
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Funkcja formularza grup krwi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult SecretsOfBloodForm()
        {
            return View();
        }

        /// <summary>
        /// Zwraca widok wybranej grupy krwi
        /// </summary>
        /// <param name="index"></param>
        /// <param name="rh"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SecretsOfBloodForm(int index, string rh)
        {
            // zapisuje w tempdata index grupy krwi i współczynnik Rh
            TempData["Blood"] = index;
            TempData["Rh"] = rh;
            // poprzez ViewBag wyświetla nazwę grupy krwi oraz jej % wśród populacji i opis
            ViewBag.Type = primaryBloodTypes[index].Type;
            if (rh == "+")
                ViewBag.PercentRh = primaryBloodTypes[index].PercentRhPlus;
            else if (rh == "-")
                ViewBag.PercentRh = primaryBloodTypes[index].PercentRhMinus;
            ViewBag.Description = primaryBloodTypes[index].Description;
            // zachowaj dane w tempdata
            TempData.Keep();
            return View("SecretsOfBloodFormChosen");
        }

        /// <summary>
        /// Wyświetla inne grupy krwi
        /// </summary>
        /// <returns></returns>
        public ActionResult OthersBloodTypes()
        {
            int index = 0;
            string rh = "";
            // odczytuje zapisane dane w tempdata
            if (TempData.ContainsKey("Blood"))
                index = (int)TempData["Blood"];
            if (TempData.ContainsKey("Rh"))
                rh = TempData["Rh"].ToString();
            // wyświetla % populacji, która ma taką samą grupę krwi, ale przeciwny znak Rh
            ViewBag.Type = primaryBloodTypes[index].Type;
            if (rh == "+")
            {
                ViewBag.Rh = "-";
                ViewBag.PercentRh = primaryBloodTypes[index].PercentRhMinus;
            }
            else if (rh == "-")
            {
                ViewBag.Rh = "+";
                ViewBag.PercentRh = primaryBloodTypes[index].PercentRhPlus;
            }
            // przekazuje listę z modelami grup krwi oprócz poprzedniej wybranej
            List<BloodViewModel> othersTypesBlood = primaryBloodTypes;
            // usuwa wcześniej wybraną grupę krwi
            othersTypesBlood.RemoveAt(index);
            return View(othersTypesBlood);
        }

        /// <summary>
        /// Funkcja formularza koloru oczu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult EyesWindowToTheSoulForm()
        {
            return View();
        }

        /// <summary>
        /// Zwraca widok wybranego koloru oczu
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult EyesWindowToTheSoulForm(int index)
        {
            // zapisuje index wskazujący na model koloru oczu w tempdata
            TempData["Color"] = index;
            // za pomocą ViewBag wyświetla wszystkie dostępne informacje o danym kolorze oczu
            ViewBag.Color = primaryEyesColors[index].Color;
            ViewBag.Percent = primaryEyesColors[index].Percent;
            ViewBag.Description = primaryEyesColors[index].Description;
            // zachowuje dane w tempdata
            TempData.Keep();
            return View("EyesWindowToTheSoulFormChosen");
        }

        /// <summary>
        /// Wyświetla pozostałe kolory oczu
        /// </summary>
        /// <returns></returns>
        public ActionResult OthersEyesColors()
        {
            int index = 0;
            // odbiera dane z tempdata
            if (TempData.ContainsKey("Color"))
                index = (int)TempData["Color"];
            // przekazuje listę modeli koloru oczu
            List<EyesViewModel> othersEyesColors = primaryEyesColors;
            // usuwa z nich wybrany wcześniej kolor
            othersEyesColors.RemoveAt(index);
            return View(othersEyesColors);
        }

        /// <summary>
        /// Funkcja formularza znaków zodiaku
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ZodiacSignsForm()
        {
            return View();
        }

        /// <summary>
        /// Wyświetla wybrany znak zodiaku
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ZodiacSignsForm(int index)
        {
            // zapisuje w tempdata index wskazujący na znak zodiaku
            TempData["Sign"] = index;
            // za pomocą ViewBag wyświetla wszystkie dostępne informacje o wybranym znaku zodiaku
            ViewBag.Sign = primaryZodiacSigns[index].Sign;
            ViewBag.Date = primaryZodiacSigns[index].Date;
            ViewBag.Description = primaryZodiacSigns[index].Description;
            ViewBag.Photo = primaryZodiacSigns[index].Photo;
            // zachowuje dane w tempdata
            TempData.Keep();
            return View("ZodiacSignsFormChosen");
        }

        /// <summary>
        /// Wyświetla pozostałe znaki zodiaku
        /// </summary>
        /// <returns></returns>
        public ActionResult OthersZodiacSigns()
        {
            int type = 0;
            // odczytuje dane z temodata
            if (TempData.ContainsKey("Sign"))
                type = (int)TempData["Sign"];
            // przekazuje listę modeli znaków zodiaku
            List<ZodiacViewModel> othersZodiacSigns = primaryZodiacSigns;
            // z wyjątkiem wcześniej wybranego
            othersZodiacSigns.RemoveAt(type);
            return View(othersZodiacSigns);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
