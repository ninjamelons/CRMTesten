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

            questions.Add(new QuestionRep(1, "checkbox", "Hvilke funktioner findes i din virksomhed: (Vælg gerne flere)", new List<Answer>()
            {
                new Answer("Vi har mødebookere, der ringer telesalg, telemarketing og/eller mødebooking", "360"),
                new Answer("Vi har sælgere, der aftaler møder med kunde-emner og laver tilbud", "360"),
                new Answer("Vi har marketing medarbejdere, der brander og annoncerer vores virksomhed, f.eks. via nyhedsbreve", "360"),
                new Answer("Vi har service medarbejdere, der håndterer kundespørgsmål, service og kundeklager", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(2, "checkbox", "Hvilke udsagn passer på din virksomhed: (Vælg gerne flere)", new List<Answer>()
            {
                new Answer("Vores medarbejdere har behov for at se, hvad andre medarbejdere har planlagt af aktiviteter", "360"),
                new Answer("Vi har behov for at se hvilke e-mails der er sendt til, og modtaget fra, vores kunder og emner", "360"),
                new Answer("Vi sælger abonnementsbaserede produkter eller services (kontrakt fakturering)", "360"),
                new Answer("Vi har selv en IT afdeling, der udvikler og drifter IT applikationer", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(3, "radio", "Hvad mener du er vigtigst for jeres organisation?" , new List<Answer>()
            {
                new Answer("At sikre nye kunder", "360"),
                new Answer("At holde på eksisterende kunder", "360"),
                new Answer("At sælge mere til eksisterende kunder", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(4, "radio", "Hvad mener du er vigtigst at få ud af et CRM system i jeres organisation:", new List<Answer>()
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
            questions.Add(new QuestionRep(5, "radio", "Hvor meget erfaring har jeres organisation med CRM systemer?", new List<Answer>()
            {
                new Answer("Ingen (bruger papirkalender)", "360"),
                new Answer("Næsten ingen (bruger f.eks Excel eller Outlook til CRM opgaver)", "360"),
                new Answer("Noget (vi har et CRM system, men få bruger det)", "360"),
                new Answer("En del (vi har et CRM system, de fleste bruger det)", "360"),
                new Answer("Meget (vi har et CRM system, alle bruger det)", "360"),
                new Answer("Særdeles meget (alle har i årevis brugt et CRM system dagligt)", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(6, "radio", "Hvad er jeres overvejende holdning til CRM systemer?", new List<Answer>()
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

            questions.Add(new QuestionRep(7, "radio", "Hvor mange medarbejdere arbejder i jeres organisation?", new List<Answer>()
            {
                new Answer("1 - 3", "small"),
                new Answer("3 - 10", "360"),
                new Answer("10 - 30", "360"),
                new Answer("30 - 100", "360"),
                new Answer("100 - 1000", "big"),
                new Answer("1000+", "big"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(8, "radio", "Hvor mange af medarbejderne bør, efter din mening, bruge et CRM system?", new List<Answer>()
            {
                new Answer("1 - 3", "max3"),
                new Answer("3 - 10", "max10"),
                new Answer("10 - 30", "max30"),
                new Answer("30 - 100", "max100"),
                new Answer("100 - 1000", "max1000"),
                new Answer("1000+", "max1000+"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(9, "radio", "I hvor mange lande er jeres organisation repræsenteret?", new List<Answer>()
            {
                new Answer("1", "360"),
                new Answer("2-3", "360"),
                new Answer("4-10", "360"),
                new Answer("10", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(10, "checkbox", "Hvad beskæftiger organisationen sig primært med? (Vælg gerne flere)", new List<Answer>()
            {
                new Answer("Salg", "360"),
                new Answer("IT", "360"),
                new Answer("Service", "360"),
                new Answer("Produktion", "360"),
                new Answer("Håndværk", "360"),
                new Answer("Offentlige ydelser", "360"),
                new Answer("Andet / Ved ikke", "360")
            }));
            questions.Add(new QuestionRep(11, "checkbox", "Hvilke IT systemer anvender organisationen primært? (Vælg gerne flere)", new List<Answer>()
            {
                new Answer("Microsoft Windows", "360"),
                new Answer("Office 365", "360"),
                new Answer("iOS (Mac)", "no"),
                new Answer("G-suite (Google mail, Google calendar)", "no"),
                new Answer("Andet / Ved ikke", "360")
            }));
            
            questions.Add(new QuestionRep(12, "radio", "Hvilket økonomisystem anvender organisationen?", new List<Answer>()
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
    }
}