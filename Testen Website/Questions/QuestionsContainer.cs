using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Testen_Website.Models;

namespace Testen_Website.Questions
{
    public class QuestionsContainer
    {
        public List<Question> GetAllQuestions()
        {
            List<Question> allQuestions = new List<Question>();

            allQuestions.AddRange(GetQuestionsAnalysis());
            allQuestions.AddRange(GetQuestionsQualifications());

            return allQuestions;
        }

        public List<Question> GetQuestionsAnalysis()
        {
            //Collection of all the questions
            var questions = new List<Question>();

            //Question(Type of input used, Question?, array of answers, array of points(index corresponding to array of answers), type of the point
            //If points is int then all answers will have the same point value
            questions.Add(new Question(101, "Hvilke funktioner findes i din virksomhed: (vælg flere)",
                "checkbox",
                new[]
                {
                    "Vi har møde bookere, der ringer telesalg, telemarketing og/eller mødebooking",
                    "Vi har sælgere, der aftaler møder med kunde-emner, og laver tilbud",
                    "Vi har marketing medarbejdere, der brander og annoncerer vores virksomhed, f.eks. via nyhedsbreve",
                    "Vi har service medarbejdere, der håndterer kundespørgsmål, service og kundeklager"
                },
                new[] {1, 1, 1, 1},
                "need")
            );
            questions.Add(new Question(102, "Hvilke udsagn passer på din virksomhed: (vælg flere)",
                "checkbox",
                new[]
                {
                    "Vores medarbejdere har behov for at se, hvad andre medarbejdere har planlagt af aktiviteter",
                    "Vi har behov for at se, hvilke e-mails der er sendt til og modtaget fra vores kunder og emner",
                    "Vi sælger abonnementsbaserede produkter eller services (kontrakt fakturering)",
                    "Vi har selv en IT afdeling, der udvikler og drifter IT applikationer"
                },
                new[] {1, 1, 1, 1},
                "need")
            );
            questions.Add(new Question(103, "Hvad mener du er vigtigst for jeres organisation?",
                "radio",
                new[]
                {
                    "At sikre nye kunder",
                    "At holde på eksisterende kunder",
                    "At sælge mere til eksisterende kunder"
                },
                new[] {3, 2, 2},
                "need")
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
                    "At kunne rapportere status til ledelsen"
                },
                new[] {3, 2, 2, 2, 2, 1, 0},
                "need")
            );
            questions.Add(new Question(105, "Hvor meget erfaring har jeres organisation med CRM systemer?",
                "radio",
                new[]
                {
                    "Ingen (bruger papirkalender)",
                    "Næsten ingen (bruger f.eks Excel eller Outlook til CRM opgaver)",
                    "Noget (vi har et CRM system, men få bruger det)",
                    "En del (vi har et CRM system, de fleste bruger det)",
                    "Meget l (vi har et CRM system, alle bruger det)",
                    "Særdeles meget (alle har i årevis brugt et CRM system dagligt)"
                },
                new[] {0, 1, 2, 3, 4, 5},
                "need")
            );
            questions.Add(new Question(106, "Hvad er jeres dominerende holdning til CRM systemer?",
                "radio",
                new[]
                {
                    "Vi synes det er tidsspilde",
                    "Vi har ingen holdning til dem",
                    "Vi er vilde med dem"
                },
                new[] {0, 1, 2},
                "need")
            );

            return questions;
        }

        public List<Question> GetQuestionsQualifications()
        {
            //Collection of all the questions
            var questions = new List<Question>();

            //Question(Type of input used, Question?, array of answers, array of points(index corresponding to array of answers), type of the point
            questions.Add(new Question(201, "Hvor mange medarbejdere er i organisationen?",
                "radio",
                new[]
                {
                    "1 - 5",
                    "5 - 10",
                    "10 - 30",
                    "30 - 100",
                    "100 - 1000",
                    "1000+"
                },
                new[] {1, 2, 3, 4, 5, 6},
                "qualification")
            );
            questions.Add(new Question(202, "Hvor mange af medarbejderne bør bruge et CRM system?",
                "radio",
                new[]
                {
                    "1 - 5",
                    "5 - 10",
                    "10 - 30",
                    "30 - 100",
                    "100 - 1000",
                    "1000+"
                },
                new[] {1, 2, 3, 4, 5, 6},
                "qualification")
            );
            questions.Add(new Question(203, "I hvor mange lande er organisationen repræsenteret?",
                "radio",
                new[]
                {
                    "1",
                    "2-3",
                    "4-10",
                    "10"
                },
                new[] {1, 2, 3, 4},
                "qualification")
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
                    "Offentlige ydelser"
                },
                new[] {4, 3, 2, 1, 1, 1},
                "qualification")
            );
            questions.Add(new Question(205, "Hvilke IT systemer anvender organisationen primært? (vælg gerne flere)",
                "checkbox",
                new[]
                {
                    "Microsoft Windows",
                    "Office 365",
                    "iOS (Mac)",
                    "G-suite (Google mail, Google calendar)"
                },
                new[] {1, 1, -15, -20},
                "qualification")
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
                    "Andet"
                },
                new[] {5, 3, 0, 0, 0, -5, 0},
                "qualification")
            );

            return questions;
        }
    }
}