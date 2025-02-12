﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Fiszki_projekt
{
    interface KnownWordsDBInterface
    {
        void storeKnownWord (int phraseId,int firstLanguageId, int secondLanguageId, string phraseInFirstLanguage, string phraseInSecondLanguage,SqlConnection sqlCon);

        bool isWordKnown(int phraseId,int firstLanguageId, int secondLanguageId, SqlConnection sqlCon);

        string languageIdToName(int languageId);
    }
}
