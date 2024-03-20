using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class TienDo
    {
        private string tienDoId;
        private string noiDung;
        private int phanTram;
        private string deTaiId;

        public TienDo() { }
        public TienDo(string tienDoId, string noiDung, int phanTram, string deTaiId)
        {
            this.tienDoId = tienDoId;
            this.noiDung = noiDung;
            this.phanTram = phanTram;
            this.deTaiId = deTaiId;
        }

        public string TienDoId { get => tienDoId; set => tienDoId = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int PhanTram { get => phanTram; set => phanTram = value; }
        public string DeTaiId { get => deTaiId; set => deTaiId = value; }
    }
}
