using System;
using System.Collections.Generic;
using System.IO;


namespace WordParser
{

    // Класс для работы с файлами
    class CFilesWork
    {
        private List<string> lFiles; // Список файлов 


        // Поиск файлов в папке
        public List<string> GetFiles(string sFolder, string sExtension)
        {
            lFiles = new List<string>();
            DirSearch(sFolder, sExtension);  // Рекурсивный поиск файлов по маске, заполнение списка файлов
            return lFiles;
        }


        // Рекурсивный поиск файлов по маске, заполнение списка файлов
        private void DirSearch(string sFolder, string sExt)
        {
            try
            {
                foreach (string f in Directory.GetFiles(sFolder, sExt)) { lFiles.Add(f); }      // Перебираем файлы
                foreach (string d in Directory.GetDirectories(sFolder)) { DirSearch(d, sExt); } // Перебираем подпапки                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }


}


