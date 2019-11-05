using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitecMVAPI.Models;

namespace VitecMVAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;

            if(_context.Products.Count() == 0)
            {
                _context.Products.Add(new Product { 
                    Id = 1,
                    Name = "CD-ORD",
                    Description = "Dette er CD-ORD",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/CDORD_gradient.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 2,
                    Name = "SubReader School",
                    Description = "Med appen SubReader School sikrer du, at læseudfordrede elever kan følge med i dialogen, når du som lærer bruger udenlandske film og tv-serier i undervisningen. " +
                    "Det foregår diskret på elevens egen smartphone," +
                    "uden at oplæsningen generer de andre elever – og uden at stigmatisere eleven," +
                    "der har behov for oplæsning.Eleven får underteksterne læst op i sine høretelefoner og kan følge replikkerne på smartphonens skærm." +
                    "SubReader School skaber en kæmpe forskel både fagligt og socialt for den læseudfordrede elev, der nu både kan følge filmens handling og dialog og – ikke mindst – kan snakke med om og bidrage til gruppearbejde om filmen.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/Logo-SubReader-School-only-icon.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 3,
                    Name = "C-Pen",
                    Description = "Brug C-Pen, når du vil skanne svære ord eller uddrag af en tekst fra trykte materialer, fx fra avisen, en matematikbog eller et opgaveark." +
                    "Pennen føres over teksten(som du ville gøre med en overstregningstusch)," +
                    "og den skannede tekst overføres til computeren," +
                    "fx dit tekstbehandlingsprogram.Her kan du få teksten læst op med læse - og skrivestøtteprogrammet CD - ORD(uden brug af tastatur og mus, hvis du bruger den integrerede C - Pen - knap i CD - ORD)." +
                    "C - Pen overfører skanninger til computeren via USB - stik.Denne version kræver ikke batteri og egner sig til brugere," +
                    "der kun ønsker at overføre tekst til deres computer.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/09/c-pen-150x150.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 4,
                    Name = "Grammateket",
                    Description = "Grammateket kan rette din tekst for fejl i grammatik, sætningsopbygning og tegnsætning. Vil du lære grammatik," +
                    "kan du dykke ned i programmets forklaringer af rettelser.Grammateket egner sig også til undervisning og læring." +
                    "Al tekst i Grammateket kan læses op, hvilket naturligvis giver en helt særlig hjælp til skriveudfordrede elever.Ved prøven i skriftlig fremstilling i dansk må alle elever bruge Grammateket." +
                    "Grammateket hjælper dig med:" +
                    "• stavekontrol" +
                    "• sammensatte ord(særskrivning)" +
                    "• nutids - r" +
                    "• kort og lang tillægsform" +
                    "• stort begyndelsesbogstav" +
                    "• kommatering." +
                    "Programmet arbejder kontekstbaseret, hvilket giver ekstra tekstnære forslag til rettelser og kræver færre valg fra brugeren.Du kan tjekke ord og eksempler på brug i programmets tilknyttede Ordbog(baseret på Den Danske Ordbog).",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/grammateket-gradient-150x150.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 5,
                    Name = "Hukommelsesleg Flex",
                    Description = "Arbejdshukommelsen er selve fundamentet for læring. Evnen til at kunne holde og bearbejde informationer er centrale for mentale aktiviteter som at læse, regne og løse problemer." +
                    "Hukommelsesleg Flex sigter på at forbedre koncentration, opmærksomhedsspændvidde, selvtillid og læringspotentiale for den, der træner.Hermed kan han eller hun opnå bedre faglige resultater og få mere struktur i hverdagen." +
                    "Udførlige vejledninger, logbog, belønnings - og evalueringsskemaer hjælper med at gennemføre træningen.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/HukommelseslegPige-1-150x150.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 6,
                    Name = "Håndskanner",
                    Description = "Håndskanneren bruges til at gøre papirtekster digitale, så de kan gøres tilgængelige for oplæsning på computeren." +
                    "Skanneren affotograferer og gemmer tekstsiden som et billede(JPG), som du kan overføre til computeren.Læse - og skriveprogrammerne CD - ORD og IntoWords kan herefter OCR - behandle billedet og læse teksten op for dig." +
                    "Håndskanneren er en fast del af  vores IT - Rygsæk",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/handskanner-1-150x150.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 7,
                    Name = "IT-Rygsæk",
                    Description = "IT-Rygsækken indeholder de redskaber, du skal bruge for at kunne læse og skrive som ordblind: computer,  software og værktøjer til tilgængelighed (OCR). IT - Rygsækken er et personligt hjælpemiddel," +
                    "der kan tages med og bruges lige der, hvor behovet for støtte til læsning og skrivning opstår.IT - Rygsækken bruges både hjemme og i skolen, på uddannelse eller job." +
                    "Værktøjerne har til formål at gøre den ordblinde bruger selvhjulpen og er en vigtig del af et inkluderende miljø på skoler, institutioner eller arbejdspladser.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/itrygsaek-150x150.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 8,
                    Name = "Matematikleg Flex",
                    Description = "Matematikleg Flex kan forbedre den matematiske evne hos børn og unge, der har særligt svært ved matematik, typisk som følge af talblindhed, koncentrationsbesvær eller dysleksi. " +
                    "Programmet træner centrale matematiske færdigheder, såsom antalsopfattelse, talforståelse og den mentale tallinje.Formålet med træningen er at konsolidere matematisk viden for dermed at lette senere matematisk indlæring.Træningen har også afsmittende effekt på elevens tilgang til andre naturfag.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/Matematiklegflex-150x150.png"
                });


                _context.Products.Add(new Product
                {
                    Id = 9,
                    Name = "MindView AT",
                    Description = "Med programmet MindView AT bruger du mindmapping-metoden til at komme fra brainstorm til færdig skriftlig opgave, præsentation eller projektplan. Elever og studerende, der tænker visuelt, får her hjælp til studieteknik," +
                    "skriveopgaver og projektplanlægning.De kan fx bruge mindmapping - metoden til brainstorming af nye ideer,til at visualisere, forstå og huske et fagligt emne eller til at strukturere information, noter og kilder. Det færdige mindmap, inklusive billeder, videoer,links og noter," +
                    "kan nemt eksporteres til Microsoft Word, PowerPoint eller Excel og struktureres her automatisk i overskrifter og afsnit. Hjælpefunktioner som tekst til tale, integration med CD - ORD, Dragon® og til skærmlæsere, prædiktiv tekst og lydnoter gør MindView AT(Assistive Technology)  særligt velegnet til elever med indlæringsvanskeligheder.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2019/01/MV_Logo.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 10,
                    Name = "MiVo",
                    Description = "MiVo er et træningsprogram, der knytter sig til skrivehjælpen i de to læse- og skriveværktøjer CD-ORD og IntoWords. Lærere og undervisere får et hurtigt og effektivt værktøj til at introducere ordblinde elever og studerende til skrivning med lydret stavning, ordforslag og jokertegn." +
                    "Programmets øvelser opbygger en rolig og naturlig progression i stavearbejdet og skaber gode rutiner.Og brugerne guides hele vejen af videoer og oplæsning. MiVo er udviklet i samarbejde med kursusvirksomheden Ordblindetræning og bygger på deres succesmetode.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/mivo-logo-150x150.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 11,
                    Name = "Ordbøger til CD-ORD og IntoWords",
                    Description = "Ordbøgerne gør det nemt at få forklaringer på ord, du ikke kender, direkte fra teksten – slå ordet op i ordbogen med et klik eller et tryk. Ordbogspakken – bilingvale ordbøger. Med Ordbogspakken får du nem adgang til at oversætte til og fra engelsk, tysk, " +
                    "fransk og spansk med CD - ORD og IntoWords Cloud. Ordbogspakken bruges til både uddannelse og job, fx til at tjekke ords betydning ved læsning af tekster, til at styrke ordforrådet og i arbejdet med retskrivning eller i grammatik. Svage læsere eller stavere får ekstra støtte," +
                    "da al tekst kan læses op, ligesom du får skrivehjælp og genveje, der gør det nemmere og hurtigere at slå ord op end i almindelige digitale ordbøger.Med funktionen  ‘slå op i Google Billeder’ kan ord også tjekkes visuelt." +
                    "Sundhedsfaglig ordbog. Tilkøb Munksgaards Sundhedsfaglige Ordbog til din IntoWords Android, og få nem adgang til forklaringer på sundhedsfaglige termer som fx hæmoptyse og mèche. Ordbogen er målrettet dig, der arbejder i sundhedssektoren eller er ved at uddanne inden for en social-og sundhedsuddannelse eller som klinikassistent.Bogen indeholder mere end 4.000 opslag." +
                    "Få letforståelige forklaringer og oversættelser af begreber inden for anatomi, fysiologi, sygdomslære, undersøgelser, lægemidler og behandlinger.Kender du det danske ord, men mangler et bestemt fagudtryk, kan du også slå det op her.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2018/05/ordbogspakken-150x150.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 12,
                    Name = "IntoWords",
                    Description = "IntoWords læser tekst op for dig på din computer, tablet eller smartphone. Når du skal skrive, får du hjælp af kontekstbaserede ordforslag, ordprædiktion og stavehjælp." +
                    "Med støtten fra programmet får du frigivet energi til at koncentrere dig om det vigtige i teksten: Indholdet.IntoWords kan være vejen til højere karakterer i skolen, bedre resultater på jobbet og større selvtillid eller frihed i tilværelsen" +
                    "IntoWords er en pendant til pc - værktøjet CD - ORD – baseret på samme intelligente teknologi, men til brug online og på tværs af platforme.",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2017/11/INTOWORDS_gradient.png"
                });

                _context.Products.Add(new Product
                {
                    Id = 13,
                    Name = "Lego(r) Education Produkter",
                    Description = "Lego(r) Education Produkter",
                    Image = "https://www.mv-nordic.com/wp-content/uploads/2018/08/lego-education-1.jpg"
                });

                _context.Products.Add(new Product
                {
                    Id = 14,
                    Name = "Stemmepakken",
                    Description = "Her ser du en liste over de sprog, du kan få læst op på via Stemmepakken. Stemmerne kan bruges i CD-ORD (Windows) og IntoWords iPad og Cloud (herunder Google Apps og Office 365)." +
                    "Amerikansk, Australsk, Arabisk, Canadisk, Finsk, Græsk, Hollandsk, Indisk, Indonesisk, Israelsk, Italiensk, Japansk, Kinesisk, Koreansk, Mexicansk, Norsk, Polsk, Portugisisk, Rumænsk, Russisk, Slovakisk, Svensk, Thailandsk, Tjekkisk, Ungarsk",
                    Image = null
                }); 

                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(long id)
        {
            var productItems = await _context.Products.FindAsync(id);

            if(productItems == null)
            {
                return NotFound();
            }

            return productItems;
        }
    }
}