﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;

namespace Fiszki_projekt
{
    public class Engine : LearningProcessManager, WordClassifier, WordGetter, Initializer, WordSetter
    {
        
        PhrasesDBImplementation phrasesDBImplementationObject = new PhrasesDBImplementation();
        KnownWordsDBImplementation knownWordsDBImplementationObject = new KnownWordsDBImplementation();
        public List<(int,string, string)> phrases;

        private int firstLanguageId = 3; // te zmienne powinne byc przypisane przez gui
        private int secondLanguageId = 4;


        public Engine()
        {
           phrases = phrasesDBImplementationObject.getWord(1, firstLanguageId, secondLanguageId);
        }

        public string setCurrentWordinFirstLanguage()
        {
            if (phrases.Count > 0)
            {
                return phrases.ElementAt(0).Item2;
            }
            return "//Koniec cwiczenia//";
        }
        public string getCurrentWordinFirstLanguage()
        {
            if (phrases.Count > 0)
            {
                return phrases.ElementAt(0).Item2;
            }
            return "//Koniec cwiczenia//";
        }

        public string getCurrentWordInSecondLanguage()
        {

            if (phrases.Count > 0)
            {
                return phrases.ElementAt(0).Item3;
            }
            return "//Koniec cwiczenia//";
        }

        public void storeKnownWords()
        {
            // jezeli slowko nie jest zapisane to je zapisz
            if (!knownWordsDBImplementationObject.isWordKnown(phrases.ElementAt(0).Item1, firstLanguageId, secondLanguageId))
            {
                knownWordsDBImplementationObject.storeKnownWorld(phrases.ElementAt(0).Item1, firstLanguageId, secondLanguageId, getCurrentWordinFirstLanguage(), getCurrentWordInSecondLanguage());
            }
           
        }
        

       


    }
}
