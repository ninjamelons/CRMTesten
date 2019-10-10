using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Testen_Website.Models;

namespace Testen_Website.Questions
{
    public class QuestionsContainer
    {
        public List<QuestionRep> GetQuestionsAnalysisRep()
        {
            var questions = new List<QuestionRep>();

            questions.Add(new QuestionRep(101, "checkbox", "Hvilke funktioner findes i din virksomhed: (vælg gerne flere)", new List<Answer>()
            {
                new Answer("Vi har møde bookere, der ringer telesalg, telemarketing og/eller mødebooking", "360"),
                new Answer("Vi har sælgere, der aftaler møder med kunde-emner, og laver tilbud", "360"),
                new Answer("Vi har marketing medarbejdere, der brander og annoncerer vores virksomhed, f.eks. via nyhedsbreve", "360"),
                new Answer("Vi har service medarbejdere, der håndterer kundespørgsmål, service og kundeklager", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(102, "checkbox", "Hvilke udsagn passer på din virksomhed: (vælg gerne flere)", new List<Answer>()
            {
                new Answer("Vores medarbejdere har behov for at se, hvad andre medarbejdere har planlagt af aktiviteter", "360"),
                new Answer("Vi har behov for at se hvilke e-mails der er sendt til, og modtaget fra, vores kunder og emner", "360"),
                new Answer("Vi sælger abonnementsbaserede produkter eller services (kontrakt fakturering)", "360"),
                new Answer("Vi har selv en IT afdeling, der udvikler og drifter IT applikationer", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(103, "radio", "Hvad mener du er vigtigst for jeres organisation?" , new List<Answer>()
            {
                new Answer("At sikre nye kunder", "360"),
                new Answer("At holde på eksisterende kunder", "360"),
                new Answer("At sælge mere til eksisterende kunder", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(104, "radio", "Hvad mener du er vigtigst at få ud af et CRM system i jeres organisation:", new List<Answer>()
            {
                new Answer("At sikre vidensdeling medarbejderne imellem", "360"),
                new Answer("At vi altid husker at følge op på tilbud", "360"),
                new Answer("At gøre hverdagen nem og struktureret", "360"),
                new Answer("At sikre god kommunikation med emner og kunder", "360"),
                new Answer("At vi prioriterer vores tid rigtigt", "360"),
                new Answer("At synliggøre vores pipeline for salgschefen", "360"),
                new Answer("At kunne rapportere status til ledelsen", "360"),
                new Answer("Alle er lige vigtige", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(105, "radio", "Hvor meget erfaring har jeres organisation med CRM systemer?", new List<Answer>()
            {
                new Answer("Ingen (bruger papirkalender)", "360"),
                new Answer("Næsten ingen (bruger f.eks Excel eller Outlook til CRM opgaver)", "360"),
                new Answer("Noget (vi har et CRM system, men få bruger det)", "360"),
                new Answer("En del (vi har et CRM system, de fleste bruger det)", "360"),
                new Answer("Meget (vi har et CRM system, alle bruger det)", "360"),
                new Answer("Særdeles meget (alle har i årevis brugt et CRM system dagligt)", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(106, "radio", "Hvad er jeres overvejende holdning til CRM systemer?", new List<Answer>()
            {
                new Answer("Vi synes det er tidsspilde", "360"),
                new Answer("Vi har ingen holdning til dem", "360"),
                new Answer("Vi er vilde med dem", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));

            return questions;
        }

        public List<QuestionRep> GetQuestionsQualificationsRep()
        {
            var questions = new List<QuestionRep>();

            questions.Add(new QuestionRep(201, "radio", "Hvor mange medarbejdere arbejder i jeres organisation?", new List<Answer>()
            {
                new Answer("1 - 3", "small"),
                new Answer("3 - 10", "360"),
                new Answer("10 - 30", "360"),
                new Answer("30 - 100", "360"),
                new Answer("100 - 1000", "big"),
                new Answer("1000+", "big"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(202, "radio", "Hvor mange af medarbejderne bør, efter din mening, bruge et CRM system?", new List<Answer>()
            {
                new Answer("1 - 3", "max3"),
                new Answer("3 - 10", "max10"),
                new Answer("10 - 30", "max30"),
                new Answer("30 - 100", "max100"),
                new Answer("100 - 1000", "max1000"),
                new Answer("1000+", "max1000+"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(203, "radio", "I hvor mange lande er jeres organisation repræsenteret?", new List<Answer>()
            {
                new Answer("1", "360"),
                new Answer("2-3", "360"),
                new Answer("4-10", "360"),
                new Answer("10", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(204, "checkbox", "Hvad beskæftiger organisationen sig primært med? (vælg gerne flere)", new List<Answer>()
            {
                new Answer("Salg", "360"),
                new Answer("IT", "360"),
                new Answer("Service", "360"),
                new Answer("Produktion", "360"),
                new Answer("Håndværk", "360"),
                new Answer("Offentlige ydelser", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(205, "checkbox", "Hvilke IT systemer anvender organisationen primært? (vælg gerne flere)", new List<Answer>()
            {
                new Answer("Microsoft Windows", "360"),
                new Answer("Office 365", "360"),
                new Answer("iOS (Mac)", "no"),
                new Answer("G-suite (Google mail, Google calendar)", "no"),
                new Answer("Andet / Ved ikke", "360")
            }));
            
            questions.Add(new QuestionRep(206, "radio", "Hvilket økonomisystem anvender organisationen?", new List<Answer>()
            {
                new Answer("e-conomic", "360"),
                new Answer("Navision", "360"),
                new Answer("Axapta", "360"),
                new Answer("Dinero", "360"),
                new Answer("C5", "360"),
                new Answer("Billys", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));

            return questions;
        }

        public List<Question> GetQuestionsAnalysisString()
        {
            //Collection of all the questions
            var questions = new List<Question>();

            //Question(Type of input used, Question?, array of answers, array of points(index corresponding to array of answers), type of the point
            //If points is int then all answers will have the same point value
            questions.Add(new Question(101, "Hvilke funktioner findes i din virksomhed: (vælg gerne flere)",
                "checkbox",
                new[]
                {
                    "Vi har møde bookere, der ringer telesalg, telemarketing og/eller mødebooking",
                    "Vi har sælgere, der aftaler møder med kunde-emner, og laver tilbud",
                    "Vi har marketing medarbejdere, der brander og annoncerer vores virksomhed, f.eks. via nyhedsbreve",
                    "Vi har service medarbejdere, der håndterer kundespørgsmål, service og kundeklager",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360", "360"})
            );
            questions.Add(new Question(102, "Hvilke udsagn passer på din virksomhed: (vælg gerne flere)",
                "checkbox",
                new[]
                {
                    "Vores medarbejdere har behov for at se, hvad andre medarbejdere har planlagt af aktiviteter",
                    "Vi har behov for at se hvilke e-mails der er sendt til, og modtaget fra, vores kunder og emner",
                    "Vi sælger abonnementsbaserede produkter eller services (kontrakt fakturering)",
                    "Vi har selv en IT afdeling, der udvikler og drifter IT applikationer",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360", "360"})
            );
            questions.Add(new Question(103, "Hvad mener du er vigtigst for jeres organisation?",
                "radio",
                new[]
                {
                    "At sikre nye kunder",
                    "At holde på eksisterende kunder",
                    "At sælge mere til eksisterende kunder",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360"})
            );
            questions.Add(new Question(104, "Hvad mener du er vigtigst at få ud af et CRM system i jeres organisation:",
                "radio",
                new[]
                {
                    "At sikre vidensdeling medarbejderne imellem",
                    "At vi altid husker at følge op på tilbud",
                    "At gøre hverdagen nem og struktureret",
                    "At sikre god kommunikation med emner og kunder",
                    "At vi prioriterer vores tid rigtigt",
                    "At synliggøre vores pipeline for salgschefen",
                    "At kunne rapportere status til ledelsen",
                    "Alle er lige vigtige",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360", "360", "360", "360", "360", "360"})
            );
            questions.Add(new Question(105, "Hvor meget erfaring har jeres organisation med CRM systemer?",
                "radio",
                new[]
                {
                    "Ingen (bruger papirkalender)",
                    "Næsten ingen (bruger f.eks Excel eller Outlook til CRM opgaver)",
                    "Noget (vi har et CRM system, men få bruger det)",
                    "En del (vi har et CRM system, de fleste bruger det)",
                    "Meget (vi har et CRM system, alle bruger det)",
                    "Særdeles meget (alle har i årevis brugt et CRM system dagligt)",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360", "360", "360", "360"})
            );
            questions.Add(new Question(106, "Hvad er jeres overvejende holdning til CRM systemer?",
                "radio",
                new[]
                {
                    "Vi synes det er tidsspilde",
                    "Vi har ingen holdning til dem",
                    "Vi er vilde med dem",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360"})
            );

            return questions;
        }

        public List<Question> GetQuestionsQualificationsString()
        {
            //Collection of all the questions
            var questions = new List<Question>();

            //Question(Type of input used, Question?, array of answers, array of points(index corresponding to array of answers), type of the point
            questions.Add(new Question(201, "Hvor mange medarbejdere arbejder i jeres organisation?",
                "radio",
                new[]
                {
                    "1 - 3",
                    "3 - 10",
                    "10 - 30",
                    "30 - 100",
                    "100 - 1000",
                    "1000+",
                    "Andet / Ved ikke"
                },
                new[] {"small", "360", "360", "360", "big", "big", "360"})
            );
            questions.Add(new Question(202, "Hvor mange af medarbejderne bør, efter din mening, bruge et CRM system?",
                "radio",
                new[]
                {
                    "1 - 3",
                    "3 - 10",
                    "10 - 30",
                    "30 - 100",
                    "100 - 1000",
                    "1000+",
                    "Andet / Ved ikke"
                },
                new[] {"max3", "max10", "max30", "max100", "max1000", "max1000+", "360"})
            );
            questions.Add(new Question(203, "I hvor mange lande er jeres organisation repræsenteret?",
                "radio",
                new[]
                {
                    "1",
                    "2-3",
                    "4-10",
                    "10",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360", "360"})
            );
            questions.Add(new Question(204, "Hvad beskæftiger organisationen sig primært med? (vælg gerne flere)",
                "checkbox",
                new[]
                {
                    "Salg",
                    "IT",
                    "Service",
                    "Produktion",
                    "Håndværk",
                    "Offentlige ydelser",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360", "360", "360", "360"})
            );
            questions.Add(new Question(205, "Hvilke IT systemer anvender organisationen primært? (vælg gerne flere)",
                "checkbox",
                new[]
                {
                    "Microsoft Windows",
                    "Office 365",
                    "iOS (Mac)",
                    "G-suite (Google mail, Google calendar)",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "no", "no", "360"})
            );
            questions.Add(new Question(206, "Hvilket økonomisystem anvender organisationen?",
                "radio",
                new[]
                {
                    "e-conomic",
                    "Navision",
                    "Axapta",
                    "Dinero",
                    "C5",
                    "Billys",
                    "Andet / Ved ikke"
                },
                new[] {"360", "360", "360", "360", "360", "360", "360"})
            );

            return questions;
        }
    }
}