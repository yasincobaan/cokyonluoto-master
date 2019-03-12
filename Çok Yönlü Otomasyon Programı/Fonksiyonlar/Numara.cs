﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çok_Yönlü_Otomasyon_Programı.Fonksiyonlar
{
    class Numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();
        public string StokKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_STOKLAR
                                        orderby s.ID descending
                                        select s).First().STOKKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }

        }
        public string CariKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_CARİLER
                                        orderby s.ID descending
                                        select s).First().CARİKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }

        }
        public string KasaKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_KASALAR
                                        orderby s.ID descending
                                        select s).First().KASAKODU);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }

        }
    }
}
