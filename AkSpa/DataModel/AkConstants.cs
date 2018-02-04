﻿using System.Collections.Generic;

namespace AKSpa.DataModel
{
    public class AkRoles
    {
        public const string SuperNintendo = "SuperNintendo";
        public const string Medlem = "Medlem";
        public const string Editor = "Editor";
        public const string Balett = "Balett";
        public static readonly IList<string> Roles = new List<string> {
            SuperNintendo,
            Medlem,
            Editor,
            Balett
        };
    }
    public class AkInstruments
    {
        public const string Altsax = "Altsax";
        public const string Balett = "Balett";
        public const string Banjo = "Banjo";
        public const string Barytonsax = "Barytonsax";
        public const string Euphonium = "Euphonium";
        public const string Flute = "Flöjt";
        public const string Horn = "Horn";
        public const string Klarinett = "Klarinett";
        public const string Oboe = "Oboe";
        public const string Slagverk = "Slagverk";
        public const string Tenorsax = "Tenorsax";
        public const string Trombon = "Trombon";
        public const string Trumpet = "Trumpet";
        public const string Tuba = "Tuba";
        
        public static readonly IList<string> Instrument = new List<string>()
        {
            Altsax,
            Balett,
            Banjo,
            Barytonsax,
            Euphonium,
            Flute,
            Horn,
            Klarinett,
            Oboe,
            Slagverk,
            Tenorsax,
            Trombon,
            Trumpet,
            Tuba
        };
    }
    public class AkFika
    {
        public const string Sax = "Sax";
        public const string Balett = "Balett";
        public const string Komp = "Komp";
        public const string Klarinett = "Klarinett";
        public const string Flute = "Flöjt";
        public const string Trombon = "Trombon";
        public const string Trumpet = "Trumpet";
        public static readonly IList<string> Sektioner = new List<string>()
        {
            Balett,
            Flute,
            Klarinett,
            Komp,
            Sax,
            Trombon,
            Trumpet
        };
    }
    public class AkSpeltyp
    {
        public const string Stand = "Stå";
        public const string Walk = "Gå";
        public const string StandWalk = "Stå och gå";
        public static readonly IList<string> Speltyper = new List<string>()
        {
            Stand,
            Walk,
            StandWalk
        };
    }
    public class AkPoster
    {
        public const string OK = "Överkamerer";
        public const string SK = "Skrivkamerer";
        public const string KK = "Kamrerskamerer";
        public const string Balettkamerer = "Balettkamerer";
        public const string Busskamerer = "Busskamerer";
        public const string Kamerakamerer = "Kamerakamerer";
        public const string Myskamerer = "Myskamerer";
        public const string Musikkamerer = "Musikkamerer";
        public const string Nintendokamerer = "Nintendokamerer";
        public const string Nostalgikamerer = "Nostalgikamerer";
        public const string Notkamerer = "Notkamerer";
        public const string Prkamerer = "Pr-kamerer";
        public const string Prylkamerer = "Prylkamerer";
        public const string Pubkamerer = "Pubkamerer";
        public const string Sexkamerer = "Sexkamerer";
        public const string Skrubbkamerer = "Skrubbkamerer";
        public const string Sponsringskamerer = "Sponsringskamerer";
        public const string Stämledare = "Stämledare";
        public static readonly IList<string> Poster = new List<string>()
        {
            OK,
            SK,
            KK,
            Balettkamerer,
            Busskamerer,
            Kamerakamerer,
            Myskamerer,
            Musikkamerer,
            Nintendokamerer,
            Nostalgikamerer,
            Notkamerer,
            Prkamerer,
            Prylkamerer,
            Pubkamerer,
            Sexkamerer,
            Skrubbkamerer,
            Sponsringskamerer,
            Stämledare
        };
    }

    public class AkEventTypes
    {
        public const string Spelning = "Spelning";
        public const string Rep = "Rep";
        public const string KarRep = "Kårhusrep";
        public const string FikaRep = "Fikarep";
        public const string Fest = "Fest";

        public static readonly IList<string> Types = new List<string>()
        {
            Spelning,
            Rep,
            KarRep,
            FikaRep,
            Fest
        };
    }

    public class AkSignupType
    {
        public const string Halan = "Hålan";
        public const string Direct = "Direkt";
        public const string CantCome = "Kan inte komma";

        public static readonly IList<string> Types = new List<string>()
        {
            Halan,
            Direct,
            CantCome
        };
    }

    public class AkMedals
    {
        public const string Pasen = "Påsen";
        public const string Hornet = "Hornet";
        public const string Klovern = "Klövern";
        public const string Keruben = "Keruben";
        public const string Dollarn = "Dollarn";
        public const string Gubben = "Gubben";

        public static readonly IList<string> TermMedals = new List<string>()
        {
            Pasen,
            Hornet,
            Klovern,
            Keruben,
            Dollarn,
            Gubben,
        };
    }

    public class AkMediaTags
    {
        public const string Albumomslag = "Albumomslag";
        public const string Allmän = "Allmän";
        public const string Balett = "Balett";
        public const string Dokument = "Dokument";
        public const string Ikoner = "Ikoner";
        public const string Startsidebilder = "Startsidebilder";

        public static readonly IList<string> MediaTags = new List<string>()
        {
            Albumomslag,
            Allmän,
            Balett,
            Dokument,
            Ikoner,
            Startsidebilder
        };
    }

    public class AkNationer
    {
        public const string Ostgota = "Östgöta nation";
        public const string Vastgota = "Västgöta nation";
        public const string Lund = "Lunds Nation";
        public const string Malmo = "Malmö nation";
        public const string Helsingkrona = "Helsingkrona nation";
        public const string Sydskanska = "Sydskånska nationen";
        public const string Kristianstad = "Kristianstads nation";
        public const string Blekingska = "Blekingska nationen";
        public const string Goteborg = "Göteborgs nation";
        public const string Halland = "Hallands nation";
        public const string Kalmar = "Kalmar nation";
        public const string Wermland = "Wermlands nation";
        public const string NoNation = "Ingen nation";

        public static readonly IList<string> Nationer = new List<string>()
        {
            Ostgota,
            Vastgota,
            Lund,
            Malmo,
            Helsingkrona,
            Sydskanska,
            Kristianstad,
            Blekingska,
            Goteborg,
            Halland,
            Kalmar,
            Wermland,
            NoNation
        };
    }
}

